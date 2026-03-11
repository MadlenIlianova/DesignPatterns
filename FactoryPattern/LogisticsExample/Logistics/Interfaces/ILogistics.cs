using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Interfaces
{
    public interface ILogistics
    {
        public abstract ITransport CreateTransport();
        public void PlanDelivery();
    }
}
