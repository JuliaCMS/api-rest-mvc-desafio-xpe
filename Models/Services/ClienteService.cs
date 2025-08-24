using mvc_rest_api.Models.Entities;
using mvc_rest_api.Models.Repositories.Implementations;
using mvc_rest_api.Models.Repositories.Interfaces;

namespace mvc_rest_api.Models.Services
{
    public class ClienteService(IClienteRepository _repository)
    {
        public Task<IEnumerable<Cliente>> ListarTodosAsync()
        {
            return _repository.FindAllAsync();
        }

        public Task<Cliente> ObterPorIdAsync(int id)
        {
            return _repository.FindByIdAsync(id);
        }

        public Task<IEnumerable<Cliente>> BuscarPorNomeAsync(string nome)
        {
            return _repository.FindByNameAsync(nome);
        }

        public Task CriarAsync(Cliente cliente)
        {
            return _repository.AddAsync(cliente);
        }

        public Task AtualizarAsync(Cliente cliente)
        {
            return _repository.UpdateAsync(cliente);
        }

        public Task DeletarAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<int> ContarAsync()
        {
            return _repository.CountAsync();
        }
    }
}
