using BlazorMiniCRM.Data;
using BlazorMiniCRM.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMiniCRM.Services
{
    public class OrderServices
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _dbContext.Orders
                                   .Include(o => o.Client)
                                   .OrderByDescending(o => o.DateOrder)
                                   .ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            return await _dbContext.Orders
                                   .Include(o => o.Client)
                                   .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddOrderAsync(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _dbContext.Orders.Update(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var orderToDelete = await _dbContext.Orders.FindAsync(id);
            if (orderToDelete != null)
            {
                _dbContext.Orders.Remove(orderToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task<int> GetTotalOrdersCountAsync()
        {
            return await _dbContext.Orders.CountAsync();
        }

        public async Task<decimal> GetTotalOrdersAmountAsync()
        {
            return await _dbContext.Orders.SumAsync(o => o.Montant);
        }

        public async Task<IEnumerable<Order>> GetLatestOrdersAsync(int count = 5)
        {
            return await _dbContext.Orders
                                   .Include(o => o.Client)
                                   .OrderByDescending(o => o.DateOrder)
                                   .Take(count)
                                   .ToListAsync();
        }
    }
}