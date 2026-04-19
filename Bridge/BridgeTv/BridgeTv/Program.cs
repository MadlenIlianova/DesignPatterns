namespace BridgeTv
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обикновено дистанционно + Samsung");
            var samsung = new Samsung();
            var remote = new Remote(samsung);
            remote.Power();
            remote.VolumeUp();
            remote.Power();
            Console.WriteLine();

            Console.WriteLine("Разширено дистанционно + LG");
            var lg = new LG();
            var advancedRemote = new AdvancedRemote(lg);
            advancedRemote.Power();
            advancedRemote.VolumeUp();
            advancedRemote.Mute();
            advancedRemote.Power();
        }
    }
}
