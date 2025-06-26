using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder
{
    public interface IReporteBuilder
    {
        void ConstruirEncabezado();
        void ConstruirCuerpo();
        void ConstruirGrafico();
        void ConstruirPie();
        Reporte ObtenerReporte();
    }
}
