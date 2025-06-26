using PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototypes;
using PatronesDeDisenio.Creacionales._5.Prototype._2.ModuleProductoConfigurado.Prototypes;
using PatronesDeDisenio.Creacionales._5.Prototype._3.ModuleUsuarioPerfilado.Prototypes;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class PrototypeClient
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("=== PATRÓN PROTOTYPE ===\n");
            Console.WriteLine("1. Plantillas de Documentos");
            Console.WriteLine("2. Producto Configurado (Laptop)");
            Console.WriteLine("3. Usuario Perfilado");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Opción: ");

            var opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    EjecutarEjemploPlantillas();
                    break;
                case "2":
                    EjecutarEjemploLaptop();
                    break;
                case "3":
                    EjecutarEjemploUsuarioPerfilado();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Mostrar();
        }
        private static void EjecutarEjemploPlantillas()
        {
            Console.WriteLine("=== PROTOTYPE - Plantillas de Documentos ===\n");

            var plantillaContrato = new PlantillaContrato();
            var contrato1 = plantillaContrato.Clonar() as PlantillaContrato;
            contrato1!.Titulo = "Contrato de Consultoría";

            var plantillaSolicitud = new PlantillaSolicitud();
            var solicitud1 = plantillaSolicitud.Clonar() as PlantillaSolicitud;
            solicitud1!.Solicitante = "Ricardo Jara";

            contrato1.Mostrar();
            solicitud1.Mostrar();

        }
        private static void EjecutarEjemploLaptop()
        {
            Console.WriteLine("=== PROTOTYPE - Producto Configurado (Laptop) ===\n");

            var laptopBase = new LaptopConfigurada();

            var laptopGamer = laptopBase.Clonar() as LaptopConfigurada;
            laptopGamer!.Modelo = "Laptop X1 Gamer Edition";
            laptopGamer.RAM = 32;
            laptopGamer.TarjetaGraficaDedicada = true;

            var laptopEconomica = laptopBase.Clonar() as LaptopConfigurada;
            laptopEconomica!.Modelo = "Laptop X1 Eco";
            laptopEconomica.RAM = 8;
            laptopEconomica.Almacenamiento = 256;

            laptopBase.Mostrar();
            laptopGamer.Mostrar();
            laptopEconomica.Mostrar();
        }
        private static void EjecutarEjemploUsuarioPerfilado()
        {
            Console.WriteLine("=== PROTOTYPE - Usuario Perfilado ===\n");

            var perfilBase = new UsuarioBase();

            var admin = perfilBase.Clonar() as UsuarioBase;
            admin!.Nombre = "Administrador";
            admin.Permisos.AddRange(new[] { "Crear", "Eliminar", "Auditar" });

            var auditor = perfilBase.Clonar() as UsuarioBase;
            auditor!.Nombre = "Auditor";
            auditor.Permisos.Add("Revisar Logs");

            perfilBase.Mostrar();
            admin.Mostrar();
            auditor.Mostrar();

        }
    }
}
