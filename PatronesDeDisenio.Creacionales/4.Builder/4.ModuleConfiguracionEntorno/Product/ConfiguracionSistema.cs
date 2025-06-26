namespace PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Product
{
    public class ConfiguracionSistema
    {
        public string? NombreEntorno { get; set; }
        public string? CadenaConexion { get; set; }
        public string? RutaLogs { get; set; }
        public bool ModoDebug { get; set; }
        public string? NivelTrazabilidad { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Configuración del sistema:");
            Console.WriteLine($"Entorno:        {NombreEntorno}");
            Console.WriteLine($"Conexión DB:    {CadenaConexion}");
            Console.WriteLine($"Logs:           {RutaLogs}");
            Console.WriteLine($"Debug:          {ModoDebug}");
            Console.WriteLine($"Trazabilidad:   {NivelTrazabilidad}");
        }
    }
}
