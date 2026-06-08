using System;
using PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios.Base;

namespace PraticasDeliberadas.ConsoleApp.VirtualPractices.FuncSalarios;

public class Gerente : Funcionario
{
    protected decimal salario = 12033;
    protected decimal descontos = 1000;
    public override decimal CalcularSalario()
    {
        return salario - descontos;
    }
}
