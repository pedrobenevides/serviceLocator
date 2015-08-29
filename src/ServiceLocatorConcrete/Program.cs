 using System;
 using ServiceLocatorConcrete.Interfaces;
 using ServiceLocatorConcrete.Services;

namespace ServiceLocatorConcrete
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = ServiceLocator.SetLocation(new LoggingService());
            service.ExecuteService();

            Console.ReadKey();
        }
    }
}
