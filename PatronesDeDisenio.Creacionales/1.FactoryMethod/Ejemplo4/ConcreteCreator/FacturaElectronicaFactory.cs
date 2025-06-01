using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteProduct;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteCreator
{
    public class FacturaElectronicaFactory : ComprobanteFactory
    {
        public override IComprobanteElectronico CrearGenerador()
        {
            return new FacturaElectronica();
        }
    }
}
