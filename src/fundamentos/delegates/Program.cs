using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente chefe = new Gerente();

            chefe.Trabalhar("Sistema de atendimento ao usuário");

            Console.ReadKey();
        }
    }
}
