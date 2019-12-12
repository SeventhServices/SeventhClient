using System;
using System.ComponentModel;
using SeventhServices.Client.Network.Interfaces;
using WebApiClient;

namespace SeventhServices.Client.Network.Services
{
    public static class HttpApiRegiste
    {

        public static void Registe()
        {
            HttpApi.Register<ISeventhApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(2d);

                config.FormatOptions.UseCamelCase = true;
                config.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;

            });
            HttpApi.Register<IAssetDownloadClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
            HttpApi.Register<ICheckUpdateApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
        }

    }
}