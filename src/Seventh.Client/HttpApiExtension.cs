using System;
using Seventh.Client.Network.Interfaces;
using WebApiClient;

namespace Seventh.Client
{
    public static class HttpApiExtension
    {
        private static bool _isRegistered;
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
            _isRegistered = true;
        }

        public static void RegisterSeventhClient(Action<HttpApiConfig> configAction)
        {
            HttpApi.Register<ISeventhApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(2d);
                config.FormatOptions.UseCamelCase = true;
                configAction(config);
            });
            HttpApi.Register<IAssetDownloadClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                configAction(config);
            });
            HttpApi.Register<ICheckUpdateApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                config.FormatOptions.UseCamelCase = true;
                configAction(config);
            });
            _isRegistered = true;
        }

        public static ISeventhApiClient GetSeventhApiClient()
        {
            if (_isRegistered)
            {
                return HttpApi.Resolve<ISeventhApiClient>();
            }

            RegisterSeventhClient();
            return HttpApi.Resolve<ISeventhApiClient>();
        }
    }
}