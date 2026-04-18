public class MusicApp {
    private IMediaPlayer mediaPlayer;

    public MusicApp(IMediaPlayer mediaPlayer) {
        this.mediaPlayer = mediaPlayer;
    }

    public void playMusic(String fileType, String fileName) {
        mediaPlayer.play(fileType, fileName);
    }
}