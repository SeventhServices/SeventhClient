using System;
using Microsoft.Extensions.DependencyInjection;
using Seventh.Client.Network.Interfaces;
using WebApiClient;
using WebApiClient.Extensions.DependencyInjection;

namespace Seventh.Client.Extensions.DependencyInjection
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

        public static IServiceCollection AddSeventhRequireHttpApi(this IServiceCollection services, Action<HttpApiConfig> configAction)
        {
            services.AddHttpApi<ISeventhApiClient>().ConfigureHttpApiConfig(c =>
            {
                c.HttpClient.Timeout = TimeSpan.FromMinutes(2d);
                c.FormatOptions.UseCamelCase = true;
                c.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
                configAction(c);
            });
            services.AddHttpApi<ICheckUpdateApiClient>().ConfigureHttpApiConfig(c =>
            {
                c.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                c.FormatOptions.UseCamelCase = true;
                configAction(c);
            });
            services.AddHttpApi<IAssetDownloadClient>().ConfigureHttpApiConfig(c =>
            {
                c.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
                configAction(c);
            });
            return services;
        }
    }
}
