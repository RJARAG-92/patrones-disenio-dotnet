using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Product;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo3.Creator
{
    public abstract class ReporteFactory
    {
        public abstract IReporteGenerator CrearGenerador();

        public void GenerarReporteConLog(string contenido)
        {
            Console.WriteLine("[LOG] Preparando generación de reporte...");
            var generador = CrearGenerador();
            generador.Generar(contenido);
            Console.WriteLine("[LOG] Generación finalizada.");
        }
    }
}
