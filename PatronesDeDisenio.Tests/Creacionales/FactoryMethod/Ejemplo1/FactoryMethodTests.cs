using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Services;

public class FactoryMethodTests
{
    [Fact]
    public void EmailFactory_DeberiaCrearNotificacionEmail()
    {
        var factory = new EmailFactory();
        var notificacion = factory.CrearNotificacion();

        Assert.IsType<NotificacionEmail>(notificacion);
    }

    [Fact]
    public void SmsFactory_DeberiaCrearNotificacionSms()
    {
        var factory = new SmsFactory();
        var notificacion = factory.CrearNotificacion();

        Assert.IsType<NotificacionSms>(notificacion);
    }

    [Fact]
    public void EnviarConLog_DeberiaMostrarSalidaEsperada()
    {
        var factory = new EmailFactory();

        using var sw = new StringWriter();
        Console.SetOut(sw);

        factory.EnviarConLog("Mensaje de prueba");

        var output = sw.ToString();
        Assert.Contains("[LOG] Preparando envío...", output);
        Assert.Contains("[DEBUG] Usando NotificacionEmail", output);
        Assert.Contains("Email enviado: Mensaje de prueba", output);
        Assert.Contains("[LOG] Envío completado.", output);
    }
}
