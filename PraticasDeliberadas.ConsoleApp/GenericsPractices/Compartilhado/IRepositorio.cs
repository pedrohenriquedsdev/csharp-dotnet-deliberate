namespace PraticasDeliberadas.ConsoleApp;

public interface IRepositorio<T> where T : EntidadeBase
{
    void Cadastrar(T entidade);
    List<T> SelecionarTodos();
    T? SelecionarPorId(string id);

}
