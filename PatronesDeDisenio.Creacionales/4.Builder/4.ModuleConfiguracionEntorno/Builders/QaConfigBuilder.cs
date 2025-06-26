using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Builders
{
    public class QaConfigBuilder : IConfiguracionBuilder
    {
        private readonly ConfiguracionSistema _config = new();

        public void DefinirEntorno() => _config.NombreEntorno = "Qa";
        public void ConfigurarConexion() => _config.CadenaConexion = "Server=localhost;Database=qa_db;";
        public void ConfigurarLogs() => _config.RutaLogs = "/logs/qa/";
        public void ConfigurarDebug() => _config.ModoDebug = true;
        public void ConfigurarTrazabilidad() => _config.NivelTrazabilidad = "Detallado";

        public ConfiguracionSistema ObtenerConfiguracion() => _config;
    }
}
