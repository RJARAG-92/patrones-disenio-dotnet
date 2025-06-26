using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director;

namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders
{
    public class ContratoLaboralBuilder : IContratoBuilder
    {
        private readonly Contrato _contrato = new();

        public void ConstruirEncabezado() => _contrato.Encabezado = "Contrato Laboral - Ley 728";
        public void ConstruirClausulas() => _contrato.Clausulas = "Cláusulas laborales estándar.";
        public void ConstruirCondicionesEspeciales() => _contrato.CondicionesEspeciales = "Incluye periodo de prueba de 3 meses.";
        public void ConstruirFirma() => _contrato.Firma = "Firmado por empleador y trabajador.";
        public void ConstruirAnexos() => _contrato.Anexos = "Anexo de cargo y funciones.";

        public Contrato ObtenerContrato() => _contrato;
    }
}
