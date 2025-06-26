using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Services
{
    internal class ValidadorMemorando : IValidadorDocumento
    {
        public void Validar(string documento)
        {
            Console.WriteLine("[Memorando] Validando remitente, destinatario y asunto...");
        }
    }
} 
