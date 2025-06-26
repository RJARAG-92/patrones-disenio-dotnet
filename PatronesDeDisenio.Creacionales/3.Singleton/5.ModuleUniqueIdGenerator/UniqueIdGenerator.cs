namespace PatronesDeDisenio.Creacionales._3.Singleton._5.ModuleUniqueIdGenerator
{
    public sealed class UniqueIdGenerator
    {
        private static readonly Lazy<UniqueIdGenerator> _instance = new(() => new UniqueIdGenerator());

        public static UniqueIdGenerator Instance => _instance.Value;

        private int _contador = 0;
        private readonly object _lock = new();

        private UniqueIdGenerator() { }

        public int GenerarNuevoId()
        {
            lock (_lock)
            {
                _contador++;
                return _contador;
            }
        }
    }
}
