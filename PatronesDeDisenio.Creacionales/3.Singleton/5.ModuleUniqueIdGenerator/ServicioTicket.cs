namespace PatronesDeDisenio.Creacionales._3.Singleton._5.ModuleUniqueIdGenerator
{
    public class ServicioTicket
    {
        public void CrearTicket()
        {
            int id = UniqueIdGenerator.Instance.GenerarNuevoId();
            Console.WriteLine($"Nuevo Ticket generado: TCK-{id:D4}");
        }
    }
}
