using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteFactory
{
    public class SqlServerFactory : IDbFactory
    {
        public IDbConnection CrearConexion() => new SqlServerConnection();
        public IDbCommand CrearComando() => new SqlServerCommand();
        public IDbReader CrearLector() => new SqlServerReader();
    }
}
