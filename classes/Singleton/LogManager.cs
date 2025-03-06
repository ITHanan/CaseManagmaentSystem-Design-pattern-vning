namespace CaseManagmaentSystem.classes.Singleton
{
    public class LogManager
    {
        private static LogManager _instance;
        private static readonly object _lock = new object();

        private LogManager() { }

        public static LogManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)

                        _instance = new LogManager();
                    return _instance;

                }
            }
        }
        public void log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");

        }
    }
}