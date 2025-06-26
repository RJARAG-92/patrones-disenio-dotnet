using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Services
{
    public class NotificacionEmail : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("[DEBUG] Usando NotificacionEmail");
            Console.WriteLine($"Email enviado: {mensaje}");
        }
    }
}
