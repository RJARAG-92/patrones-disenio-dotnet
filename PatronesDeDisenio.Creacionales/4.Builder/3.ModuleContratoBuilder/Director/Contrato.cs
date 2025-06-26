namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director
{
    public class Contrato
    {
        public string? Encabezado { get; set; }
        public string? Clausulas { get; set; }
        public string? CondicionesEspeciales { get; set; }
        public string? Firma { get; set; }
        public string? Anexos { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Contrato generado:");
            Console.WriteLine($"Encabezado:             {Encabezado}");
            Console.WriteLine($"Cláusulas:              {Clausulas}");
            Console.WriteLine($"Condiciones Especiales: {CondicionesEspeciales}");
            Console.WriteLine($"Firma:                  {Firma}");
            Console.WriteLine($"Anexos:                 {Anexos}");
        }
    }
}
