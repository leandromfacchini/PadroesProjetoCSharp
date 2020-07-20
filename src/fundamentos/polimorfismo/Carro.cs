using System;

namespace polimorfismo
{
    public class Carro : MeioTransporte
    {
        public override void Mover()
        {
            Console.WriteLine(Modelo + " andando");
        }
    }
}