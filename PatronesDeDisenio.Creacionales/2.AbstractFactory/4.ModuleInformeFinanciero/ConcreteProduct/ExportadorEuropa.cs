using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class ExportadorEuropa : IExporter
    {
        public void Exportar(string nombreArchivo)
        {
            Console.WriteLine($"Exportando informe en formato PDF bajo normativa europea: {nombreArchivo}.pdf");
        }
    }
}
