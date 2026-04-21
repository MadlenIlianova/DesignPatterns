using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightWord
{
    public class Character
    {
        private CharacterStyle _style;
        private char _symbol;
        private int _position;

        public Character(char symbol, int position, CharacterStyle style)
        {
            _symbol = symbol;
            _position = position;
            _style = style;
        }

        public void Display()
        {
            _style.Display(_symbol.ToString(), _position);
        }
    }
}
