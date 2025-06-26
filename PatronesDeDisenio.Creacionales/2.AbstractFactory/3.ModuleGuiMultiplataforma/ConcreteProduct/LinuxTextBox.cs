using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteProduct
{
    public class LinuxTextBox : ITextBox
    {
        public void ShowText(string text) => Console.WriteLine($"Linux TextBox: {text}");
    }
}
