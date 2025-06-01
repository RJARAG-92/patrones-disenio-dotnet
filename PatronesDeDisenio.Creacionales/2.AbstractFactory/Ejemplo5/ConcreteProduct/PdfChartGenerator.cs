using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class PdfChartGenerator: IChartGenerator
    {
        public void GenerateChart(string chartType) => Console.WriteLine($"[PDF] Gráfico tipo {chartType} generado.");
    }
}
