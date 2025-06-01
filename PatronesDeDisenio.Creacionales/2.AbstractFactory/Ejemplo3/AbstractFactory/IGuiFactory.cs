using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
