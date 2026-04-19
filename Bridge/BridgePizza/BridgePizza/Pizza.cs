
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePizza
{
    public abstract class Pizza
    {
        protected ICookingMethod _cookingMethod;

        public Pizza(ICookingMethod cookingMethod)
        {
            this._cookingMethod = cookingMethod;
        }

        public abstract string Prepare();
    }
}
