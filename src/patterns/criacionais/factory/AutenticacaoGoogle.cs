using System;

namespace factory
{
    //Produto Concreto
    public class AutenticacaoGoogle : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google");
        }
    }
}