using PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._1.ModulePlantillaDocumento.Prototypes
{
    public class PlantillaSolicitud : IDocumentoPrototype
    {
        public string Titulo { get; set; } = "Solicitud de Certificado";
        public string Cuerpo { get; set; } = "Por medio de la presente, solicito la emisión del certificado...";
        public string Solicitante { get; set; } = "Nombre Apellido";

        public IDocumentoPrototype? Clonar()
        {
            return MemberwiseClone() as IDocumentoPrototype;
        }

        public void Mostrar()
        {
            Console.WriteLine("Solicitud Clonada");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Solicitante: {Solicitante}");
            Console.WriteLine($"Contenido: {Cuerpo}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
