using System;

namespace classes_abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("Acer");
            notebook.portaUm = new IPhone();
            notebook.portaDois = new Teclado();

            Console.ReadKey();
        }
    }
}
