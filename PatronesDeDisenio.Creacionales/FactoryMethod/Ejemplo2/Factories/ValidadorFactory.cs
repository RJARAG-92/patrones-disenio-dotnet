using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces; 

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Factories
{
    public abstract class ValidadorFactory
    {
        public abstract IValidadorDocumento CrearValidador();
    }
}
