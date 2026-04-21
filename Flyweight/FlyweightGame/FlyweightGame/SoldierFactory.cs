using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGame
{
    public class SoldierFactory
    {
        private Dictionary<string, SoldierType> _types = new();

        public SoldierType GetSoldierType(string type, string color, string animation)
        {
            string key = $"{type}_{color}";

            if (!_types.ContainsKey(key))
            {
                _types[key] = new SoldierType(type, color, animation);
            }

            return _types[key]; 
        }

        public int TotalTypes => _types.Count;
    }
}

