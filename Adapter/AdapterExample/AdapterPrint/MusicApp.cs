using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMusic
{
    public class MusicApp // Client
    {
        private IMediaPlayer _mediaPlayer;

        public MusicApp(IMediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        public void PlayMusic(string fileType, string fileName)
        {
            _mediaPlayer.Play(fileType, fileName);
        }
    }
}
