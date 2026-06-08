using System.Text.Json;
using PraticasDeliberadas.ConsoleApp.JsonSerialization.Dominio;

public partial class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=========================================");
        Console.WriteLine("🚀 ESPAÇO DE TESTES E PRÁTICA 🚀");
        Console.WriteLine("=========================================");
        Console.ResetColor();


        // ===================================================
        // 2. ESPAÇO PARA SUA TESTAGEM (Escreva seu código aqui)
        // ===================================================


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPraticando Generics\n");
        Console.ResetColor();

        // --- Seu código começa aqui ---

        List<Produto2> produtos = new List<Produto2>
        {
            new Produto2("Arroz", 25.90m, 2),
            new Produto2("Feijão", 8.50m, 3),
            new Produto2("Macarrão", 5.75m, 1)
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        //Serialização
        string json = JsonSerializer.Serialize(produtos, options);

        Console.WriteLine(json);

        //DESserialização
        List<Produto2> produtosDesserializados = JsonSerializer.Deserialize<List<Produto2>>(json)!;

        foreach (Produto2 produto in produtosDesserializados)
        {
            Console.WriteLine($"{produto.Nome} - {produto.Preco} - {produto.Quantidade}");
        }

        // --- Seu código termina aqui ---



        // ===================================================
        // 3. RODAPÉ
        // ===================================================
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n=========================================");
        Console.WriteLine("🎯 Teste finalizado com sucesso!");
        Console.WriteLine("=========================================");
        Console.ResetColor();
        Console.ReadLine(); // Segura a tela aberta
    }
}
