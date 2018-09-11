using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.Data
{
    public class WARepository : IWARepository
    {
        private readonly WAContext _ctx;
        private readonly ILogger<WARepository> _logger;

        public WARepository(WAContext ctx, ILogger<WARepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public Order GerOrderById(int id)
        {
            return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _ctx.Orders
                .Include(o=> o.Items)
                .ThenInclude(i => i.Product)
                .ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                _logger.LogInformation("GetAllProducts was called.");
                return _ctx.Products
                    .OrderBy(p => p.Title)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
        }
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                .Where(p => p.Category == category)
                .ToList();
        }
        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
        
    }
}
