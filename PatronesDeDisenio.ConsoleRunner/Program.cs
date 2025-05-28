// Program.cs - ConsoleRunner
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.ConcreteCreator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Creator; 
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteCreator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Creator; 

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
    Console.WriteLine("3. Generación de reporte");
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
        case "3":
            EjecutarEjemploReporte();
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
    Console.WriteLine("Seleccione tipo de Documento:");
    Console.WriteLine("1. Factura");
    Console.WriteLine("2. Contrato");
    Console.WriteLine("3. Memorando");
    Console.Write("Opción: ");

    var tipo = Console.ReadLine();
    Console.WriteLine();

    ValidadorDocumentoFactory factory = tipo switch
    {
        "1" => new FacturaFactory(),
        "2" => new ContratoFactory(),
        "3" => new MemorandoFactory(),
        _ => throw new InvalidOperationException("Tipo inválido")
    };

    var factoryValidate = factory.CrearValidador();
    factoryValidate.Validar("Documento empresarial de ejemplo");
}

void EjecutarEjemploReporte()
{
    Console.WriteLine("Seleccione formato de reporte:");
    Console.WriteLine("1. PDF");
    Console.WriteLine("2. Excel");
    Console.WriteLine("3. HTML");
    Console.Write("Opción: ");

    var tipo = Console.ReadLine();
    Console.WriteLine();

    ReporteFactory factory = tipo switch
    {
        "1" => new PdfFactory(),
        "2" => new ExcelFactory(),
        "3" => new HtmlFactory(),
        _ => throw new InvalidOperationException("Formato inválido")
    };

    var generador = factory.CrearGenerador();
    generador.Generar("Contenido de ejemplo para el reporte");
}
