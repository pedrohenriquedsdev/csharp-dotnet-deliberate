public class GerenciadorDeItens<T>
{
    private List<T> itens = new List<T>(); // ATRIBUTOS DE CLASSE - NOVA LISTA DO TIPO <T>

    public void Adicionar(T item) // métodos de adição
    {
        itens.Add(item);
    }

    public List<T> SelecionarTodos() // métodos de seleção
    {
        return itens;
    }
}

// GerenciadorDeItens<string> gerenciadorDeStrings = new GerenciadorDeItens<string>();
// gerenciadorDeStrings.Adicionar("First In");
// gerenciadorDeStrings.Adicionar("First Out");

// List<string> itens = gerenciadorDeStrings.SelecionarTodos(); // ARAMAZENA O RETORNO DO MÉTODO

// Console.BackgroundColor = ConsoleColor.Cyan;
// foreach (string item in itens)
// {
//     Console.WriteLine(item);
// }
// Console.ResetColor();

// Console.WriteLine("Digite Enter para continuar");
// Console.ReadLine();