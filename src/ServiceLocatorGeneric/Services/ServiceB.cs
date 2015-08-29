using System;
using ServiceLocatorGeneric.Interfaces;

namespace ServiceLocatorGeneric.Services
{
    public class ServiceB : IServiceB
    {
        public void Execute()
        {
            Console.WriteLine("Executando o Serviço B");
        }
    }
}
