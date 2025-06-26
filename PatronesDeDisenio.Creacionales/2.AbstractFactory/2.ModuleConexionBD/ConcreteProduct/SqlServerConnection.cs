using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct
{
    public class SqlServerConnection : IDbConnection
    {
        public void Conectar() => Console.WriteLine("Conectado a SQL Server");
    }
}
