using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.interfaces
{
    public interface ILogisticsFactory
    {
        ITransport CreateTransport();
        IRoute CreateRoute();
        IDriver CreateDriver();
    }
}
