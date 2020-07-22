namespace abstract_factory
{
    public class OracleFactory : DBFactory
    {
        public override DBCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override DBConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}