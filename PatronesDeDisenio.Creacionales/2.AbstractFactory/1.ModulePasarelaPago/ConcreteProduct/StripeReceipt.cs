using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.ConcreteProduct
{
    public class StripeReceipt : IReceiptGenerator
    {
        public void GenerateReceipt(string transactionId)
        {
            Console.WriteLine($"Generando recibo Stripe para transacción {transactionId}...");
        }
    }
}
