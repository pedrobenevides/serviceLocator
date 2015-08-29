using System;
using System.Collections.Generic;
using ServiceLocatorGeneric.Interfaces;
using ServiceLocatorGeneric.Services;

namespace ServiceLocatorGeneric
{
    public class ServiceLocator : IService
    {
        private readonly IDictionary<object, object> container;

        public ServiceLocator()
        {
            container = new Dictionary<object, object>
            {
                {typeof(IServiceA), new ServiceA()},
                {typeof(IServiceB), new ServiceB()}
            };
        }

        public T GetService<T>()
        {
            try
            {
                return (T)container[typeof(T)];
            }
            catch (Exception)
            {
                throw new NotImplementedException("Serviço não implementado.");
            }
        }
    }
}
