public partial class Program
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
