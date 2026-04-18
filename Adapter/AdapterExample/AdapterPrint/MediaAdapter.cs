using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMusic
{
    public class MediaAdapter : IMediaPlayer //Adapter
    {
        private Mp3Player _mp3Player;

        public MediaAdapter()
        {
            _mp3Player = new Mp3Player();
        }

        public void Play(string fileType, string fileName)
        {
            if (fileType == "mp3") 
            {
            _mp3Player.PlayMp3(fileName);
            }
            else
            {
                Console.WriteLine($"File type {fileType} not supported.");
            }
        }
    }
}
