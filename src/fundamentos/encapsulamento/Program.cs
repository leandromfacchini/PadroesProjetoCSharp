using System;

namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro golf = new Carro("Volksvagem Golf");
            Console.WriteLine(golf.nome);
            golf.ligar();
            golf.mover();
            golf.abastecer();
            golf.mover();


            Console.ReadKey();
        }
    }
}
