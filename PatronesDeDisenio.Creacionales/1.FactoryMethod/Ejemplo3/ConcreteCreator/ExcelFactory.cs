using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteProduct;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteCreator
{
    public class ExcelFactory : ReporteFactory
    {
        public override IReporteGenerator CrearGenerador() => new ExcelReporteGenerator();
    }
}
