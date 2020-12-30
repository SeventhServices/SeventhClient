using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Seventh.Client;
using Seventh.Client.Common.Enums;
using Seventh.Client.Network.Interfaces;
using Seventh.Client.Network.Models.Request;
using Seventh.Client.Network.Models.Request.Setup;
using Seventh.Client.Options;
using Xunit;

namespace Seventh.ClientTests
{
    public class SeventhApiTest
    {
        public SeventhApiTest()
        {
            var services = new ServiceCollection();
            services.AddSeventhClientHttpApi();
            var servicesProvider = services.BuildServiceProvider();

            _apiClient = servicesProvider.GetService<ISeventhApiClient>();

            DefaultOptions.ParamOptions.Pid = "3122229";
            DefaultOptions.ParamOptions.Uuid = "0885b85d-7f6e-44cf-8956-8a1af567a86c";
        }

        private readonly ISeventhApiClient _apiClient;

        [Fact]
        public async Task ShouldInspection()
        {
            var result = await _apiClient.Inspection(new InspectionRequest());
            Assert.True(result != null);
        }

        [Fact]
        public async Task ShouldResourceResult()
        {
            DefaultOptions.ParamOptions.Version = "7.7.7";
            var result = await _apiClient.ResourceResult(new ResourceResultRequest(474, DownloadType.Difference));
            Assert.True(result != null);
        }
    }
}
