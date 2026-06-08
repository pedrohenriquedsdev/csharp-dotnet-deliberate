public partial class Program
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }

        public Produto(string nome, decimal v)
        {
            Nome = nome;
        }

        public Produto(string nome, decimal v, int v1) : this(nome, v)
        {
        }
    }
}
