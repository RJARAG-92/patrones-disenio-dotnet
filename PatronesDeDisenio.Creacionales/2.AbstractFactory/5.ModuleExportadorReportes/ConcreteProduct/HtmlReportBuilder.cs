using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class HtmlReportBuilder : IReportBuilder
    {
        public void BuildHeader(string title) => Console.WriteLine($"[HTML] <h1>{title}</h1>");
        public void BuildBody(string content) => Console.WriteLine($"[HTML] <p>{content}</p>");
        public void BuildFooter() => Console.WriteLine("[HTML] <footer>Reporte generado</footer>");
    }
}
