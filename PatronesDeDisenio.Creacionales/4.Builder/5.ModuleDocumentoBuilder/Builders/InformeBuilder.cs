using PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Product;

namespace PatronesDeDisenio.Creacionales._4.Builder._5.ModuleDocumentoBuilder.Builders
{
    public class InformeBuilder : IDocumentoBuilder
    {
        private readonly Documento _documento = new();

        public void ConstruirEncabezado()
            => _documento.Encabezado = "Informe Técnico - Departamento de TI";

        public void ConstruirCuerpo()
            => _documento.Cuerpo = "El presente informe detalla los hallazgos durante la auditoría del sistema...";

        public void ConstruirReferencias()
            => _documento.Referencias = "Ref: IT-2024-AUD-003";

        public void ConstruirFirmas()
            => _documento.Firmas = "Ing. María Rodríguez - Responsable de TI";

        public void ConstruirPieLegal()
            => _documento.PieLegal = "Documento oficial generado conforme a la normativa ISO 27001.";

        public Documento ObtenerDocumento() => _documento;
    }
}
