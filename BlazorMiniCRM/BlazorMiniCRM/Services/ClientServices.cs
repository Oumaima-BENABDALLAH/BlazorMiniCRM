using BlazorMiniCRM.Data;
using BlazorMiniCRM.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMiniCRM.Services
{
    public class ClientServices
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<BlazorMiniCRM.Shared.Models.Client>> GetClientsAsync()
        {
            return await _dbContext.Clients.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<BlazorMiniCRM.Shared.Models.Client?> GetClientByIdAsync(int id)
        {
            return await _dbContext.Clients
                                   .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddClientAsync(BlazorMiniCRM.Shared.Models.Client client)
        {
            _dbContext.Clients.Add(client);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(BlazorMiniCRM.Shared.Models.Client client)
        {
            _dbContext.Clients.Update(client);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(int id)
        {
            var clientToDelete = await _dbContext.Clients.FindAsync(id);
            if (clientToDelete != null)
            {
                _dbContext.Clients.Remove(clientToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task<int> GetTotalClientsCountAsync()
        {
            return await _dbContext.Clients.CountAsync();
        }
    }
}