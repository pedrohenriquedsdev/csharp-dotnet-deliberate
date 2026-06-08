namespace PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios.Base;

public class Funcionario
{
    public virtual decimal CalcularSalario()
    {
        Console.WriteLine("Realize a fórmula para obter salário");
        return 0; //retorno default
    }
}
