using Kondo.CC.Identity.Authorization;
using Kondo.CC.Identity.Models;
using Kondo.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Kondo.CC.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application

            // Infra - Data

            // Infra - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
