using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders;

namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Director
{
    public class DocumentoDirector
    {
        public void ConstruirDocumento(IDocumentoBuilder builder)
        {
            builder.ConstruirEncabezado();
            builder.ConstruirCuerpo();
            builder.ConstruirReferencias();
            builder.ConstruirFirmas();
            builder.ConstruirPieLegal();
        }
    }
}
