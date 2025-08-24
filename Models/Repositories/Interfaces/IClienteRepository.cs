using mvc_rest_api.Models.Entities;

namespace mvc_rest_api.Models.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> FindAllAsync();

        Task<Cliente> FindByIdAsync(int id);

        Task<IEnumerable<Cliente>> FindByNameAsync(string nome);

        Task<int> CountAsync();

        Task AddAsync(Cliente cliente);

        Task UpdateAsync(Cliente cliente);

        Task DeleteAsync(int id);
    }
}
