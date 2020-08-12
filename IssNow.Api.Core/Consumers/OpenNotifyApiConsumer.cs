using IssNow.Api.Core.Consumers.Interfaces;
using IssNow.Api.Domain.Models;
using IssNow.Api.SDK.Consumers;

namespace IssNow.Api.Core.Consumers
{
    public class OpenNotifyApiConsumer : IOpenNotifyApiConsumer
    {
        private RestConsumer _restConsumer;
        
        private const string GetIssNowEndpoint = "iss-now.json";

        public OpenNotifyApiConsumer(string baseUrl)
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
