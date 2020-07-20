using System;

namespace interfaces
{

    public interface IEditar
    {
        void Editar();
    }

    public interface IImprimir
    {
        void Imprimir();
    }

    public abstract class Arquivo
    {
        protected int _tamArquivo;
        protected string _descricao;

        public int Tamanho
        {
            get { return _tamArquivo; }
            set { _tamArquivo = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo " + _descricao);
        }

    }
    public class MP3 : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Tocando arquivo MP3 " + _descricao);
        }
    }

    public class Foto : Arquivo, IImprimir, IEditar
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando foto " + _descricao);
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo foto " + _descricao);
        }

        public void Editar()
        {
            Console.WriteLine("Editando foto " + _descricao);
        }
    }

    public class Documento : Arquivo, IEditar, IImprimir
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Abrindo documento " + _descricao);
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo documento " + _descricao);
        }

        public void Editar()
        {
            Console.WriteLine("Editando documento " + _descricao);
        }
    }
}