using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder
{
    public class PdfReporteBuilder : IReporteBuilder
    {
        private readonly Reporte _reporte = new();

        public void ConstruirEncabezado() => _reporte.Encabezado = "Encabezado en formato PDF";
        public void ConstruirCuerpo() => _reporte.Cuerpo = "Contenido del reporte PDF";
        public void ConstruirGrafico() => _reporte.Grafico = "Gráfico tipo barras en PDF";
        public void ConstruirPie() => _reporte.Pie = "Pie de página en PDF";

        public Reporte ObtenerReporte() => _reporte;
    }
}
