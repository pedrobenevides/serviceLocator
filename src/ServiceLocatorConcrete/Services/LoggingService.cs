 using System;
 using ServiceLocatorConcrete.Interfaces;

namespace ServiceLocatorConcrete.Services
{
    public class LoggingService : IService
    {
        public void ExecuteService()
        {
            Console.WriteLine("Executando Log Service da classe Logging Service");
        }
    }
}
