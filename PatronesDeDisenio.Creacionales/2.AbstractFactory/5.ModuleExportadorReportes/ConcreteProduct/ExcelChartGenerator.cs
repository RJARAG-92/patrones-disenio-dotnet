using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class ExcelChartGenerator : IChartGenerator
    {
        public void GenerateChart(string chartType) => Console.WriteLine($"[Excel] Gráfico tipo {chartType} generado.");
    }
}
