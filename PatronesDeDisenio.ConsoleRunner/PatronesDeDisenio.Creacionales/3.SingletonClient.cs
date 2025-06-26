using PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado;
using PatronesDeDisenio.Creacionales._3.Singleton._2.ModuleConfiguracionGlobal;
using PatronesDeDisenio.Creacionales._3.Singleton._3.ModuleSessionManager;

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
            Console.WriteLine("2. Configuración Global");
            Console.WriteLine("3. Gestor de Sesión de Usuario");
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
                case "2":
                    EjecutarConfiguracionGlobal();
                    break;
                case "3":
                    EjecutarGestorSesionUsuario();
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

        private static void EjecutarConfiguracionGlobal()
        {
            Console.WriteLine("== Ejemplo 2: Configuración Global ==");

            var inicio = new ServicioInicio();
            inicio.VerificarEntorno();

            var db = new ServicioConexion();
            db.ConectarABaseDeDatos();

            ConfiguracionGlobal.Instance.MostrarConfiguracion();
        }

        private static void EjecutarGestorSesionUsuario()
        {
            Console.WriteLine("== Ejemplo Singleton: Gestor de Sesión ==");

            var auth = new ServicioAutenticacion();
            var perfil = new ServicioPerfil();

            auth.Login("Ricardo", "Administrador");
            perfil.MostrarPerfil();

            auth.Logout();
            perfil.MostrarPerfil();
        }
    }
}
