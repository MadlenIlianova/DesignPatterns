namespace DesignPatternsCourseWork.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Thread.Sleep(500);
            Console.WriteLine($"[INFO]   {message}");
        }

        public void LogError(string message)
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR]   {message}");
            Console.ResetColor();
        }

        public void LogSuccess(string message)
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SUCCESS]   {message}");
            Console.ResetColor();
        }
    }
}
