namespace builder
{
    //Concrete Builder
    public class CarroBuilder : VeiculoBuilder
    {

        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro de Passeio");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "1.6";

        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4";

        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "4";
        }

    }
}