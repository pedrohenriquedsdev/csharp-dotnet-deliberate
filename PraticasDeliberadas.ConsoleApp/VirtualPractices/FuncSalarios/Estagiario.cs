using System;
using PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios.Base;

namespace PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios;

public class Estagiario : Funcionario
{
    protected decimal salario = 120;
    protected decimal descontos = 100;
    public override decimal CalcularSalario()
    {
        return salario - descontos;
    }
}
