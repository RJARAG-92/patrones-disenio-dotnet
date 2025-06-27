// Program.cs - ConsoleRunner 
using PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== PATRONES DE DISEÑO EN .NET ===");
    Console.WriteLine("Seleccione un patrón:");
    Console.WriteLine("1. Factory Method");
    Console.WriteLine("2. Abstract Factory");
    Console.WriteLine("3. Singleton");
    Console.WriteLine("4. Builder");
    Console.WriteLine("5. Prototype");
    Console.WriteLine("0. Salir");
    Console.WriteLine();
    Console.Write("Opción: ");

    var opcion = Console.ReadLine();
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            FactoryMethodClient.Mostrar();
            break;
        case "2":
            AbstractFactoryClient.Mostrar();
            break;
        case "3":
            SingletonClient.Mostrar();
            break;
        case "4":
            BuilderClient.Mostrar();
            break;
        case "5":
            PrototypeClient.Mostrar();
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