using PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototypes;

namespace PatronesDeDisenio.ConsoleRunner.PatronesDeDisenio.Creacionales
{
    public static class PrototypeClient
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("=== PROTOTYPE - Ejemplos ===\n");
            Console.WriteLine("1. Plantillas de Documentos");
            Console.WriteLine("2. Producto Configurado (Laptop)");
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
                case "0":
                    break;
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
            //Console.WriteLine("=== PROTOTYPE - Producto Configurado ===\n");

            //var laptopBase = new LaptopConfigurada();

            //var laptopGamer = laptopBase.Clonar() as LaptopConfigurada;
            //laptopGamer!.Modelo = "Laptop X1 Gamer Edition";
            //laptopGamer.RAM = 32;
            //laptopGamer.TarjetaGraficaDedicada = true;

            //var laptopEconomica = laptopBase.Clonar() as LaptopConfigurada;
            //laptopEconomica!.Modelo = "Laptop X1 Eco";
            //laptopEconomica.RAM = 8;
            //laptopEconomica.Almacenamiento = 256;

            //Console.WriteLine("Producto Base (Laptop X1):");
            //laptopBase.Mostrar();

            //Console.WriteLine("Producto Clonado (Laptop X1 Gamer Edition):");
            //laptopGamer.Mostrar();

            //Console.WriteLine("Producto Clonado (Laptop X1 Eco):");
            //laptopEconomica.Mostrar();
        }
    }
}
