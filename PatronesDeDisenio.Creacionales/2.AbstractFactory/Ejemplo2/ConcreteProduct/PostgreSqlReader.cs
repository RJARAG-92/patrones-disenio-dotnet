using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct
{
    public class PostgreSqlReader : IDbReader
    {
        public void Leer() => Console.WriteLine("Leyendo resultados desde PostgreSQL");
    }
}
