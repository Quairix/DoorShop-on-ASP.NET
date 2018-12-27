using System.Collections.Generic;
using WA.Data.Entities;

namespace WA.Data
{
    public interface IWARepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Product> GetProductsByName(string category);
        IEnumerable<Product> GetProductsByPrice(int price);
        IEnumerable<Order> GetAllOrders(bool includeItem);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Product GetProductsById(int Id);
        Order GetOrderById(string username, int id);
        bool SaveAll();
        void AddEntity(object model);
        void AddOrder(Order newOrder);
    }
}