using System;

namespace builder
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            // //cria produto
            // var carro = new Veiculo("Carro Passeio");
            // carro["motor"] = "1.6";
            // carro["pneus"] = "4";
            // carro["portas"] = "4";

            // carro.Mostrar();

            // //cria produto
            // var moto = new Veiculo("Motocicleta");
            // moto["motor"] = "150cc";
            // moto["pneus"] = "2";
            // moto["portas"] = "0";

            // moto.Mostrar();

            VeiculoBuilder builder;
            var director = new Director();

            builder = new CarroBuilder();
            director.Contruct(builder);
            builder.Veiculo.Mostrar();

            builder = new MotoBuilder();
            director.Contruct(builder);
            builder.Veiculo.Mostrar();

            Console.ReadKey();
        }
    }
}
