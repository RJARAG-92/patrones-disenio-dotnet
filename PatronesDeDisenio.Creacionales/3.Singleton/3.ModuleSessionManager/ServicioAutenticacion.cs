namespace PatronesDeDisenio.Creacionales._3.Singleton._3.ModuleSessionManager
{
    public class ServicioAutenticacion
    {
        public void Login(string usuario, string rol)
        {
            SessionManager.Instance.IniciarSesion(usuario, rol);
            Console.WriteLine($"Usuario '{usuario}' ha iniciado sesión con rol '{rol}'.");
        }

        public void Logout()
        {
            SessionManager.Instance.CerrarSesion();
            Console.WriteLine("Sesión cerrada.");
        }
    }
}
