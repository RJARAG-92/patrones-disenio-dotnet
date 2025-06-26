using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders
{
    public class SolicitudBuilder : IDocumentoBuilder
    {
        private readonly Documento _documento = new();

        public void ConstruirEncabezado()
            => _documento.Encabezado = "Solicitud - Atención al Ciudadano";

        public void ConstruirCuerpo()
            => _documento.Cuerpo = "Por la presente, solicito la emisión del certificado correspondiente...";

        public void ConstruirReferencias()
            => _documento.Referencias = "Ref: Expediente N° 2024-0456";

        public void ConstruirFirmas()
            => _documento.Firmas = "Solicitante: Juan Pérez - DNI 12345678";

        public void ConstruirPieLegal()
            => _documento.PieLegal = "El presente documento está amparado por la Ley de Procedimientos Administrativos.";

        public Documento ObtenerDocumento() => _documento;
    }
}
