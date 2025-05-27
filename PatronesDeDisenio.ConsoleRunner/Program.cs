using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories;

Console.WriteLine("=== PATRONES DE DISEÑO EN .NET ===");
Console.WriteLine("Seleccione un patrón:");
Console.WriteLine("1. Factory Method");
Console.WriteLine("2. Salir");
Console.Write("Opción: ");

var opcion = Console.ReadLine();
Console.WriteLine();

switch (opcion)
{
    case "1":
        EjecutarFactoryMethod();
        break;
    default:
        Console.WriteLine("Saliendo...");
        break;
}

void EjecutarFactoryMethod()
{
    Console.WriteLine("=== FACTORY METHOD ===");
    Console.WriteLine("Seleccione tipo de notificación:");
    Console.WriteLine("1. Email");
    Console.WriteLine("2. SMS");
    Console.Write("Opción: ");

    var tipo = Console.ReadLine();
    Console.WriteLine();

    NotificacionFactory factory = tipo switch
    {
        "1" => new EmailFactory(),
        "2" => new SmsFactory(),
        _ => throw new InvalidOperationException("Opción inválida")
    };

    factory.EnviarConLog("Hola desde la consola con Factory Method");
}