using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightWord
{
    public class StyleFactory
    {
        private Dictionary<string, CharacterStyle> _styles = new Dictionary<string, CharacterStyle>();

        public CharacterStyle GetCharacterStyle(string fontName, int fontSize, string color)
        {
            string key = $"{fontName}_{fontSize}_{color}";

            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new CharacterStyle(fontName, fontSize);
            }

            return _styles[key];
        }

        public int TotalStyles => _styles.Count;
    }
}
