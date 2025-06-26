using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Services
{
    public class ValidadorFactura : IValidadorDocumento
    {
        public void Validar(string documento)
        {
            Console.WriteLine("[Factura] Validando número, RUC y monto...");
        }
    }
}
