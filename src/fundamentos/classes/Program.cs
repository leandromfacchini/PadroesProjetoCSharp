using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, resultado;
            x = 10;
            y = 20;

            Calculadora calculadora = new Calculadora();
            resultado = calculadora.Somar(x, y);

            Console.WriteLine($"A soma de {x} + {y} = {resultado}");
            Console.ReadLine();
        }

       
    }
}
