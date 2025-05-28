// Program.cs - ConsoleRunner 
using PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales;

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
        FactoryMethodClient.Mostrar();
        break;
    default:
        Console.WriteLine("Saliendo...");
        break;
}
 
