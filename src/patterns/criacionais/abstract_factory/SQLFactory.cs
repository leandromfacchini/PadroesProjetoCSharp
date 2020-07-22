namespace abstract_factory
{
    //Fábrica Concreta (Concrete Factory)
    public class SQLFactory : DBFactory
    {
        public override DBCommand CreateCommand()
        {
            return new SQLCommand();
        }

        public override DBConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}