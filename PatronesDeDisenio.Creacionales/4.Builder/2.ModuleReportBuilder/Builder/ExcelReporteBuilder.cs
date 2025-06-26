using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder
{
    public class ExcelReporteBuilder:IReporteBuilder
    {
        private readonly Reporte _reporte = new();

        public void ConstruirEncabezado() => _reporte.Encabezado = "Encabezado en formato Excel";
        public void ConstruirCuerpo() => _reporte.Cuerpo = "Contenido del reporte Excel";
        public void ConstruirGrafico() => _reporte.Grafico = "Gráfico tipo barras en Excel";
        public void ConstruirPie() => _reporte.Pie = "Pie de página en Excel";

        public Reporte ObtenerReporte() => _reporte;
    }
}
