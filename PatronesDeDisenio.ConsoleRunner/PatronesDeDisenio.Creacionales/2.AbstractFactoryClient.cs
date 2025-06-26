using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.Client;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo1.ConcreteFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.Client;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo2.ConcreteFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.Cliente;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo3.ConcreteFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.Cliente;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteFactory;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.Cliente;
using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.ConcreteFactory;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class AbstractFactoryClient
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("=== ABSTRACT FACTORY ===");
            Console.WriteLine("Seleccione ejemplo:");
            Console.WriteLine("1. Pasarelas de Pago");
            Console.WriteLine("2. Conexiones a bases de datos");
            Console.WriteLine("3. Interfaces gráficas multiplataforma");
            Console.WriteLine("4. Generación de informes financieros por región");
            Console.WriteLine("5. Sistema de reportes exportables");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Opción: ");

            var seleccion = Console.ReadLine();
            Console.Clear();

            switch (seleccion)
            {
                case "1":
                    EjecutarEjemploPasarelaPago();
                    break;
                case "2":
                    EjecutarEjemploConexionBaseDatos();
                    break;
                case "3":
                    EjecutarEjemploGuiMultiplataforma();
                    break;
                case "4":
                    EjecutarEjemploInformeFinanciero();
                    break;
                case "5":
                    EjecutarEjemploReporteExportable();
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
        private static void EjecutarEjemploPasarelaPago()
        {
            Console.WriteLine("Seleccione la pasarela de pago:");
            Console.WriteLine("1. PayPal");
            Console.WriteLine("2. Stripe");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            IPaymentGatewayFactory factory = opcion switch
            {
                "1" => new PayPalFactory(),
                "2" => new StripeFactory(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var checkout = new CheckoutService(factory);
            checkout.ProcesarPago(150.00m, "TXN001-AF");
        }
        private static void EjecutarEjemploConexionBaseDatos()
        {
            Console.WriteLine("Seleccione base de datos:");
            Console.WriteLine("1. SQL Server");
            Console.WriteLine("2. PostgreSQL");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            IDbFactory factory = opcion switch
            {
                "1" => new SqlServerFactory(),
                "2" => new PostgreSqlFactory(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var cliente = new ClienteDbConnector(factory);
            cliente.EjecutarConsulta("SELECT * FROM Clientes");
        }
        private static void EjecutarEjemploGuiMultiplataforma()
        {
            Console.WriteLine("Seleccione el sistema operativo:");
            Console.WriteLine("1. Windows");
            Console.WriteLine("2. Linux");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            IGuiFactory factory = opcion switch
            {
                "1" => new WindowsGuiFactory(),
                "2" => new LinuxGuiFactory(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var app = new ClienteGUI(factory);
            app.RenderUI();
        }
        private static void EjecutarEjemploInformeFinanciero()
        {
            Console.WriteLine("Seleccione la región del informe:");
            Console.WriteLine("1. Europa");
            Console.WriteLine("2. Latinoamérica");
            Console.WriteLine("3. Asia");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            IReporteFinancieroFactory factory = opcion switch
            {
                "1" => new EuropaFactory(),
                "2" => new LatamFactory(),
                "3" => new AsiaFactory(),
                _ => throw new InvalidOperationException("Región inválida")
            };

            var servicio = new ServicioReporteFinanciero(factory);
            servicio.GenerarReporte("reporte_trimestral");
        }
        private static void EjecutarEjemploReporteExportable()
        {
            Console.WriteLine("Seleccione formato de exportación:");
            Console.WriteLine("1. PDF");
            Console.WriteLine("2. Excel");
            Console.WriteLine("3. HTML");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.WriteLine();

            IReportingFactory factory = opcion switch
            {
                "1" => new PdfReportingFactory(),
                "2" => new ExcelReportingFactory(),
                "3" => new HtmlReportingFactory(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var reportService = new ReportService(factory);
            reportService.GenerarReporte("Ventas del trimestre","Contenido","Tipo Grafico","nombreArchivo");
        }
    }
}
