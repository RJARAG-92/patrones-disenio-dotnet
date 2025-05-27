using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Interfaces;
using PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Services;

namespace PatronesDeDisenio.Creacionales.FactoryMethod.Ejemplo2.Factories
{
    public class ValidadorFactoryConcreto
    {
        public static IValidadorDocumento ObtenerValidador(string tipo)
        {
            return tipo switch
            {
                "Factura" => new ValidadorFactura(),
                "Contrato" => new ValidadorContrato(),
                "Memorando" => new ValidadorMemorando(),
                _ => throw new InvalidOperationException("Tipo desconocido")
            };
        }
    }
}
