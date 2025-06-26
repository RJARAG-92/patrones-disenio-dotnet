using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Builders;

namespace PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Director
{
    public class ConfiguracionDirector
    {
        public void ConstruirConfiguracion(IConfiguracionBuilder builder)
        {
            builder.DefinirEntorno();
            builder.ConfigurarConexion();
            builder.ConfigurarLogs();
            builder.ConfigurarDebug();
            builder.ConfigurarTrazabilidad();
        }
    }
}
