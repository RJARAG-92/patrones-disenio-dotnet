

using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Builders
{
    public interface IConfiguracionBuilder
    {
        void DefinirEntorno();
        void ConfigurarConexion();
        void ConfigurarLogs();
        void ConfigurarDebug();
        void ConfigurarTrazabilidad();
        ConfiguracionSistema ObtenerConfiguracion();
    }
}
