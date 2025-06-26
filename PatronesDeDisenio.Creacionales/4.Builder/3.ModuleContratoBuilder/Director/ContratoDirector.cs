using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders;

namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director
{
    public class ContratoDirector
    {
        public void ConstruirContratoCompleto(IContratoBuilder builder)
        {
            builder.ConstruirEncabezado();
            builder.ConstruirClausulas();
            builder.ConstruirCondicionesEspeciales();
            builder.ConstruirFirma();
            builder.ConstruirAnexos();
        }
    }
}
