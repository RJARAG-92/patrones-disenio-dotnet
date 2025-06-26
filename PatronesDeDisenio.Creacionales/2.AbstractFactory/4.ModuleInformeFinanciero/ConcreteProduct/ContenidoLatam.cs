using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class ContenidoLatam : IContentFormatter
    {
        public void GenerarContenido()
        {
            Console.WriteLine("Generando contenido contable con columnas: IGV, Percepción, Total a pagar.");
        }
    }

}
