using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Business.Rules;
using Business.SecurityServices;

namespace TradingProject.Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<AuthBusinessRules>();

            services.AddScoped<IAuthsService, AuthsManager>();

            //    services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //    //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //    //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //    //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            //    services.AddScoped<IAuthService, AuthManager>();
            return services;

        }
    }
}
