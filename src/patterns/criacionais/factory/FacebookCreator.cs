namespace factory
{
    //Concrete creator
    public class FacebookCreator : Creator
    {
        public override Autenticacao CreateInstace()
        {
            return new AutenticacaoFacebook();
        }
    }
}