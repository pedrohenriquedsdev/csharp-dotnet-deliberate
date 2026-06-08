namespace PraticasDeliberadas.ConsoleApp;

public interface IRepositorio<T> where T : EntidadeBase //todos que implementam essa Interface devem possuir implmentações de todos os seus comportamentos
{
    void Cadastrar(T entidade);
    List<T> SelecionarTodos();
    T? SelecionarPorId(string id);

}
