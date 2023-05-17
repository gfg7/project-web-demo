using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebProjection.Contracts.Consumers
{
    internal interface IProducer<T>
    {
        Task Publish(T @event);
    }
}
