﻿using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Creator
{
    public abstract class ValidadorDocumentoFactory
    {
        public abstract IValidadorDocumento CrearValidador();
    }
}
