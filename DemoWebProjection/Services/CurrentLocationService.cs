using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoWebProjection.Contracts.Services;

namespace DemoWebProjection.Services
{
    internal class CurrentLocationService : ICurrentLocation
    {
        public async Task<Location> GetCurrentLocation(TimeSpan timeout, CancellationToken token)
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Best, timeout);
            var location = await Geolocation.GetLocationAsync(request, token);

            return location;
        }
    }
}
