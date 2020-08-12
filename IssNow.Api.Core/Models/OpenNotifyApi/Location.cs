namespace IssNow.Api.Core.Models.OpenNotifyApi
{
    public class Location
    {
        public long timestamp { get; set; }
        public Position iss_position { get; set; }
        public string message { get; set; }
    }
}
