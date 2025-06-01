using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteFactory
{
    public class ExcelReportingFactory : IReportingFactory
    {
        public IReportBuilder CreateReportBuilder() => new ExcelReportBuilder();
        public IChartGenerator CreateChartGenerator() => new ExcelChartGenerator();
        public IExportService CreateExportService() => new ExcelExportService();
    }
}
