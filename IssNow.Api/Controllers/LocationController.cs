using IssNow.Api.Core.Services.Interfaces;
using IssNow.Api.SDK.Models;
using IssNow.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace IssNow.Api.Controllers
{
    [ApiController]
    [Route("api/location")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public ActionResult<Location> Get()
        {
            var location = _locationService.GetCurrent();
            var locationMapped = LocationMapper.DomainToSDK(location);

            return locationMapped;
        }
    }
}
