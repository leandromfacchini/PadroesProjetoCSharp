using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Leandro";
            aluno.Matricula = 123;

            aluno.Estudar();
            aluno.Dormir();

            Funcionario func = new Funcionario();
            func.Nome = "Leandro 2";
            func.Departamento = "Analista de Sistemas";

            func.Trabalhar();
            func.Dormir();

            Console.ReadKey();
        }
    }
}
