using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteProduct
{
    public class FacturaElectronica : IComprobanteElectronico
    {
        public void Generar(string contenido)
        {
            Console.WriteLine($"[Factura] Generando reporte Factura con contenido: {contenido}");
        }
    }
}
