﻿using IssNow.Api.Domain.Models;
using IssNow.Api.Core.Repos.Interfaces;
using IssNow.Api.Core.Services.Interfaces;

namespace IssNow.Api.Core.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepo _locationRepo;

        public LocationService(ILocationRepo locationRepo)
        {
            _locationRepo = locationRepo;
        }

        public Location GetCurrent()
        {
            return _locationRepo.GetCurrent();
        }
    }
}
