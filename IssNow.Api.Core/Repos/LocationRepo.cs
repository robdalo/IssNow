using IssNow.Api.Core.Consumers.OpenNotifyApi.Interfaces;
using IssNow.Api.Core.Repos.Interfaces;
using IssNow.Api.Domain.Models;

namespace IssNow.Api.Core.Repos
{
    public class LocationRepo : ILocationRepo
    {
        private readonly IApiConsumer _apiConsumer;

        public LocationRepo(IApiConsumer apiConsumer)
        {
            _apiConsumer = apiConsumer;
        }

        public Location GetCurrent()
        {
            var location = _apiConsumer.GetIssNow();
            var locationMapped = new Location
            {
                Timestamp = location.timestamp,
                Longitude = location.iss_position.longitude,
                Latitude = location.iss_position.latitude
            };

            return locationMapped;
        }
    }
}
