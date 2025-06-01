using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.Client
{
    public class ClienteDbConnector
    {
        private readonly IDbConnection _conexion;
        private readonly IDbCommand _comando;
        private readonly IDbReader _lector;

        public ClienteDbConnector(IDbFactory factory)
        {
            _conexion = factory.CrearConexion();
            _comando = factory.CrearComando();
            _lector = factory.CrearLector();
        }

        public void EjecutarConsulta(string query)
        {
            _conexion.Conectar();
            _comando.Ejecutar(query);
            _lector.Leer();
        }
    }
}
