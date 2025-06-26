using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractFactory
{
    public interface IPaymentGatewayFactory
    {
        IPaymentProcessor CreatePaymentProcessor();
        IReceiptGenerator CreateReceiptGenerator();
    }
}
