namespace PatronesDeDisenio.Creacionales._4.Builder._2.ModuleReportBuilder.Product
{
    public class Reporte
    {
        public string? Encabezado { get; set; }
        public string? Cuerpo { get; set; }
        public string? Grafico { get; set; }
        public string? Pie { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Reporte generado:");
            Console.WriteLine($"Encabezado: {Encabezado}");
            Console.WriteLine($"Cuerpo:     {Cuerpo}");
            Console.WriteLine($"Gráfico:    {Grafico}");
            Console.WriteLine($"Pie:        {Pie}");
        }
    }
}
