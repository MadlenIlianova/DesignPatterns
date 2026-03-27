using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRestaurant
{
    public class Waiter
    {
        private string name;

        public Waiter(string name)
        {
            this.name = name;
        }

        public void TakeOrder(string food)
        {
            Restaurant.GetInstance().AddOrder(name, food);
        }
    }
}
