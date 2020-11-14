using Microsoft.Extensions.DependencyInjection;
using Seventh.Client.Network.Interfaces;
using System;
using WebApiClientCore;

namespace Seventh.Client
{
    public static class ServiceCollectionExtension
    {
        public static IHttpClientBuilder AddSeventhClientHttpApi(this IServiceCollection services, Action<HttpApiOptions> configAction = null)
        {
            return services.AddHttpApi<ISeventhApiClient>().ConfigureHttpApi(options =>
            {
                options.JsonSerializeOptions.PropertyNameCaseInsensitive = true;
                configAction?.Invoke(options);
            });
        }

        public static IHttpClientBuilder AddSeventhCheckUpdateHttpApi(this IServiceCollection services, Action<HttpApiOptions> configAction = null)
        {
            return services.AddHttpApi<ICheckUpdateApiClient>().ConfigureHttpApi(options =>
            {
                configAction?.Invoke(options);
            });
        }

        public static IHttpClientBuilder AddSeventhAssetDownloadHttpApi(this IServiceCollection services, Action<HttpApiOptions> configAction = null)
        {
            return services.AddHttpApi<IAssetDownloadClient>().ConfigureHttpApi(options =>
            {
                configAction?.Invoke(options);
            });
        }
    }
}
