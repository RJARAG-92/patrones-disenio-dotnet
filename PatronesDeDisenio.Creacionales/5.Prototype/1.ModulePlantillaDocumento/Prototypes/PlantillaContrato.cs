using PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototypes
{
    public class PlantillaContrato : IDocumentoPrototype
    {
        public string Titulo { get; set; } = "Contrato de Servicios";
        public string Cuerpo { get; set; } = "Acuerdo entre proveedor y cliente sobre los términos de servicio...";
        public DateTime Fecha { get; set; } = DateTime.Now;

        public IDocumentoPrototype? Clonar()
        {
            return MemberwiseClone() as IDocumentoPrototype;
        }

        public void Mostrar()
        {
            Console.WriteLine("Contrato Clonado");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy}");
            Console.WriteLine($"Contenido: {Cuerpo}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
