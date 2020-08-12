using IssNow.Api.Core.Consumers.OpenNotifyApi;
using IssNow.Api.Core.Consumers.OpenNotifyApi.Interfaces;
using IssNow.Api.Core.Repos;
using IssNow.Api.Core.Repos.Interfaces;
using NUnit.Framework;

namespace IssNow.Api.Core.Tests
{
    public class LocationRepoTests
    {
        private readonly ILocationRepo _locationRepo;
        private readonly IApiConsumer _apiConsumer;

        private const string BaseUrl = "http://api.open-notify.org";

        public LocationRepoTests()
        {
            _apiConsumer = new ApiConsumer(BaseUrl);
            _locationRepo = new LocationRepo(_apiConsumer);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCurrent_Success()
        {
            var location = _locationRepo.GetCurrent();

            Assert.True(
                location != null && location.Timestamp > 0
            );
        }
    }
}
