using System;

namespace abstract_factory
{
    public class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de Oracle Connection foi chamado.");
        }
    }
}