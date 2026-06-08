using System;
using PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios.Base;

namespace PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios;

public class Desenvolvedor : Funcionario
{
    protected decimal salario = 1233;
    protected decimal descontos = 100;
    public override decimal CalcularSalario()
    {
        return salario - descontos;
    }
}
