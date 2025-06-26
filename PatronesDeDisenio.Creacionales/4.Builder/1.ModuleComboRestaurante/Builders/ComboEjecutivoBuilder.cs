using PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._1.ModuleComboRestaurante.Builders
{
    public class ComboEjecutivoBuilder : IComboBuilder
    {
        private ComboPedido _combo = new();

        public void AgregarPlatoPrincipal() => _combo.PlatoPrincipal = "Filete con arroz";
        public void AgregarBebida() => _combo.Bebida = "Agua mineral";
        public void AgregarPostre() => _combo.Postre = "Fruta fresca";
        public void AgregarJuguete() => _combo.Juguete = null;

        public ComboPedido ObtenerCombo() => _combo;
    }
}
