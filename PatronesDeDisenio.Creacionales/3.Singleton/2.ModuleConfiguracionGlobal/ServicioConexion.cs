namespace PatronesDeDisenio.Creacionales._3.Singleton._2.ModuleConfiguracionGlobal
{
    public class ServicioConexion
    {
        public void ConectarABaseDeDatos()
        {
            var config = ConfiguracionGlobal.Instance;
            Console.WriteLine($"[DB] Conectando usando: {config.ConexionBD}");
        }
    }
}
