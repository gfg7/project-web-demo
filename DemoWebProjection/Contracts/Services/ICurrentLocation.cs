namespace DemoWebProjection.Contracts.Services
{
    internal interface ICurrentLocation
    {
        Task<Location> GetCurrentLocation(TimeSpan timeout, CancellationToken token);
    }
}