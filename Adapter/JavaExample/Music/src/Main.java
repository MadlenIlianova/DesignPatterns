void main() {
    IMediaPlayer adapter = new MediaAdapter();
    MusicApp app = new MusicApp(adapter);
    app.playMusic("mp3", "song_of_the_summer.mp3");
    app.playMusic("mp4", "movie.avi");
}

