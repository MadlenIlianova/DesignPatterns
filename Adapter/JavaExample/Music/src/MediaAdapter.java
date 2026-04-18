public class MediaAdapter implements IMediaPlayer {
    private Mp3Player mp3Player;

    public MediaAdapter() {
        this.mp3Player = new Mp3Player();
    }

    @Override
    public void play(String fileType, String fileName) {
        if (fileType.equalsIgnoreCase("mp3")) {
            mp3Player.playMp3(fileName);
        } else {
            System.out.println("File type " + fileType + " not supported.");
        }
    }
}
