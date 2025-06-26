using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteFactory
{
    public class LatamFactory : IReporteFinancieroFactory
    {
        public IHeaderFormatter CrearCabecera() => new CabeceraLatam();

        public IContentFormatter CrearContenido() => new ContenidoLatam();

        public IExporter CrearExportador() => new ExportadorLatam();
    }
}
