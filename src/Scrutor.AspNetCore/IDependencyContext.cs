using System;
using System.Collections.Generic;

namespace Scrutor.AspNetCore
{
    public interface IDependencyContext
    {
        IServiceProvider ServiceProvider { get; }
        T GetService<T>();
        IEnumerable<T> GetServices<T>();
        object GetService(Type type);
        IEnumerable<object> GetServices(Type type);
        T GetOrCreateService<T>();
        object GetOrCreateService(Type type);
    }
}