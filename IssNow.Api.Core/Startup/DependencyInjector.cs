﻿using IssNow.Api.Core.Consumers;
using IssNow.Api.Core.Consumers.Interfaces;
using IssNow.Api.Core.Repos;
using IssNow.Api.Core.Repos.Interfaces;
using IssNow.Api.Core.Services;
using IssNow.Api.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IssNow.Api.Core.Startup
{
    public class DependencyInjector
    {
        private string _openNotifyApiBaseUrl;

        public DependencyInjector(string openNotifyApiBaseUrl)
        {
            _openNotifyApiBaseUrl = openNotifyApiBaseUrl;
        }

        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IOpenNotifyApiConsumer>(new OpenNotifyApiConsumer(_openNotifyApiBaseUrl));
            services.AddSingleton<ILocationRepo, LocationRepo>();
            services.AddSingleton<ILocationService, LocationService>();
        }
    }
}
