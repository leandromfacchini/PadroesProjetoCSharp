using System;

namespace delegates
{
    public class Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Funcionário trabalhando, na tarefa: " + tarefa);
        }

    }

    public class Estagiario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Estagiário trabalhando, na tarefa: " + tarefa);
        }
    }

    public class Developer : Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Desenvolvedor trabalhando, na tarefa: " + tarefa);
        }
    }

    public class Arquiteto : Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Arquiteto projetando tarefa: " + tarefa);
        }
    }

    public class Tester : Funcionario
    {
        public void Testando(string tarefa)
        {
            Console.WriteLine("Tester testanto tarefa: " + tarefa);
        }
    }

    public class Gerente
    {
        private Estagiario _estagiario;
        private Developer _developer;
        private Arquiteto _aquiteto;
        private Tester _tester;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _developer = new Developer();
            _aquiteto = new Arquiteto();
            _tester = new Tester();
        }

        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Gerente recebeu a tarefa: " + tarefa);

            _estagiario.Trabalhar(tarefa);
            _aquiteto.Trabalhar(tarefa);
            _developer.Trabalhar(tarefa);
            _tester.Trabalhar(tarefa);

        }
    }
}