using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director;

namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders
{
    public class ContratoAlquilerBuilder : IContratoBuilder
    {
        private readonly Contrato _contrato = new();

        public void ConstruirEncabezado()
            => _contrato.Encabezado = "Contrato de Alquiler de Bien Inmueble";

        public void ConstruirClausulas()
            => _contrato.Clausulas = "Cláusulas sobre uso, duración, pago de renta y garantías.";

        public void ConstruirCondicionesEspeciales()
            => _contrato.CondicionesEspeciales = "Incluye cláusula de resolución anticipada con penalidad.";

        public void ConstruirFirma()
            => _contrato.Firma = "Firmado por arrendador y arrendatario con DNI.";

        public void ConstruirAnexos()
            => _contrato.Anexos = "Anexo de inventario de bienes y plano del inmueble.";

        public Contrato ObtenerContrato() => _contrato;
    }
}
