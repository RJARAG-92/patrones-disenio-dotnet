using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders
{
    public interface IComboBuilder
    {
        void AgregarPlatoPrincipal();
        void AgregarBebida();
        void AgregarPostre();
        void AgregarJuguete();
        ComboPedido ObtenerCombo();
    }
}
