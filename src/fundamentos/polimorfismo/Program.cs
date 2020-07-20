using System;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MeioTransporte carro = new Carro();
            //carro.Marca = "Volkswagem";
            carro.Modelo = "Golf";
            carro.Mover();

            MeioTransporte aviao = new Aviao();
            aviao.Modelo = "F22";
            aviao.Mover();

            Console.ReadKey();

        }
    }
}
