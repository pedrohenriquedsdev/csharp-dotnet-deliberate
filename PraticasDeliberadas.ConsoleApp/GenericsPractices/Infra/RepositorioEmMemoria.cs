using PraticasDeliberadas.ConsoleApp;

public partial class Program
{
    public class RepositorioEmMemoria<T> : IRepositorio<T> where T : EntidadeBase
    {
        private List<T> registros = new List<T>(); // Generic list for any type

        public void Cadastrar(T entidade)
        {
            registros.Add(entidade);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public T? SelecionarPorId(string id)
        {
            return registros.FirstOrDefault(x => x.Id == id);
        }
    }
}
