using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Services;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.ConcreteCreator
{
    public class ContratoFactory : ValidadorDocumentoFactory
    {
        public override IValidadorDocumento CrearValidador()
        {
            return new ValidadorContrato();
        }
    }
}
