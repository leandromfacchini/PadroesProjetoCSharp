using System;

namespace abstract_factory
{
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de SQL Command foi chamado.");
        }
    }
}