using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class CabeceraLatam : IHeaderFormatter
    {
        public void GenerarCabecera()
        {
            Console.WriteLine("Generando cabecera para Latinoamérica con moneda local y formato RUC.");
        }
    }
}
