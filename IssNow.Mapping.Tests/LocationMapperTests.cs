using IssNow.Api.Domain;
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
                timestamp = 1597260818,
                message = "success",
                iss_position = new Position
                {
                    longitude = 1.7712m,
                    latitude = -10.7872m
                }
            };

            var locationMapped = LocationMapper.DomainToSDK(location);

            Assert.True(
                locationMapped.Timestamp == location.timestamp &&
                locationMapped.Longitude == location.iss_position.longitude &&
                locationMapped.Latitude == location.iss_position.latitude
            );
        }
    }
}
