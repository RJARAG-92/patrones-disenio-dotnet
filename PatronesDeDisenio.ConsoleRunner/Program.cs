// Program.cs - ConsoleRunner 
using PatronesDeDisenio.ConsoleRunner._1.PatronesDeDisenio.Creacionales;
using PatronesDeDisenio.ConsoleRunner._2.PatronesDeDisenio.Estructurales;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== PATRONES DE DISEÑO EN .NET ===");
    Console.WriteLine("Seleccione una categoría:");
    Console.WriteLine("1. Creacionales");
    Console.WriteLine("2. Estructurales");
    Console.WriteLine("3. Comportamiento");
    Console.WriteLine("0. Salir");
    Console.WriteLine();
    Console.Write("Opción: ");

    var opcion = Console.ReadLine();
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            PatronesDeDisenioCreacionalesClient.Mostrar();
            break;
        case "2":
            PatronesDeDisenioEstructuralesClient.mo
            break;
        case "3":
            break;
        case "0":
            Console.WriteLine("Saliendo...");
            return;
        default:
            Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
            Console.ReadKey();
            break;
    }

}