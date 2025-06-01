using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractProduct; 

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteProduct
{
    public class SqlServerCommand : IDbCommand
    {
        public void Ejecutar(string query) => Console.WriteLine($"Ejecutando en SQL Server: {query}");
    }
}
