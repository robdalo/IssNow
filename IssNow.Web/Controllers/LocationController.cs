using IssNow.Api.SDK.Consumers.Interfaces;
using IssNow.Api.SDK.Models;
using Microsoft.AspNetCore.Mvc;

namespace IssNow.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly IApiConsumer _apiConsumer;

        public LocationController(IApiConsumer apiConsumer)
        {
            _apiConsumer = apiConsumer;
        }

        [HttpGet]
        public Location Get()
        {
            return _apiConsumer.GetLocation();
        }
    }
}
