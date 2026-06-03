using System;

namespace PraticasDeliberadas.ConsoleApp;

public abstract class TelaBase<T> where T : EntidadeBase
{
    protected IRepositorio<T> repositorio;

    public TelaBase(IRepositorio<T> repositorio)
    {
        this.repositorio = repositorio;
    }

    public void ListarRegistros() // ATENTAR-SE AO COMPORTAMENTO DO "<T>" NESSE CONTEXTO
    {
        List<T> registros = repositorio.SelecionarTodos();

        foreach (T registro in registros)
        {
            Console.WriteLine(registro.Id);
        }
    }
}
