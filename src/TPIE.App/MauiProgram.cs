﻿using Microsoft.Extensions.Logging;
using TPIE.Data;

namespace TPIE.App
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

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
            //builder.Logging.AddDebug();
#endif

            builder.Services.SetupTPIE();

            return builder.Build();
        }
    }
}