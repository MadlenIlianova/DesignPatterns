namespace AdapterMusic
{
    public class Program
    {
        static void Main(string[] args)
        {
            var adapter = new MediaAdapter();
            var musicApp = new MusicApp(adapter);
            musicApp.PlayMusic("mp3", "song.mp3");
            musicApp.PlayMusic("mp4", "video.mp4");
        }
    }
}
