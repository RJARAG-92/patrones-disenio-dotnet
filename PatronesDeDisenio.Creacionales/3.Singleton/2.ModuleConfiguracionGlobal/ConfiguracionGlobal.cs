namespace PatronesDeDisenio.Creacionales._3.Singleton._2.ModuleConfiguracionGlobal
{
    public sealed class ConfiguracionGlobal
    {
        private static readonly Lazy<ConfiguracionGlobal> _instance = new(() => new ConfiguracionGlobal());

        public static ConfiguracionGlobal Instance => _instance.Value;

        private ConfiguracionGlobal()
        {
            // Simulamos lectura de configuración al iniciar la app
            ConexionBD = "Server=sql-prod;Database=MainDB;";
            Entorno = "Producción";
            HabilitarLogs = true;
        }

        public string ConexionBD { get; private set; }
        public string Entorno { get; private set; }
        public bool HabilitarLogs { get; private set; }

        public void MostrarConfiguracion()
        {
            Console.WriteLine($"Entorno: {Entorno}");
            Console.WriteLine($"Cadena de conexión: {ConexionBD}");
            Console.WriteLine($"Logs habilitados: {HabilitarLogs}");
        }
    }
}
