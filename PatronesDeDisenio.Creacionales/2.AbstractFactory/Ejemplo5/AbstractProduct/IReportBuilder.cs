namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo5.AbstractProduct
{
    public interface IReportBuilder
    {
        void BuildHeader(string title);
        void BuildBody(string content);
        void BuildFooter();
    }
}
