namespace DemoWebProjection.Contracts.Services
{
    internal interface ISetMarker<T>
    {
        Task SetMarker(T marker);
    }
}