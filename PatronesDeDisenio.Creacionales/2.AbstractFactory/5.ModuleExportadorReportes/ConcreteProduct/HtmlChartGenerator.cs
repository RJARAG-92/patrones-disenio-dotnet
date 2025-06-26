using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class HtmlChartGenerator : IChartGenerator
    {
        public void GenerateChart(string chartType) => Console.WriteLine($"[HTML] <canvas>Gráfico tipo {chartType}</canvas>");
    }
}
