namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Product
{
    public class Documento
    {
        public string? Encabezado { get; set; }
        public string? Cuerpo { get; set; }
        public string? Referencias { get; set; }
        public string? Firmas { get; set; }
        public string? PieLegal { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Documento generado:");
            Console.WriteLine($"Encabezado:   {Encabezado}");
            Console.WriteLine($"Cuerpo:       {Cuerpo}");
            Console.WriteLine($"Referencias:  {Referencias}");
            Console.WriteLine($"Firmas:       {Firmas}");
            Console.WriteLine($"Pie legal:    {PieLegal}");
        }
    }
}
