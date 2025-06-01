using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class CabeceraEuropa : IHeaderFormatter
    {
        public void GenerarCabecera()
        {
            Console.WriteLine("Generando cabecera para Europa con moneda EUR, logo UE y estándar fiscal europeo.");
        }
    }
}
