using System;

namespace encapsulamento
{

    public class Bateria
    {

    }

    public class Motor
    {

    }

    public class SuperBateria : Bateria
    {

    }

    public class Carro
    {
        private Motor _motor;
        private Bateria _bateria;
        public int numeroPneus()
        {
            return 4;
        }

        private string _nome;
        public string nome
        {
            get { return _nome; }
        }

        private void ignicao()
        {
            Console.WriteLine("Ignicao do carro ...");
        }

        public Carro(string nome)
        {
            Console.WriteLine("Criando objeto carro...");
            _motor = new Motor();
            _bateria = new SuperBateria();
            this._nome = nome;
        }

        public void abastecer()
        {
            Console.WriteLine("Abastecendo carro ...");
        }

        public void ligar()
        {
            ignicao();

            Console.WriteLine("Ligando carro...");
        }

        public void mover()
        {
            Console.WriteLine("Movendo carro ...");
        }
    }
}