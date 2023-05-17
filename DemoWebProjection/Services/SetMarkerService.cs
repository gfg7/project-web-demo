using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoWebProjection.Contracts.Services;

namespace DemoWebProjection.Services
{
    internal class SetMarkerService<T> : ISetMarker<T>
    {
        public Task SetMarker(T marker)
        {
            throw new NotImplementedException();
        }
    }
}
