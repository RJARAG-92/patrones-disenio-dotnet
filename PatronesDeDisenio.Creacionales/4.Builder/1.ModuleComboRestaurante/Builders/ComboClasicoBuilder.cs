using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders
{
    public class ComboClasicoBuilder : IComboBuilder
    {
        private ComboPedido _combo = new();

        public void AgregarPlatoPrincipal() => _combo.PlatoPrincipal = "Hamburguesa";
        public void AgregarBebida() => _combo.Bebida = "Gaseosa";
        public void AgregarPostre() => _combo.Postre = "Helado";
        public void AgregarJuguete() => _combo.Juguete = null;

        public ComboPedido ObtenerCombo() => _combo;
    }
}
