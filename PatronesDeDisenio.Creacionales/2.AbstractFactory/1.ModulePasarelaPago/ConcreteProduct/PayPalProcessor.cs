using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.ConcreteProduct
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Procesando pago de {amount:C} con PayPal...");
            Console.WriteLine("Pago realizado exitosamente con PayPal.");
        }
    }
}
