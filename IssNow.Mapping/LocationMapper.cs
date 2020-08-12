namespace IssNow.Mapping
{
    public static class LocationMapper
    {
        public static Api.SDK.Models.Location DomainToSDK(Api.Domain.Models.Location location)
        {
            var locationMapped = new Api.SDK.Models.Location
            {
                Timestamp = location.Timestamp,
                Longitude = location.Longitude,
                Latitude = location.Latitude
            };

            return locationMapped;
        }
    }
}
