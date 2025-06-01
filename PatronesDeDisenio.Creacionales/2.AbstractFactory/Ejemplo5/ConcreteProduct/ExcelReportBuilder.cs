using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class ExcelReportBuilder : IReportBuilder
    {
        public void BuildHeader(string title) => Console.WriteLine($"[Excel] Título: {title}");
        public void BuildBody(string content) => Console.WriteLine($"[Excel] Datos: {content}");
        public void BuildFooter() => Console.WriteLine("[Excel] Total agregado.");
    }
}
