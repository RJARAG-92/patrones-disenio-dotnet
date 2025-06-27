using PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales;

namespace PatronesDeDisenio.ConsoleRunner._1.PatronesDeDisenio.Creacionales
{
    public static class PatronesDeDisenioCreacionalesClient
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== PATRONES DE DISEÑO CREACIONALES EN .NET ===");
                Console.WriteLine("Seleccione un patrón:");
                Console.WriteLine("1. Factory Method");
                Console.WriteLine("2. Abstract Factory");
                Console.WriteLine("3. Singleton");
                Console.WriteLine("4. Builder");
                Console.WriteLine("5. Prototype");
                Console.WriteLine("0. Volver al menú principal");
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
