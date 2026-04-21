using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightWord
{
    public class CharacterStyle
    {
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public CharacterStyle(string fontName, int fontSize)
        {
            FontName = fontName;
            FontSize = fontSize;
            Console.WriteLine($"Creating type:{fontName},{fontSize}px");
        }

        public void Display(string character, int position)
        {
            Console.WriteLine($"Character: '{character}' on position {position} with style: {FontName}, {FontSize}px");
        }
    }
}
