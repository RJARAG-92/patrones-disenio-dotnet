using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    internal class PdfExportService: IExportService
    {
        public void Export(string fileName) => Console.WriteLine($"[PDF] Reporte exportado como {fileName}.pdf");
    }
}
