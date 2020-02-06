using SeventhServices.Client.Network.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;
using WebApiClient;
using WebApiClient.Extensions.DependencyInjection;

namespace SeventhServices.Client.Extensions.DependencyInjection
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddSeventhRequireHttpApi(this IServiceCollection services)
        {
            services.AddHttpApi<ISeventhApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(2d);
                config.FormatOptions.UseCamelCase = true;
                config.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            });
            services.AddHttpApi<ICheckUpdateApiClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                config.FormatOptions.UseCamelCase = true;
            });
            services.AddHttpApi<IAssetDownloadClient>().ConfigureHttpApiConfig(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
            return services;
        }
    }
}
