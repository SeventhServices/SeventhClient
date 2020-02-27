using System;
using Seventh.Client.Network.Interfaces;
using WebApiClient;

namespace Seventh.Client
{
    public static class HttpApiExtension
    {
        public static void RegisterSeventhClient()
        {
            HttpApi.Register<ISeventhApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(2d);
                config.FormatOptions.UseCamelCase = true;
            });
            HttpApi.Register<IAssetDownloadClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
            HttpApi.Register<ICheckUpdateApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                config.FormatOptions.UseCamelCase = true;
            });
        }
    }
}