using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo doc = new Documento() { Descricao = "Descricao Teste" };
            MP3 musica = new MP3() { Descricao = "Foo Figthers" };
            Foto foto = new Foto() { Descricao = "Foto da viagem" };

            doc.Abrir();

            musica.Abrir();

            foto.Abrir();
            foto.Editar();
            foto.Imprimir();

            Console.ReadKey();
        }
    }
}
