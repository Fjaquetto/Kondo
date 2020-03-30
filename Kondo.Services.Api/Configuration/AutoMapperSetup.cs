using AutoMapper;
using Kondo.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kondo.Services.Api.Configuration
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(AutoMapperConfig));
        }
    }
}
