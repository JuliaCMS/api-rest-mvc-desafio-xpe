using Microsoft.EntityFrameworkCore;
using mvc_rest_api.Models.Repositories.Interfaces;
using mvc_rest_api.Models.Repositories.DataContext;
using mvc_rest_api.Models.Entities;

namespace mvc_rest_api.Models.Repositories.Implementations
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext.DataContext _context;

        public ClienteRepository(DataContext.DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> FindAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> FindByNameAsync(string nome)
        {
            return await _context.Clientes
                .Where(c => c.Nome.Contains(nome))
                .ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Clientes.CountAsync();
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
