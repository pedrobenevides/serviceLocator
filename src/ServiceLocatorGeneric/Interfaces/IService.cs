namespace ServiceLocatorGeneric.Interfaces
{
    public interface IService
    {
        T GetService<T>();
    }
}
