using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director;

namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders
{
    public class ContratoServiciosBuilder : IContratoBuilder
    {
        private readonly Contrato _contrato = new();

        public void ConstruirEncabezado()
            => _contrato.Encabezado = "Contrato de Prestación de Servicios Profesionales";

        public void ConstruirClausulas()
            => _contrato.Clausulas = "Cláusulas sobre alcance del servicio, plazos y pagos.";

        public void ConstruirCondicionesEspeciales()
            => _contrato.CondicionesEspeciales = "Incluye cláusula de confidencialidad y propiedad intelectual.";

        public void ConstruirFirma()
            => _contrato.Firma = "Firmado por proveedor y cliente con rúbrica legalizada.";

        public void ConstruirAnexos()
            => _contrato.Anexos = "Anexo técnico con detalle del servicio a prestar.";

        public Contrato ObtenerContrato() => _contrato;
    }
}
