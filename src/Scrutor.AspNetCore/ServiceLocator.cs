using System;

namespace Scrutor.AspNetCore
{
    public class ServiceLocator
    {
        private static IDependencyContext _dependencyContext;

        public static IDependencyContext Context => _dependencyContext ?? throw new Exception("You should initialize the context before using it.");

        public static void Initialize(IDependencyContext dependencyContext)
        {
            _dependencyContext = dependencyContext;
        }
    }
}