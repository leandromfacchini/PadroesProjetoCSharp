using System;

namespace heranca
{
    public class Aluno : Pessoa
    {
        public int Matricula;
        public void Estudar()
        {
            Console.WriteLine(Nome + " estuda");
        }
    }
}