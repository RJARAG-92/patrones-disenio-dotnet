namespace PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new(() => new Logger());

        public static Logger Instance => _instance.Value;

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
        }
    }
}
