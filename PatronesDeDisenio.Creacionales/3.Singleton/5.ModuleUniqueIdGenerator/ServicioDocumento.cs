namespace PatronesDeDisenio.Creacionales._3.Singleton._5.ModuleUniqueIdGenerator
{
    public class ServicioDocumento
    {
        public void CrearDocumento()
        {
            int id = UniqueIdGenerator.Instance.GenerarNuevoId();
            Console.WriteLine($"Documento creado con código: DOC-{id:D4}");
        }
    }
}
