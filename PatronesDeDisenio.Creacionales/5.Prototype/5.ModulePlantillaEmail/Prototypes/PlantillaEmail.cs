using PatronesDeDisenio.Creacionales._5.Prototype._5.ModulePlantillaEmail.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._5.ModulePlantillaEmail.Prototypes
{
    public class PlantillaEmail : IEmailPrototype
    {
        public string Asunto { get; set; } = "Bienvenido a nuestra plataforma";
        public string Cuerpo { get; set; } = "Gracias por registrarte. Esperamos que disfrutes el servicio.";
        public string Destinatario { get; set; } = "usuario@ejemplo.com";

        public IEmailPrototype? Clonar()
        {
            return MemberwiseClone() as IEmailPrototype;
        }

        public void Enviar()
        {
            Console.WriteLine($"Enviando a: {Destinatario}");
            Console.WriteLine($"Asunto: {Asunto}");
            Console.WriteLine($"Mensaje: {Cuerpo}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
