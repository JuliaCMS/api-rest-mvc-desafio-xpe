using mvc_rest_api.Models.Entities;
using mvc_rest_api.Models.Repositories.Implementations;
using mvc_rest_api.Models.Repositories.Interfaces;

namespace mvc_rest_api.Models.Services
{
    public class ClienteService(IClienteRepository repository)
    {
        public Task<IEnumerable<Cliente>> ListarTodosAsync()
        {
            return repository.FindAllAsync();
        }

        public Task<Cliente> ObterPorIdAsync(int id)
        {
            return repository.FindByIdAsync(id);
        }

        public Task<IEnumerable<Cliente>> BuscarPorNomeAsync(string nome)
        {
            return repository.FindByNameAsync(nome);
        }

        public Task CriarAsync(Cliente cliente)
        {
            return repository.AddAsync(cliente);
        }

        public Task AtualizarAsync(Cliente cliente)
        {
            return repository.UpdateAsync(cliente);
        }

        public Task DeletarAsync(int id)
        {
            return repository.DeleteAsync(id);
        }

        public Task<int> ContarAsync()
        {
            return repository.CountAsync();
        }
    }
}
