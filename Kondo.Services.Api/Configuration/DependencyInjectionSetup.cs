﻿using Kondo.CC.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kondo.Services.Api.Configuration
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
