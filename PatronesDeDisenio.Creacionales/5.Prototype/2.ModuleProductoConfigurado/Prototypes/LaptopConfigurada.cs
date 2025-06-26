using PatronesDeDisenio.Creacionales._5.Prototype._2.ModuleProductoConfigurado.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._2.ModuleProductoConfigurado.Prototypes
{
    public class LaptopConfigurada : IProductoPrototype
    {
        public string Modelo { get; set; } = "Laptop X1";
        public int RAM { get; set; } = 16;
        public int Almacenamiento { get; set; } = 512;
        public bool TarjetaGraficaDedicada { get; set; } = false;

        public IProductoPrototype? Clonar()
        {
            return MemberwiseClone() as IProductoPrototype;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"RAM: {RAM} GB - Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"¿Tiene GPU dedicada?: {(TarjetaGraficaDedicada ? "Sí" : "No")}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
