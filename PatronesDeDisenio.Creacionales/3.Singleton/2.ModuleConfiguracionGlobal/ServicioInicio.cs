namespace PatronesDeDisenio.Creacionales._3.Singleton._2.ModuleConfiguracionGlobal
{
    public class ServicioInicio
    {
        public void VerificarEntorno()
        {
            var config = ConfiguracionGlobal.Instance;
            Console.WriteLine($"[Inicio] La aplicación está en el entorno: {config.Entorno}");
        }
    }
}
