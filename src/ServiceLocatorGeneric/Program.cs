using System;
using ServiceLocatorGeneric.Interfaces;

namespace ServiceLocatorGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceLocator = new ServiceLocator();
            
            var serviceA = serviceLocator.GetService<IServiceA>();
            var serviceB = serviceLocator.GetService<IServiceB>();

            serviceA.Execute();
            serviceB.Execute();

            Console.ReadKey();
        }
    }
}
