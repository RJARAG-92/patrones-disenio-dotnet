namespace PatronesDeDisenio.Creacionales._3.Singleton._4.ModuleMemoryCacheManager
{
    public class ServicioProducto
    {
        public void CargarProductos()
        {
            var productos = new List<string> { "Laptop", "Monitor", "Mouse" };
            CacheManager.Instance.Guardar("productos", productos);
            Console.WriteLine("Productos cargados en cache.");
        }
    }
}
