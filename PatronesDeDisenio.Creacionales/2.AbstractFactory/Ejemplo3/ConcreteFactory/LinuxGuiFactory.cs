using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteFactory
{
    public class LinuxGuiFactory : IGuiFactory
    {
        public IButton CreateButton() => new LinuxButton();
        public ITextBox CreateTextBox() => new LinuxTextBox();
    }
}
