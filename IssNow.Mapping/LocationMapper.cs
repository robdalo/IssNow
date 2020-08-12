namespace IssNow.Mapping
{
    public static class LocationMapper
    {
        public static Api.SDK.Models.Location DomainToSDK(Api.Domain.Models.Location location)
        {
            var locationMapped = new Api.SDK.Models.Location
            {
                Timestamp = location.timestamp,
                Longitude = location.iss_position.longitude,
                Latitude = location.iss_position.latitude
            };

            return locationMapped;
        }
    }
}
