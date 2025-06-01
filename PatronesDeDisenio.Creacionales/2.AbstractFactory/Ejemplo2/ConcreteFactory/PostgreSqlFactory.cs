using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteFactory
{
    public class PostgreSqlFactory : IDbFactory
    {
        public IDbConnection CrearConexion() => new PostgreSqlConnection();
        public IDbCommand CrearComando() => new PostgreSqlCommand();
        public IDbReader CrearLector() => new PostgreSqlReader();
    }

}
