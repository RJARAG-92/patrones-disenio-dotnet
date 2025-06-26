namespace PatronesDeDisenio.Creacionales._3.Singleton._4.ModuleMemoryCacheManager
{
    public sealed class CacheManager
    {
        private static readonly Lazy<CacheManager> _instance = new(() => new CacheManager());

        public static CacheManager Instance => _instance.Value;

        private readonly Dictionary<string, object> _cache = new();

        private CacheManager() { }

        public void Guardar(string clave, object valor)
        {
            _cache[clave] = valor;
        }

        public T? Obtener<T>(string clave)
        {
            return _cache.TryGetValue(clave, out var valor) ? (T)valor : default;
        }

        public void Eliminar(string clave)
        {
            _cache.Remove(clave);
        }

        public void Limpiar()
        {
            _cache.Clear();
        }
    }
}
