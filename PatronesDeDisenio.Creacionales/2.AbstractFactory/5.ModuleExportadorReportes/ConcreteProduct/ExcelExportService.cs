using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteProduct
{
    public class ExcelExportService : IExportService
    {
        public void Export(string fileName) => Console.WriteLine($"[Excel] Reporte exportado como {fileName}.xlsx");
    }
}
