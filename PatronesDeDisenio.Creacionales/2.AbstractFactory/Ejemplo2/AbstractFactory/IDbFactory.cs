using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractFactory
{
    public interface IDbFactory
    {
        IDbConnection CrearConexion();
        IDbCommand CrearComando();
        IDbReader CrearLector();
    }
}
