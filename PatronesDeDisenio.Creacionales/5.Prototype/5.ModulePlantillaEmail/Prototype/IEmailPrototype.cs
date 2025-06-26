namespace PatronesDeDisenio.Creacionales._5.Prototype._5.ModulePlantillaEmail.Prototype
{
    public interface IEmailPrototype
    {
        IEmailPrototype? Clonar();
        void Enviar();
    }
}
