using DBCD.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Providers.Db2.WoWDev.Providers
{
    internal class DbcProvider : IDBCProvider
    {
        string _db2Path;
        public DbcProvider(string db2Path)
        {
            _db2Path = db2Path;
        }

        public Stream StreamForTableName(string? tableName = null, string? build = null)
        {
            if (File.Exists($"{_db2Path}"))
            {
                return File.Open(_db2Path, FileMode.Open);
            }
            else
            {
                throw new FileNotFoundException("Could not find " + tableName);
            }
        }
    }
}
