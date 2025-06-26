using PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Director;

namespace PatronesDeDisenio.Creacionales._4.Builder._3.ModuleContratoBuilder.Builders
{
    public interface IContratoBuilder
    {
        void ConstruirEncabezado();
        void ConstruirClausulas();
        void ConstruirCondicionesEspeciales();
        void ConstruirFirma();
        void ConstruirAnexos();
        Contrato ObtenerContrato();
    }
}
