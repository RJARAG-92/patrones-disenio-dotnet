using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteFactory
{
    public class WindowsGuiFactory : IGuiFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextBox CreateTextBox() => new WindowsTextBox();
    }
}
