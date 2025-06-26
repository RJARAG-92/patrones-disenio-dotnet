namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Product
{
    public class ComboPedido
    {
        public string? PlatoPrincipal { get; set; }
        public string? Bebida { get; set; }
        public string? Postre { get; set; }
        public string? Juguete { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Combo armado:");
            Console.WriteLine($"- Plato Principal: {PlatoPrincipal}");
            Console.WriteLine($"- Bebida: {Bebida}");
            Console.WriteLine($"- Postre: {Postre}");

            if (!string.IsNullOrEmpty(Juguete))
                Console.WriteLine($"- Juguete: {Juguete}");
        }
    }
}
