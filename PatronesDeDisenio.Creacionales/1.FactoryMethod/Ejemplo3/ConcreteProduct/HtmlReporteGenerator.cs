using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteProduct
{
    public class HtmlReporteGenerator : IReporteGenerator
    {
        public void Generar(string contenido)
        {
            Console.WriteLine($"[HTML] Generando reporte HTML con contenido: {contenido}");
        }
    }
}
