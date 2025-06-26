using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders;

namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Director
{
    public class ComboDirector
    {
        public void ConstruirComboCompleto(IComboBuilder builder)
        {
            builder.AgregarPlatoPrincipal();
            builder.AgregarBebida();
            builder.AgregarPostre();
            builder.AgregarJuguete();
        }
    }
}
