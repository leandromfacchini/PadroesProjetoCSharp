using System;

namespace heranca
{
    public class Funcionario : Pessoa
    {
        public string Departamento;
        public void Trabalhar()
        {
            Console.WriteLine(Nome + " Trabalhando");
        }
    }
}