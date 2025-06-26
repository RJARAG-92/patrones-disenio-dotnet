using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class HtmlExportService : IExportService
    {
        public void Export(string fileName) => Console.WriteLine($"[HTML] Reporte exportado como {fileName}.html");
    }
}
