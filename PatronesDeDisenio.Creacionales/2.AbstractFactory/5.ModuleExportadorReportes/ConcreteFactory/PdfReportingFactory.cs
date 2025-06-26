using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteFactory
{
    public class PdfReportingFactory : IReportingFactory
    {
        public IReportBuilder CreateReportBuilder() => new PdfReportBuilder();
        public IChartGenerator CreateChartGenerator() => new PdfChartGenerator();
        public IExportService CreateExportService() => new PdfExportService();
    }
}
