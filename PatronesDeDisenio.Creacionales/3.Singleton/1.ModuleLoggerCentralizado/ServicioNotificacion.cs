namespace PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado
{
    public class ServicioNotificacion
    {
        public void EnviarCorreo()
        {
            Logger.Instance.Log("Enviando correo de confirmación.");
        }
    }
}
