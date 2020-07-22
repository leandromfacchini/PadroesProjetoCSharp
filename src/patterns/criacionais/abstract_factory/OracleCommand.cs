using System;

namespace abstract_factory
{
    public class OracleCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de Oracle Command foi chamado.");
        }
    }
}