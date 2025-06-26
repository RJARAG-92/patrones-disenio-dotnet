using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteProduct
{
    public class NotaCreditoElectronica : IComprobanteElectronico
    {
        public void Generar(string contenido)
        {
            Console.WriteLine($"[NotaCredito] Generando reporte NotaCredito con contenido: {contenido}");
        }
    }
}
