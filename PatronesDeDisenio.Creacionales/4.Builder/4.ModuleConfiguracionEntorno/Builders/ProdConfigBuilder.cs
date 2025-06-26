using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Builders
{
    public class ProdConfigBuilder : IConfiguracionBuilder
    {
        private readonly ConfiguracionSistema _config = new();

        public void DefinirEntorno() => _config.NombreEntorno = "Pro";
        public void ConfigurarConexion() => _config.CadenaConexion = "Server=localhost;Database=pro_db;";
        public void ConfigurarLogs() => _config.RutaLogs = "/logs/pro/";
        public void ConfigurarDebug() => _config.ModoDebug = false;
        public void ConfigurarTrazabilidad() => _config.NivelTrazabilidad = "Resumido";

        public ConfiguracionSistema ObtenerConfiguracion() => _config;
    }
}
