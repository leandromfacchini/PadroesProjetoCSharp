using System;

namespace factory
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            // var login = new AutenticacaoGoogle();
            // login.Autenticar();

            Creator[] creators = new Creator[2];
            creators[0] = new GoogleCreator();
            creators[1] = new FacebookCreator();

            foreach (Creator creator in creators)
            {
                Autenticacao autenticacao = creator.CreateInstace();
                autenticacao.Autenticar();
            }

            Console.ReadKey();
        }
    }
}
