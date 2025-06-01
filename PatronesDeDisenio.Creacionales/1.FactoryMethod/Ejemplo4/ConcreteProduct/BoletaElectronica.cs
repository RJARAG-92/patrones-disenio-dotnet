using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Product; 

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteProduct
{
    public class BoletaElectronica : IComprobanteElectronico
    {
        public  void Generar(string contenido)
        {
            Console.WriteLine($"[Boleta] Generando reporte Boleta con contenido: {contenido}");
        }
    }
}
