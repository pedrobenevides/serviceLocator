using System;
using ServiceLocatorGeneric.Interfaces;

namespace ServiceLocatorGeneric.Services
{
    public class ServiceA : IServiceA
    {
        public void Execute()
        {
            Console.WriteLine("Executando o Serviço A");
        }
    }
}
