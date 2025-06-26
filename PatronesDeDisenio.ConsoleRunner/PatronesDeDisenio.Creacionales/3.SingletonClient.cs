using PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class SingletonClient
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("===== PATRÓN SINGLETON =====");
            Console.WriteLine("Seleccione el ejemplo a ejecutar:");
            Console.WriteLine("1. Logger Centralizado");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    EjecutarLoggerCentralizado();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    Mostrar();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Mostrar();
        }

        private static void EjecutarLoggerCentralizado()
        {
            Console.WriteLine("\n== Ejemplo 1: Logger Centralizado ==");

            var servicioPago = new ServicioPago();
            servicioPago.ProcesarPago();

            var servicioNotificacion = new ServicioNotificacion();
            servicioNotificacion.EnviarCorreo();
        }
    }
}
