using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories
{
    public abstract class NotificacionFactory
    {
        public abstract INotificacion CrearNotificacion();

        public void EnviarConLog(string mensaje)
        {
            Console.WriteLine("[LOG] Preparando envío...");
            var notificacion = CrearNotificacion();
            notificacion.Enviar(mensaje);
            Console.WriteLine("[LOG] Envío completado.");
        }
    }
}
