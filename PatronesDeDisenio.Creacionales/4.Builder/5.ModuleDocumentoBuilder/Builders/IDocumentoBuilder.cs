using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders
{
    public interface IDocumentoBuilder
    {
        void ConstruirEncabezado();
        void ConstruirCuerpo();
        void ConstruirReferencias();
        void ConstruirFirmas();
        void ConstruirPieLegal();
        Documento ObtenerDocumento();
    }
}
