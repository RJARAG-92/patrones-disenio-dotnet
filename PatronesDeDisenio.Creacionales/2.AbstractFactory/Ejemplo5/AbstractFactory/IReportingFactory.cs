using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5
{
    public interface IReportingFactory
    {
        IReportBuilder CreateReportBuilder();
        IChartGenerator CreateChartGenerator();
        IExportService CreateExportService();
    }
}
