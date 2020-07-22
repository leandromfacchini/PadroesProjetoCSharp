using System;

namespace abstract_factory
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            //var conn = new SQLConnection();
            // var conn = new SQLFactory();
            var conn = new OracleFactory();
            var connection = conn.CreateConnection();
            connection.Open();

            //var cmd = new SQLCommand();
            var command = conn.CreateCommand();
            command.Execute();

            Console.ReadKey();
        }
    }
}
