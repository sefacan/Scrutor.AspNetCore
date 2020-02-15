using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Scrutor.AspNetCore
{
    public class DependencyContext : IDependencyContext
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public DependencyContext(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }

        public IEnumerable<T> GetServices<T>()
        {
            return ServiceProvider.GetServices<T>();
        }

        public object GetService(Type type)
        {
            return ServiceProvider.GetService(type);
        }

        public IEnumerable<object> GetServices(Type type)
        {
            return ServiceProvider.GetServices(type);
        }

        public T GetOrCreateService<T>()
        {
            return ActivatorUtilities.GetServiceOrCreateInstance<T>(ServiceProvider);
        }

        public object GetOrCreateService(Type type)
        {
            return ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, type);
        }
    }
}