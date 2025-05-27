using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Services
{
    public class NotificacionSms : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("[DEBUG] Usando NotificacionSms");
            Console.WriteLine($"SMS enviado: {mensaje}");
        }
    }
}
