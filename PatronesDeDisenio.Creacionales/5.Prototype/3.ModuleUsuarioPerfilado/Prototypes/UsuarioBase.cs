using PatronesDeDisenio.Creacionales._5.Prototype._3.ModuleUsuarioPerfilado.Prototype;

namespace PatronesDeDisenio.Creacionales._5.Prototype._3.ModuleUsuarioPerfilado.Prototypes
{
    public class UsuarioBase : IUsuarioPrototype
    {
        public string Nombre { get; set; } = "Usuario Base";
        public List<string> Permisos { get; set; } = new() { "Leer", "Acceder Panel" };

        public IUsuarioPrototype Clonar()
        {
            // Clonamos los permisos para evitar referencia compartida
            var copia = (UsuarioBase)this.MemberwiseClone();
            copia.Permisos = new List<string>(Permisos);
            return copia;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Permisos: {string.Join(", ", Permisos)}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
