using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class PdfReportBuilder : IReportBuilder
    {
        public void BuildHeader(string title) => Console.WriteLine($"[PDF] Encabezado: {title}");
        public void BuildBody(string content) => Console.WriteLine($"[PDF] Contenido: {content}");
        public void BuildFooter() => Console.WriteLine("[PDF] Pie de página agregado.");
    }
}
