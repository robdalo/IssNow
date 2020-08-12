using IssNow.Api.Core.Consumers.OpenNotifyApi.Interfaces;
using IssNow.Api.Core.Models.OpenNotifyApi;
using IssNow.Api.SDK.Consumers;

namespace IssNow.Api.Core.Consumers.OpenNotifyApi
{
    public class ApiConsumer : IApiConsumer
    {
        private RestConsumer _restConsumer;
        
        private const string GetIssNowEndpoint = "iss-now.json";

        public ApiConsumer(string baseUrl)
        {
            _restConsumer = new RestConsumer(baseUrl);
        }

        public Location GetIssNow()
        {
            var location = _restConsumer.Get<Location>(GetIssNowEndpoint);

            return location;
        }
    }
}
