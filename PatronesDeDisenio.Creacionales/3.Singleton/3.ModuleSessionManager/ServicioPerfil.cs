namespace PatronesDeDisenio.Creacionales._3.Singleton._3.ModuleSessionManager
{
    public class ServicioPerfil
    {
        public void MostrarPerfil()
        {
            var sesion = SessionManager.Instance;
            if (!sesion.HaySesionActiva)
            {
                Console.WriteLine("No hay sesión activa.");
                return;
            }

            var usuario = sesion.UsuarioActual!;
            Console.WriteLine($"Usuario: {usuario.Nombre}");
            Console.WriteLine($"Rol: {usuario.Rol}");
        }
    }
}
