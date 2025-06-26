using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteFactory
{
    public class EuropaFactory : IReporteFinancieroFactory
    {
        public IHeaderFormatter CrearCabecera() => new CabeceraEuropa();

        public IContentFormatter CrearContenido() => new ContenidoEuropa();

        public IExporter CrearExportador()=> new ExportadorEuropa();
    }
}
