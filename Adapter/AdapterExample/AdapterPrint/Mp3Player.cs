using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMusic
{
    public class Mp3Player // Adaptee
    {
        public void PlayMp3(string fileName)
        {
            Console.WriteLine($"Playing MP3 file: {fileName}");
        }
    }
}
