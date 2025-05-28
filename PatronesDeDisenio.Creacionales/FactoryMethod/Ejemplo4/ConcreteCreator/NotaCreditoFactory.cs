using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteProduct;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteCreator
{
    public class NotaCreditoFactory : ComprobanteFactory
    {
        public override IComprobanteElectronico CrearGenerador()
        {
            return new NotaCreditoElectronica();
        }
    }
}
