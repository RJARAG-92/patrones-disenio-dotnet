using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Services
{
    public class ValidadorContrato : IValidadorDocumento
    {
        public void Validar(string documento)
        {
            Console.WriteLine("[Contrato] Validando fechas, firmas, términos legales...");
        }
    }
}
