// Program.cs - ConsoleRunner
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Factories; 

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
        MostrarMenuFactoryMethod();
        break;
    default:
        Console.WriteLine("Saliendo...");
        break;
}

void MostrarMenuFactoryMethod()
{
    Console.WriteLine("=== FACTORY METHOD ===");
    Console.WriteLine("Seleccione ejemplo:");
    Console.WriteLine("1. Notificación por tipo (Email/SMS)");
    Console.WriteLine("2. Validación de documento empresarial");
    Console.Write("Opción: ");

    var ejemplo = Console.ReadLine();
    Console.WriteLine();

    switch (ejemplo)
    {
        case "1":
            EjecutarEjemploNotificacion();
            break;
        case "2":
            EjecutarEjemploValidacion();
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
}

void EjecutarEjemploNotificacion()
{
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
        _ => throw new InvalidOperationException("Tipo inválido")
    };

    factory.EnviarConLog("Mensaje de prueba usando Factory Method - Ejemplo 1");
}

void EjecutarEjemploValidacion()
{
    Console.WriteLine("Ingrese tipo de documento (Factura, Contrato, Memorando):");
    var tipo = Console.ReadLine();
    Console.WriteLine();

    var validador = ValidadorFactoryConcreto.ObtenerValidador(tipo!);
    validador.Validar("Documento empresarial de ejemplo");
}
