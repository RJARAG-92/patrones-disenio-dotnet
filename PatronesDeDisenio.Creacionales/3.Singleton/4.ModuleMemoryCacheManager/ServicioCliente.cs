namespace PatronesDeDisenio.Creacionales._3.Singleton._4.ModuleMemoryCacheManager
{
    public class ServicioCliente
    {
        public void MostrarProductosDesdeCache()
        {
            var productos = CacheManager.Instance.Obtener<List<string>>("productos");

            if (productos == null || productos.Count == 0)
            {
                Console.WriteLine("No se encontraron productos en caché.");
                return;
            }

            Console.WriteLine("Productos desde cache:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"- {producto}");
            }
        }
    }
}
