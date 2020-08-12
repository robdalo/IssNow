using System;

namespace IssNow.Api.Domain.Models
{
    public class Location
    {
        public long timestamp { get; set; }
        public Position iss_position { get; set; }
        public string message { get; set; }
    }
}
