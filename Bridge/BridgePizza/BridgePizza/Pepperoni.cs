using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePizza
{
    public class Pepperoni : Pizza
    {
        public Pepperoni(ICookingMethod cookingMethod) : base(cookingMethod)
        {
        }

        public override string Prepare()
        {
            return _cookingMethod.Cook("Пеперони");
        }
    }
}
