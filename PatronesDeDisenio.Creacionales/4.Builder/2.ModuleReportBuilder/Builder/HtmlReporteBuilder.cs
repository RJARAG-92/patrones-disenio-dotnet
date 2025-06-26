using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder
{
    public class HtmlReporteBuilder : IReporteBuilder
    {
        private readonly Reporte _reporte = new();

        public void ConstruirEncabezado() => _reporte.Encabezado = "Encabezado en formato Html";
        public void ConstruirCuerpo() => _reporte.Cuerpo = "Contenido del reporte Html";
        public void ConstruirGrafico() => _reporte.Grafico = "Gráfico tipo barras en Html";
        public void ConstruirPie() => _reporte.Pie = "Pie de página en Html";

        public Reporte ObtenerReporte() => _reporte;
    }
}
