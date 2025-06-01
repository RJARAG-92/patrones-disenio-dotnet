using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.Cliente
{
    public class ServicioReporteFinanciero
    {
        private readonly IHeaderFormatter _cabecera;
        private readonly IContentFormatter _contenido;
        private readonly IExporter _exportador;

        public ServicioReporteFinanciero(IReporteFinancieroFactory factory)
        {
            _cabecera = factory.CrearCabecera();
            _contenido = factory.CrearContenido();
            _exportador = factory.CrearExportador();
        }

        public void GenerarReporte(string nombreArchivo)
        {
            _cabecera.GenerarCabecera();
            _contenido.GenerarContenido();
            _exportador.Exportar(nombreArchivo);
        }
    }
}
