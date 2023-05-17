using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebProjection.Configuration
{
    internal static class ServicesConfiguration
    {
        public static MauiAppBuilder RedisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            return mauiAppBuilder;
        }
    }
}
