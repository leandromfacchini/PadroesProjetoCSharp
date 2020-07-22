using System;

namespace abstract_factory
{
    //Produto Concreto (Concrete Product)
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SQL Connection foi chamado.");
        }
    }
}