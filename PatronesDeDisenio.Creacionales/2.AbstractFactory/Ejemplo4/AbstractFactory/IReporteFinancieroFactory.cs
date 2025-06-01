using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory
{
    public interface IReporteFinancieroFactory
    {
        IHeaderFormatter CrearCabecera();
        IContentFormatter CrearContenido();
        IExporter CrearExportador();
    }
}
