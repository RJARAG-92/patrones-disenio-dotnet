using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders;
using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Director;
using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder;
using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Director;
using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders;
using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director;
using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Builders;
using PatronesDeDisenio.Creacionales._4.Builder._4.ModuleConfiguracionEntorno.Director;
using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders;
using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Director;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class BuilderClient
    {
        public static void Mostrar()
        {

            Console.Clear();
            Console.WriteLine("=== PATRÓN BUILDER ===");
            Console.WriteLine("Seleccione el ejemplo:");
            Console.WriteLine("1. Combo de Restaurante");
            Console.WriteLine("2. Generador de Reportes");
            Console.WriteLine("3. Contratos Personalizados");
            Console.WriteLine("4. Configuración por Entorno");
            Console.WriteLine("5. Generador de Documento Oficial");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine();
            Console.Write("\nOpción: ");

            var opcion = Console.ReadLine();

            Console.Clear();
            switch (opcion)
            {
                case "1":
                    EjecutarComboRestaurante();
                    break;
                case "2":
                    EjecutarGeneradorReporte();
                    break;
                case "3":
                    EjecutarContratosPersonalizados();
                    break;
                case "4":
                    EjecutarConfiguracionEntorno();
                    break;
                case "5":
                    EjecutarGeneradorDocumento();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla...");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Mostrar();
        }

        private static void EjecutarComboRestaurante()
        {
            Console.WriteLine("== Ejemplo Builder: Combo de Restaurante ==");
            Console.WriteLine("Seleccione tipo de combo:");
            Console.WriteLine("1. Combo Clásico");
            Console.WriteLine("2. Combo Infantil");
            Console.WriteLine("3. Combo Ejecutivo");
            Console.WriteLine();
            Console.Write("\nOpción: ");

            IComboBuilder builder = Console.ReadLine() switch
            {
                "1" => new ComboClasicoBuilder(),
                "2" => new ComboInfantilBuilder(),
                "3" => new ComboEjecutivoBuilder(),
                _ => throw new InvalidOperationException("Tipo de combo inválido")
            };

            var director = new ComboDirector();
            director.ConstruirComboCompleto(builder);

            var combo = builder.ObtenerCombo();
            Console.WriteLine();
            combo.Mostrar();
        }

        private static void EjecutarGeneradorReporte()
        {
            Console.WriteLine("== Ejemplo Builder: Generador de Reportes ==");
            Console.WriteLine("Seleccione el formato:");
            Console.WriteLine("1. PDF\n2. Excel\n3. HTML");
            Console.WriteLine();
            Console.Write("Opción: ");
            var opcion = Console.ReadLine();

            IReporteBuilder builder = opcion switch
            {
                "1" => new PdfReporteBuilder(),
                "2" => new ExcelReporteBuilder(),
                "3" => new HtmlReporteBuilder(),
                _ => throw new InvalidOperationException("Formato inválido")
            };

            var director = new ReporteDirector();
            director.ConstruirReporteCompleto(builder);

            var reporte = builder.ObtenerReporte();
            Console.WriteLine();
            reporte.Mostrar();
        }
        private static void EjecutarContratosPersonalizados()
        {
            Console.WriteLine("== Ejemplo Builder: Contratos Personalizados ==");
            Console.WriteLine("Seleccione el tipo de contrato:");
            Console.WriteLine("1. Laboral");
            Console.WriteLine("2. Alquiler");
            Console.WriteLine("3. Servicios");
            Console.WriteLine();
            Console.Write("Opción: ");
            var opcion = Console.ReadLine();

            IContratoBuilder builder = opcion switch
            {
                "1" => new ContratoLaboralBuilder(),
                "2" => new ContratoAlquilerBuilder(),
                "3" => new ContratoServiciosBuilder(),
                _ => throw new InvalidOperationException("Tipo inválido")
            };

            var director = new ContratoDirector();
            director.ConstruirContratoCompleto(builder);

            var contrato = builder.ObtenerContrato();
            Console.WriteLine();
            contrato.Mostrar();
        }
        private static void EjecutarConfiguracionEntorno()
        {
            Console.WriteLine("== Ejemplo Builder: Configuración por Entorno ==");
            Console.WriteLine("Seleccione entorno:");
            Console.WriteLine("1. Desarrollo\n2. QA\n3. Producción");
            Console.WriteLine();
            Console.Write("Opción: ");
            var opcion = Console.ReadLine();

            IConfiguracionBuilder builder = opcion switch
            {
                "1" => new DevConfigBuilder(),
                "2" => new QaConfigBuilder(),
                "3" => new ProdConfigBuilder(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var director = new ConfiguracionDirector();
            director.ConstruirConfiguracion(builder);

            var configuracion = builder.ObtenerConfiguracion();
            Console.WriteLine();
            configuracion.Mostrar();
        }
        private static void EjecutarGeneradorDocumento()
        {
            Console.WriteLine("== Ejemplo Builder: Generador de Documento Oficial ==");
            Console.WriteLine("Seleccione tipo de documento:");
            Console.WriteLine("1. Carta\n2. Solicitud\n3. Informe");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();

            IDocumentoBuilder builder = opcion switch
            {
                "1" => new CartaBuilder(),
                "2" => new SolicitudBuilder(),
                "3" => new InformeBuilder(),
                _ => throw new InvalidOperationException("Opción inválida")
            };

            var director = new DocumentoDirector();
            director.ConstruirDocumento(builder);

            var documento = builder.ObtenerDocumento();
            Console.WriteLine();
            documento.Mostrar();
        }
    }
}
