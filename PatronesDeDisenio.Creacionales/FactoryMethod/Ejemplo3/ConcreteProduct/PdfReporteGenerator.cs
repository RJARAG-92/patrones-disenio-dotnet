using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteProduct
{
    public class PdfReporteGenerator : IReporteGenerator
    {
        public void Generar(string contenido)
        {
            Console.WriteLine($"[PDF] Generando reporte PDF con contenido: {contenido}");
        }
    }
}
