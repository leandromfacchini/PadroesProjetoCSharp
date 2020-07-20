namespace classes_abstratas
{
    public class Notebook
    {
        private string _nome;

        public string nome
        {
            get { return _nome; }
        }

        public Notebook(string nome)
        {
            this._nome = nome;
        }

        public USB portaUm { get; set; }
        public USB portaDois { get; set; }
        public USB portaTres { get; set; }
    }

    public abstract class USB
    {
        public abstract void plugar();
    }

    public class IPhone : USB
    {
        public override void plugar()
        {

        }
    }

    public class Mouse : USB
    {
        public override void plugar()
        {

        }
    }

    public class Teclado : USB
    {
        public override void plugar()
        {

        }
    }
}