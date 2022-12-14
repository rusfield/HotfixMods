using HotfixMods.Core.Providers;
using HotfixMods.Db2Provider.WowToolsFiles.Clients;
using HotfixMods.Infrastructure.Services;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace HotfixMods.Apps.Desktop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.VisibleStateDuration = 2000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
            });

            // TODO: Cleanup 
            IDb2Provider db2Provider = new Db2Client();
            //IMySqlProvider mySqlProvider = new MySqlClient("127.0.0.1","root","root","world","characters","hotfixes");
            IMySqlProvider mySqlProvider = new MySqlProvider.Debug.Clients.MySqlProvider();
            builder.Services.AddSingleton(config =>
            {
                return new ItemService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -1200,
                    IdSize = 10,
                    IdRangeFrom = 5000000,
                    IdRangeTo = 6000000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new CreatureService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -2000,
                    IdSize = 5000,
                    IdRangeFrom = 100000000,
                    IdRangeTo = 200000000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new SoundKitService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -800,
                    IdSize = 20,
                    IdRangeFrom = 1800000,
                    IdRangeTo = 1900000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new AnimKitService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -700,
                    IdSize = 50,
                    IdRangeFrom = 60000,
                    IdRangeTo = 70000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new GameObjectService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -900,
                    IdSize = 5, // TODO: Check
                    IdRangeFrom = 500000,
                    IdRangeTo = 550000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new SpellService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -1600,
                    IdSize = 50, 
                    IdRangeFrom = 2000000,
                    IdRangeTo = 3000000
                };
            });
            builder.Services.AddSingleton(config =>
            {
                return new SpellVisualKitService(db2Provider, mySqlProvider)
                {
                    VerifiedBuild = -1700,
                    IdSize = 5, // TODO: Check
                    IdRangeFrom = 300000,
                    IdRangeTo = 400000
                };
            });

            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddLogging(configure =>
            {
                configure.AddDebug();
            });

            return builder.Build();
        }
    }
}