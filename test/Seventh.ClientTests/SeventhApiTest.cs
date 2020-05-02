using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Seventh.Client.Common.Enums;
using Seventh.Client.Common.Params;
using Seventh.Client.Extensions.HttpClientFactory;
using Seventh.Client.Network.Interfaces;
using Seventh.Client.Network.Models.Extensions;
using Seventh.Client.Network.Models.Request;
using Seventh.Client.Network.Models.Request.Event;
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
            RequestParams.Rev = 414;
            RequestParams.Version = "6.10.4";
        }

        private readonly ISeventhApiClient _apiClient;

        [Fact]
        public async Task ShouldInspection()
        {
            //var result =
            //    await _apiClient.Login(new LoginRequest());
            var result = await _apiClient.Inspection(new InspectionRequest());
            Assert.True(result != null);
        }
    }
}
