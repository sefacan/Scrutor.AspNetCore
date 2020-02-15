using Scrutor.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAdvancedDependencyInjection(this IApplicationBuilder app)
        {
            var dependencyContext = app.ApplicationServices.GetService<IDependencyContext>();
            ServiceLocator.Initialize(dependencyContext);

            return app;
        }
    }
}