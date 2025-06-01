using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.Cliente
{
    public class ClienteGUI
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;

        public ClienteGUI(IGuiFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
        }

        public void RenderUI()
        {
            _button.Render();
            _textBox.ShowText("Bienvenido a la app multiplataforma");
        }
    }
}
