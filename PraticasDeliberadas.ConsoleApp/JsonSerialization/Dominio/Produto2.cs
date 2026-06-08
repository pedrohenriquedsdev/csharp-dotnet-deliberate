namespace PraticasDeliberadas.ConsoleApp.JsonSerialization.Dominio;

public class Produto2
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto2(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto2()
    {

    }
}
