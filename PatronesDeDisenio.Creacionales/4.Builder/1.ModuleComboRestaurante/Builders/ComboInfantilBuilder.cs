using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders
{
    public class ComboInfantilBuilder : IComboBuilder
    {
        private ComboPedido _combo = new();

        public void AgregarPlatoPrincipal() => _combo.PlatoPrincipal = "Nuggets de pollo";
        public void AgregarBebida() => _combo.Bebida = "Jugo";
        public void AgregarPostre() => _combo.Postre = "Gelatina";
        public void AgregarJuguete() => _combo.Juguete = "Muñeco sorpresa";

        public ComboPedido ObtenerCombo() => _combo;
    }
}
