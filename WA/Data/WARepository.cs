using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }
        public void AddOrder(Order newOrder)
        {
            // convert new products to lookup of product 
            // we don't want every order to automatically try and add 
            // the same product to the db multiple times.
            foreach (var item in newOrder.Items)
            {
                //the products visible to users should exist in the database anyway
                item.Product = _ctx.Products.Find(item.Product.Id);
            }

            AddEntity(newOrder);
        }
        public IEnumerable<Order> GetAllOrders(bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(oi => oi.Product)
                .ToList();
            }
            else
            {
                return _ctx.Orders
                .ToList();
            }
        }
        public Order GetOrderById(string username, int id)
        {
            return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id && o.User.UserName == username)
                .FirstOrDefault();
        }

        public IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                    .Where(o=>o.User.UserName == username)
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
            {
                return _ctx.Orders
                    .Where(o => o.User.UserName == username)
                    .ToList();
            }
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

        public Product GetProductsById(int Id)
        {
            return _ctx.Products
                .Where(p => p.Id == Id)
                .First();
        }
        public IEnumerable<Product> GetProductsByName(string name)
        {
            return _ctx.Products
                .Where(p => p.Title == name)
                .ToList();
        }
        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
        
    }
}
