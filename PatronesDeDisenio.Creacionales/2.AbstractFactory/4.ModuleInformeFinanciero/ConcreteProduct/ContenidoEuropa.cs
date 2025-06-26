using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class ContenidoEuropa : IContentFormatter
    {
        public void GenerarContenido()
        {
            Console.WriteLine("Generando contenido contable con columnas: IVA, Retención, Neto.");
        }
    }
}
