using System.Collections.Generic;
using WA.Data.Entities;

namespace WA.Data
{
    public interface IWARepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders();
        Order GerOrderById(int id);
        bool SaveAll();
        void AddEntity(object model);
    }
}