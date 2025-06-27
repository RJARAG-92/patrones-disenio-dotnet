using PatronesDeDisenio.Creacionales._5.Prototype._4.ModuleConfiguracionAmbiente.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._4.ModuleConfiguracionAmbiente.Prototypes
{
    public class ConfiguracionSistema : IConfiguracionPrototype
    {
        public string NombreAmbiente { get; set; } = "Desarrollo";
        public string UrlBase { get; set; } = "https://dev.api.empresa.com";
        public bool ActivarDebug { get; set; } = true;
        public List<string> ModulosActivos { get; set; } = new() { "Login", "Dashboard" };

        public IConfiguracionPrototype Clonar()
        {
            var copia = (ConfiguracionSistema)this.MemberwiseClone();
            copia.ModulosActivos = new List<string>(ModulosActivos); // evitar referencias compartidas
            return copia;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Ambiente: {NombreAmbiente}");
            Console.WriteLine($"URL: {UrlBase}");
            Console.WriteLine($"Debug: {(ActivarDebug ? "Sí" : "No")}");
            Console.WriteLine($"Módulos: {string.Join(", ", ModulosActivos)}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
