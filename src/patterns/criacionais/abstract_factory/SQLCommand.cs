using System;

namespace abstract_factory
{
    //Produto Concreto (Concrete Product)
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de SQL Command foi chamado.");
        }
    }
}