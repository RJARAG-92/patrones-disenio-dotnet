using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct
{
    public class WindowsTextBox : ITextBox
    {
        public void ShowText(string text) => Console.WriteLine($"Windows TextBox: {text}");
    }
}
