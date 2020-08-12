using IssNow.Api.Core.Repos.Interfaces;
using NUnit.Framework;

namespace IssNow.Api.Core.Tests
{
    public class LocationRepoTests
    {
        private readonly ILocationRepo _locationRepo;

        public LocationRepoTests()
        {
            _locationRepo = new LocationRepo();
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
                location != null && location.message == "success"
            );
        }
    }
}
