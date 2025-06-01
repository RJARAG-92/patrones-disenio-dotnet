using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractProduct;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.ConcreteProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.ConcreteFactory
{
    public class StripeFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();
        public IReceiptGenerator CreateReceiptGenerator() => new StripeReceipt();
    }
}
