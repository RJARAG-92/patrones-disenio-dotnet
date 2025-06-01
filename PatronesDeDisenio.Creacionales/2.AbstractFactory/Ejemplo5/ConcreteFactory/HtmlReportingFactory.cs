using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteFactory
{
    public class HtmlReportingFactory : IReportingFactory
    {
        public IReportBuilder CreateReportBuilder() => new HtmlReportBuilder();
        public IChartGenerator CreateChartGenerator() => new HtmlChartGenerator();
        public IExportService CreateExportService() => new HtmlExportService();
    }
}
