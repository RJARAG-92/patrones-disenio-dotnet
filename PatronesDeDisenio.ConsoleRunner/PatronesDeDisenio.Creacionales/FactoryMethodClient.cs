using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo1.Factories;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.ConcreteCreator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.ConcreteCreator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Creator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.ConcreteCreator;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo4.Creator;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class FactoryMethodClient
    {
        public static void Mostrar()
        {
            Console.WriteLine("=== FACTORY METHOD ===");
            Console.WriteLine("Seleccione ejemplo:");
            Console.WriteLine("1. Notificación por tipo (Email/SMS)");
            Console.WriteLine("2. Validación de documento empresarial");
            Console.WriteLine("3. Generación de reporte");
            Console.WriteLine("4. Generación de Comprobante Electronico");
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
                case "4":
                    EjecutarEjemploComprobanteElectronico();
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        private static void EjecutarEjemploNotificacion()
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

        private static void EjecutarEjemploValidacion()
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

        private static void EjecutarEjemploReporte()
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

        private static void EjecutarEjemploComprobanteElectronico()
        {
            Console.WriteLine("Seleccione formato de comrpobante electronico:");
            Console.WriteLine("1. Boleta");
            Console.WriteLine("2. Factura");
            Console.WriteLine("3. Nota Credito");
            Console.Write("Opción: ");

            var tipo = Console.ReadLine();
            Console.WriteLine();

            ComprobanteFactory factory = tipo switch
            {
                "1" => new BoletaFactory(),
                "2" => new FacturaElectronicaFactory(),
                "3" => new NotaCreditoFactory(),
                _ => throw new InvalidOperationException("Formato inválido")
            };

            var generador = factory.CrearGenerador();
            generador.Generar("Contenido para el comprobante");
        }
    }
}
