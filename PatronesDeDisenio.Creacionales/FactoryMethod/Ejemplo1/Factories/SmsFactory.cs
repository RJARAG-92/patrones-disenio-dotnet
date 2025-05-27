using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Interfaces;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Services;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories
{
    public class SmsFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion() => new NotificacionSms();
    }
} 