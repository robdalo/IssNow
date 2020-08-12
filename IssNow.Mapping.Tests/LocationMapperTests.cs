using IssNow.Api.Domain.Models;
using NUnit.Framework;

namespace IssNow.Mapping.Tests
{
    public class LocationMapperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenMappingLocation_MappingIsValid()
        {
            var location = new Location
            {
                Timestamp = 1597260818,
                Longitude = 1.7712m,
                Latitude = -10.7872m
            };

            var locationMapped = LocationMapper.DomainToSDK(location);

            Assert.True(
                locationMapped.Timestamp == location.Timestamp &&
                locationMapped.Longitude == location.Longitude &&
                locationMapped.Latitude == location.Latitude
            );
        }
    }
}
