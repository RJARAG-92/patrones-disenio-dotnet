using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class ExportadorAsia : IExporter
    {
        public void Exportar(string nombreArchivo)
        {
            Console.WriteLine($"Exportando reporte en formato fiscal japonés: {nombreArchivo}.dat");
        }
    }
}
