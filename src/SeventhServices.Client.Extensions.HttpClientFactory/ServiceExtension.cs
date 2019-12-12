﻿using System;
using Microsoft.Extensions.DependencyInjection;
using SeventhServices.Client.Network.Interfaces;
using WebApiClient;
using WebApiClient.Extensions.HttpClientFactory;

namespace SeventhServices.Client.Extensions.HttpClientFactory
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddSeventhRequireHttpFactoryApi(this IServiceCollection services)
        {
            services.AddHttpApiTypedClient<ISeventhApiClient>(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(2d);
                config.FormatOptions.UseCamelCase = true;
                config.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            });
            services.AddHttpApiTypedClient<ICheckUpdateApiClient>(config =>
            {
                config.FormatOptions.UseCamelCase = true;
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
            services.AddHttpApiTypedClient<IAssetDownloadClient>(config =>
            {
                config.HttpClient.Timeout = TimeSpan.FromMinutes(5d);
            });
            return services;
        }
    }
}
