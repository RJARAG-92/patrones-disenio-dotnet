using PatronesDeDisenio.Creacionales._3.Singleton._1.ModuleLoggerCentralizado;
using PatronesDeDisenio.Creacionales._3.Singleton._2.ModuleConfiguracionGlobal;
using PatronesDeDisenio.Creacionales._3.Singleton._3.ModuleSessionManager;
using PatronesDeDisenio.Creacionales._3.Singleton._4.ModuleMemoryCacheManager;
using PatronesDeDisenio.Creacionales._3.Singleton._5.ModuleUniqueIdGenerator;

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
            Console.WriteLine("4. Gestor de Caché");
            Console.WriteLine("5. Generador de Identificadores Únicos");
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
                case "4":
                    EjecutarGestorCache();
                    break;
                case "5":
                    EjecutarGeneradorIdsUnico();
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

        private static void EjecutarGestorCache()
        {
            Console.WriteLine("== Ejemplo Singleton: Gestor de Caché ==");

            var servicioProducto = new ServicioProducto();
            servicioProducto.CargarProductos();

            var servicioCliente = new ServicioCliente();
            servicioCliente.MostrarProductosDesdeCache();
        }

        private static void EjecutarGeneradorIdsUnico()
        {
            Console.WriteLine("== Ejemplo Singleton: Generador de Identificadores Únicos ==");

            var ticket = new ServicioTicket();
            var doc = new ServicioDocumento();

            ticket.CrearTicket();
            doc.CrearDocumento();
            ticket.CrearTicket();

        }
    }
}
