namespace DesignPatternsCourseWork.Logger
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
        void LogSuccess(string message);
    }
}
