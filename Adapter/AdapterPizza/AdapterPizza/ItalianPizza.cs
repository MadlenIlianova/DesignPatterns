using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPizza
{
    public class ItalianPizza //Adaptee
    {
        public string MakeMargherita()
        {
            return "Маргарита: тънко тесто, доматен сос, моцарела";
        }

        public string MakePepperoni()
        {
            return "Пеперони: дебело тесто, пикантен сос, пеперони";
        }
    }
}
