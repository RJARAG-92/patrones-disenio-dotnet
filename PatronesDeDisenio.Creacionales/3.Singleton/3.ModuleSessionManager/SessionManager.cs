namespace PatronesDeDisenio.Creacionales._3.Singleton._3.ModuleSessionManager
{
    public sealed class SessionManager
    {
        private static readonly Lazy<SessionManager> _instance = new(() => new SessionManager());

        public static SessionManager Instance => _instance.Value;

        private SessionManager() { }

        public Usuario? UsuarioActual { get; private set; }

        public void IniciarSesion(string nombre, string rol)
        {
            UsuarioActual = new Usuario
            {
                Nombre = nombre,
                Rol = rol
            };
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        public bool HaySesionActiva => UsuarioActual != null;
    }
}
