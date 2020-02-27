using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Seventh.Client.Common.Params;
using Seventh.Client.Extensions.HttpClientFactory;
using Seventh.Client.Network.Interfaces;
using Seventh.Client.Network.Models.Request.Setup;
using Xunit;

namespace Seventh.ClientTests
{
    public class SeventhApiTest
    {
        public SeventhApiTest()
        {
            var services = new ServiceCollection()
                .AddSeventhRequireHttpFactoryApi()
                .BuildServiceProvider();
            _apiClient = services.GetService<ISeventhApiClient>();
            RequestParams.Rev = 391;
            RequestParams.Version = "6.10.2";
            RequestParams.Pid = "3122229";
            RequestParams.Uuid = "0885b85d-7f6e-44cf-8956-8a1af567a86c";
        }

        private readonly ISeventhApiClient _apiClient;

        [Fact]
        public async Task ShouldGetModify()
        {
            var result = await _apiClient.ResourceResult(new ResourceResultRequest(RequestParams.Rev));
            Assert.True(result.UpdateResource != null || result.Error != null);
        }
    }
}
