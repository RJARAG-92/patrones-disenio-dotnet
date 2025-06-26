using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders
{
    public class CartaBuilder : IDocumentoBuilder
    {
        private readonly Documento _documento = new();

        public void ConstruirEncabezado() => _documento.Encabezado = "Carta - Gerencia de Operaciones";
        public void ConstruirCuerpo() => _documento.Cuerpo = "Por medio de la presente, se comunica que...";
        public void ConstruirReferencias() => _documento.Referencias = "Ref: Circular N°2023-09";
        public void ConstruirFirmas() => _documento.Firmas = "Firma digital del gerente responsable.";
        public void ConstruirPieLegal() => _documento.PieLegal = "Este documento tiene validez según la Ley N°...";

        public Documento ObtenerDocumento() => _documento;
    }
}
