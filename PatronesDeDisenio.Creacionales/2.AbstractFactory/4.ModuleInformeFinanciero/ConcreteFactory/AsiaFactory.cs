using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteFactory
{
    public class AsiaFactory : IReporteFinancieroFactory
    {
        public IHeaderFormatter CrearCabecera() => new CabeceraAsia();

        public IContentFormatter CrearContenido() => new ContenidoAsia();

        public IExporter CrearExportador() => new ExportadorAsia();
    }
}
