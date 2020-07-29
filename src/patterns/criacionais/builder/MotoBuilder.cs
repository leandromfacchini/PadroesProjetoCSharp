namespace builder
{
    public class MotoBuilder : VeiculoBuilder
    {

        public MotoBuilder()
        {
            _veiculo = new Veiculo("MotoCicleta");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "150 CC";

        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";

        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "0";
        }

    }
}