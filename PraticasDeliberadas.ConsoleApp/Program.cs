using PraticasDeliberadas.ConsoleApp.VirtualPractices;
using PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios;

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
        Desenvolvedor desenvolvedor = new Desenvolvedor();
        Gerente gerente = new Gerente();
        Estagiario estagiario = new Estagiario();
        Console.WriteLine(desenvolvedor.CalcularSalario());
        Console.WriteLine(gerente.CalcularSalario());
        Console.WriteLine(estagiario.CalcularSalario());
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
