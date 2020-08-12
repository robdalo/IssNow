using IssNow.Api.SDK.Consumers.Interfaces;
using IssNow.Api.SDK.Models;

namespace IssNow.Api.SDK.Consumers
{
    public class ApiConsumer : IApiConsumer
    {
        private RestConsumer _restConsumer;
        
        private const string GetLocationEndpoint = "location";

        public ApiConsumer(string baseUrl)
        {
            _restConsumer = new RestConsumer(baseUrl);
        }

        public Location GetLocation()
        {
            var location = _restConsumer.Get<Location>(GetLocationEndpoint);

            return location;
        }
    }
}
