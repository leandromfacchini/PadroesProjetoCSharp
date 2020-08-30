namespace factory
{
    public class GoogleCreator : Creator
    {
        public override Autenticacao CreateInstace()
        {
            return new AutenticacaoGoogle();
        }


    }
}