namespace PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado
{
    public class ServicioPago
    {
        public void ProcesarPago()
        {
            Logger.Instance.Log("Procesando pago con tarjeta.");
        }
    }
}
