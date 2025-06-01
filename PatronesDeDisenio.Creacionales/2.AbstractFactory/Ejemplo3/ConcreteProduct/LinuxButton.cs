using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct
{
    public class LinuxButton : IButton
    {
        public void Render() => Console.WriteLine("Renderizando botón estilo Linux.");
    }
}
