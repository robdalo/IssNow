using IssNow.Api.Core.Consumers.Interfaces;
using IssNow.Api.Core.Repos.Interfaces;
using IssNow.Api.Domain.Models;

namespace IssNow.Api.Core.Repos
{
    public class LocationRepo : ILocationRepo
    {
        private readonly IOpenNotifyApiConsumer _apiConsumer;

        public LocationRepo(IOpenNotifyApiConsumer apiConsumer)
        {
            _apiConsumer = apiConsumer;
        }

        public Location GetCurrent()
        {
            return _apiConsumer.GetIssNow();
        }
    }
}
