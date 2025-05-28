using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Creator
{
    public abstract class ComprobanteFactory
    {
        public abstract IComprobanteElectronico CrearGenerador();
    }
}
