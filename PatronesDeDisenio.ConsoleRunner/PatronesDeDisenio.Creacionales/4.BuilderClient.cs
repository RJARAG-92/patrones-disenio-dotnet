using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders;
using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Director;
using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Builder;
using PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Director;

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
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("\nOpción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EjecutarComboRestaurante();
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
            Console.Clear();
            Console.WriteLine("== Ejemplo Builder: Combo de Restaurante ==");
            Console.WriteLine("Seleccione tipo de combo:");
            Console.WriteLine("1. Combo Clásico");
            Console.WriteLine("2. Combo Infantil");
            Console.WriteLine("3. Combo Ejecutivo");
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

        private static void EjecutarGenerarReporte()
        {
            Console.WriteLine("== Ejemplo Builder: Generador de Reportes ==");

            Console.WriteLine("Seleccione el formato:");
            Console.WriteLine("1. PDF\n2. Excel\n3. HTML");
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
    }
}
