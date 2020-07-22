using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new SQLConnection();
            conn.Open();

            var cmd = new SQLCommand();
            cmd.Execute();

            Console.ReadKey();
        }
    }
}
