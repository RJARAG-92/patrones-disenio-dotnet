using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Renderizando botón estilo Windows.");
    }
}
