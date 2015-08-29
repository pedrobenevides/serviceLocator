using ServiceLocatorConcrete.Interfaces;
using ServiceLocatorConcrete.Services;

namespace ServiceLocatorConcrete
{
    public static class ServiceLocator
    {
        public static IService ObjService;

        public static IService SetLocation(IService service)
        {
            return ObjService ?? new LoggingService();
        }

        public static void ExecuteService()
        {
            ObjService.ExecuteService();
        }
    }
}
