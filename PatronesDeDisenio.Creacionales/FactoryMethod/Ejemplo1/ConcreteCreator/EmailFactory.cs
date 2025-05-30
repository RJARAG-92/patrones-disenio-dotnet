﻿using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Interfaces;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Services;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories
{
    public class EmailFactory : NotificacionFactory
    {
        public override INotificacion CrearNotificacion() => new NotificacionEmail();
    }
}
