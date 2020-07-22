namespace abstract_factory
{
    //Fábrica Abstrata (Abstract Factory)
    public abstract class DBFactory
    {
        public abstract DBConnection CreateConnection();
        public abstract DBCommand CreateCommand();
    }
}