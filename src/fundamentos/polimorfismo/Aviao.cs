using System;

namespace polimorfismo
{
    public class Aviao : MeioTransporte
    {
        public override void Mover()
        {
            Console.WriteLine(Modelo + " voando...");
        }
    }
}