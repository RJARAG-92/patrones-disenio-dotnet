using PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales;

namespace PatronesDeDisenio.ConsoleRunner._2.PatronesDeDisenio.Estructurales
{
    public static class PatronesDeDisenioEstructuralesClient
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== PATRONES DE DISEÑO ESTRUCTURALES EN .NET ===");
                Console.WriteLine("Seleccione un patrón:");
                Console.WriteLine("1. Adapter");
                Console.WriteLine("2. Decorator");
                Console.WriteLine("3. Facade");
                Console.WriteLine("4. Composite");
                Console.WriteLine("5. Proxy");
                Console.WriteLine("6. Bridge");
                Console.WriteLine("0. Volver al menú principal");
                Console.WriteLine();
                Console.Write("Opción: ");

                var opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
