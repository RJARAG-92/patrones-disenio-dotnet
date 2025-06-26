using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder;

namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Director
{
    public class ReporteDirector
    {
        public void ConstruirReporteCompleto(IReporteBuilder builder)
        {
            builder.ConstruirEncabezado();
            builder.ConstruirCuerpo();
            builder.ConstruirGrafico();
            builder.ConstruirPie();
        }
    }
}
