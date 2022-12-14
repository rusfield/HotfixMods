using HotfixMods.Core.Models.App;
using HotfixMods.Core.Providers;
using MySqlConnector;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace HotfixMods.Providers.MySql.MySqlConnector.Client
{
    public partial class MySqlClient : IMySqlProvider
    {
        MySqlConnection _mySqlConnection;
        string _hotfixModsSchemaName;
        string _charactersSchemaName;
        string _hotfixesSchemaName;
        string _worldSchemaName;

        public MySqlClient(string server, string port, string user, string password, string hotfixesSchemaName = "hotfixes", string charactersSchemaName = "characters", string worldSchemaName = "world", string hotfixModsSchemaName = "hotfixmods")
        {
            _mySqlConnection = new MySqlConnection($"Server={server}; Port={port}; Uid={user}; Pwd={password};");
            _hotfixModsSchemaName = hotfixModsSchemaName;
            _charactersSchemaName = charactersSchemaName;
            _worldSchemaName = worldSchemaName;
            _hotfixesSchemaName = hotfixesSchemaName;
        }

        public async Task<T?> GetSingleAsync<T>(string? whereClause = null)
            where T : new()
        {
            var db2Columns = await GetSingleAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), ObjectTypeToDb2ColumnDefinitions<T>(), whereClause);
            return Db2ColumnsToObject<T>(db2Columns);
        }

        public async Task<IEnumerable<Db2Column>> GetSingleAsync(string schemaName, string tableName, IEnumerable<Db2ColumnDefinition> definitions, string? whereClause = null)
        {
            return (await GetAsync(schemaName, tableName, definitions, whereClause)).First();
        }

        public async Task<IEnumerable<T>> GetAsync<T>(string? whereClause = null)
            where T : new()
        {
            var db2Rows = await GetAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), ObjectTypeToDb2ColumnDefinitions<T>(), whereClause);
            return db2Rows.Select(d => Db2ColumnsToObject<T>(d));
        }

        public async Task<IEnumerable<IEnumerable<Db2Column>>> GetAsync(string schemaName, string tableName, IEnumerable<Db2ColumnDefinition> definitions, string? whereClause = null)
        {
            ValidateInput(tableName, whereClause);

            if (!definitions.Any())
            {
                throw new Exception("Missing definitions.");
            }

            var results = new List<List<Db2Column>>();

            string columns = "";
            foreach (var definition in definitions)
            {
                ValidateInput(definition.Name);
                columns += $"{definition.Name},";
            }
            columns = columns.Remove(columns.Length - 1);

            var query = $"SELECT {columns} FROM {schemaName}.{tableName}";
            query += string.IsNullOrWhiteSpace(whereClause) ? ";" : $" WHERE {whereClause};";

            using var command = new MySqlCommand(query, _mySqlConnection);

            await _mySqlConnection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                var result = new List<Db2Column>();
                for (int i = 0; i < definitions.Count(); i++)
                {
                    var fieldName = definitions.ElementAt(i).Name;
                    var fieldType = definitions.ElementAt(i).Type;
                    object fieldValue = fieldType.ToString() switch
                    {
                        "System.SByte" => reader.GetSByte(i),
                        "System.Int16" => reader.GetInt16(i),
                        "System.Int32" => reader.GetInt32(i),
                        "System.Int64" => reader.GetInt64(i),
                        "System.Byte" => reader.GetByte(i),
                        "System.UInt16" => reader.GetUInt16(i),
                        "System.UInt32" => reader.GetUInt32(i),
                        "System.UInt64" => reader.GetUInt64(i),
                        "System.String" => reader.GetString(i),
                        "System.Decimal" => (decimal)reader.GetFloat(i),
                        _ => throw new Exception($"{definitions.ElementAt(i).Type} not implemented.")
                    };
                    result.Add(new()
                    {
                        Name = fieldName,
                        Type = fieldType,
                        Value = fieldValue
                    });
                }
                results.Add(result);
            }
            await _mySqlConnection.CloseAsync();

            return results;
        }

        public async Task AddOrUpdateAsync<T>(params T[] db2Rows)
            where T : new()
        {
            if (!db2Rows.Any())
            {
                throw new Exception("Nothing to add or update.");
            }

            await AddOrUpdateAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), db2Rows.Select(r => ObjectToDb2Columns(r)!).ToArray());
        }

        public async Task AddOrUpdateAsync(string schemaName, string tableName, params IEnumerable<Db2Column>[] db2Rows)
        {
            ValidateInput(schemaName, tableName);

            if (!db2Rows.Any())
            {
                throw new Exception("Nothing to add or update.");
            }

            using var cmd = new MySqlCommand(_mySqlConnection, null);
            string columns = "";
            string valueParameters = "";
            foreach (var db2Columns in db2Rows)
            {
                for (int i = 0; i < db2Columns.Count(); i++)
                {
                    columns += $"{db2Columns.ElementAt(i).Name},";
                    valueParameters += $"@{db2Columns.ElementAt(i).Name},";
                    cmd.Parameters.AddWithValue($"{db2Columns.ElementAt(i).Name}", GetValueWithDefault(db2Columns.ElementAt(i).Type, db2Columns.ElementAt(i).Value));
                }

                string query = $"REPLACE INTO {schemaName}.{tableName} ({columns.Remove(columns.Length - 1)}) VALUES({valueParameters.Remove(valueParameters.Length - 1)});";
                cmd.CommandText = query;
            }

            await _mySqlConnection.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            await _mySqlConnection.CloseAsync();
        }

        public async Task DeleteAsync<T>(string whereClause)
            where T : new()
        {
            await DeleteAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), whereClause);
        }

        public async Task DeleteAsync(string schemaName, string tableName, string whereClause)
        {
            ValidateInput(schemaName, tableName, whereClause);
            if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(whereClause))
                throw new Exception("Parameters can not be null.");

            var query = $"DELETE FROM {schemaName}.{tableName} WHERE {whereClause};";
            using var cmd = new MySqlCommand(query, _mySqlConnection);

            await _mySqlConnection.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            await _mySqlConnection.CloseAsync();
        }

        public async Task CreateTableIfNotExistAsync<T>()
            where T : new()
        {
            await CreateTableIfNotExistAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), ObjectTypeToDb2ColumnDefinitions<T>());
        }
        public async Task CreateTableIfNotExistAsync(string schemaName, string tableName, IEnumerable<Db2ColumnDefinition> definitions)
        {
            ValidateInput(schemaName, tableName);
            string columns = "";
            for (int i = 0; i < definitions.Count(); i++)
            {
                var fieldName = definitions.ElementAt(i).Name;
                var fieldType = definitions.ElementAt(i).Type.ToString() switch
                {
                    "System.SByte" => "tinyint signed",
                    "System.Int16" => "smallint signed",
                    "System.Int32" => "int signed",
                    "System.Int64" => "bigint signed",
                    "System.Byte" => "tinyint unsigned",
                    "System.UInt16" => "smallint unsigned",
                    "System.UInt32" => "int unsigned",
                    "System.UInt64" => "bigint unsigned",
                    "System.String" => "text",
                    "System.Decimal" => "float",
                    _ => throw new Exception($"{definitions.ElementAt(i).Type} not implemented.")
                };
                ValidateInput(fieldName);
                columns += $"{fieldName} {fieldType},";
            }

            string createSchemaQuery = $"CREATE SCHEMA IF NOT EXISTS {schemaName};";
            string createTableQuery = $"CREATE TABLE IF NOT EXISTS {schemaName}.{tableName} ({columns} primary key(ID, VerifiedBuild));";
            using var cmd = new MySqlCommand(createSchemaQuery + createTableQuery, _mySqlConnection);

            await _mySqlConnection.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            await _mySqlConnection.CloseAsync();
        }
        public async Task<bool> ConnectionExistsAsync()
        {
            try
            {
                await _mySqlConnection.OpenAsync();
                await _mySqlConnection.CloseAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> TableExistsAsync<T>()
            where T : new()
        {
            return await TableExistsAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>());
        }

        public async Task<bool> TableExistsAsync(string schemaName, string tableName)
        {
            ValidateInput(schemaName, tableName);
            await _mySqlConnection.OpenAsync();
            using var cmd = new MySqlCommand($"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{schemaName}' AND table_name = '{tableName}';", _mySqlConnection);
            var reader = await cmd.ExecuteReaderAsync();
            bool exists = false;
            while (reader.Read())
            {
                int count = reader.GetInt32(0);
                exists = count > 0;
            }
            await _mySqlConnection.CloseAsync();
            return exists;
        }


        public async Task<bool> SchemaExistsAsync<T>()
            where T : new()
        {
            return await SchemaExistsAsync(GetSchemaFromObject<T>());
        }
        public async Task<bool> SchemaExistsAsync(string schemaName)
        {
            ValidateInput(schemaName);
            await _mySqlConnection.OpenAsync();
            var schema = await _mySqlConnection.GetSchemaAsync(schemaName);
            await _mySqlConnection.CloseAsync();
            return schema != null;
        }

        public async Task<int> GetNextIdAsync(string schemaName, string tableName, int fromId)
        {
            ValidateInput(schemaName, tableName);
            string query = $"SELECT t1.ID + 1 AS FirstAvailableID FROM {schemaName}.{tableName} t1 ";
            query += $"LEFT JOIN {schemaName}.{tableName} t2 ON t2.ID = t1.ID + 1 ";
            query += $"WHERE t2.ID IS NULL ORDER BY t1.ID LIMIT 0, 1;";

            return -1;
        }

        public async Task<int> GetNextIdAsync<T>(int fromId) 
            where T : new()
        {
            return await GetNextIdAsync(GetSchemaFromObject<T>(), GetTableNameFromObject<T>(), fromId);
        }
    }
}
