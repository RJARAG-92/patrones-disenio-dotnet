using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteProduct
{
    public class ExcelReporteGenerator : IReporteGenerator
    {
        public void Generar(string contenido)
        {
            Console.WriteLine($"[EXCEL] Generando reporte Excel con contenido: {contenido}");
        }
    }
}
