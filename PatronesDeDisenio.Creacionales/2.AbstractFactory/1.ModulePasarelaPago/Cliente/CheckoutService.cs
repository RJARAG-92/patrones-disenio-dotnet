using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.Client
{
    public class CheckoutService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReceiptGenerator _receiptGenerator;

        public CheckoutService(IPaymentGatewayFactory factory)
        {
            _paymentProcessor = factory.CreatePaymentProcessor();
            _receiptGenerator = factory.CreateReceiptGenerator();
        }

        public void ProcesarPago(decimal monto, string transaccionId)
        {
            _paymentProcessor.ProcessPayment(monto);
            _receiptGenerator.GenerateReceipt(transaccionId);
        }
    }
}
