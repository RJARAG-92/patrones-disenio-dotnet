using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct
{
    internal class SqlServerReader : IDbReader
    {
        public void Leer() => Console.WriteLine("Leyendo resultados desde SQL Server");
    }
}
