using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebProjection.Contracts.Consumers
{
    public interface IConsumer<T>
    {
        Task Consume(string channel, T @event);
    }
}
