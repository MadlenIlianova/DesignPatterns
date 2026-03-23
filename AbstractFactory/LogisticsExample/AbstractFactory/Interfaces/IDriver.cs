using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.interfaces
{
    public interface IDriver
    {
        string Drive();
        string Name { get; }
    }
}
