using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.Cliente
{
    public class ReportService
    {
        private readonly IReportBuilder _builder;
        private readonly IChartGenerator _chart;
        private readonly IExportService _exporter;
        public ReportService(IReportingFactory factory)
        {
            _builder = factory.CreateReportBuilder();
            _chart = factory.CreateChartGenerator();
            _exporter = factory.CreateExportService();
        }

        public void GenerarReporte(string titulo, string contenido, string grafico, string archivo)
        {
            _builder.BuildHeader(titulo);
            _builder.BuildBody(contenido);
            _builder.BuildFooter();
            _chart.GenerateChart(grafico);
            _exporter.Export(archivo);
        }
    }
}
