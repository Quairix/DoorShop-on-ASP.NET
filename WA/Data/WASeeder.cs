using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.Data
{
    public class WASeeder
    {
        private readonly WAContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<StoreUser> _userManager;

        public WASeeder(WAContext ctx, 
            IHostingEnvironment hosting,
            UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _hosting = hosting;
            _userManager = userManager;
        }
        public async Task Seed()
        {
            _ctx.Database.EnsureCreated();
            
            var user = await _userManager.FindByEmailAsync("quarix@wa.com");

            if (user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Dmitriy",
                    LastName = "Shapovalov",
                    UserName = "quarix@wa.com",
                    Email = "quarix@wa.com"
                };
                var result = await _userManager.CreateAsync(user, "somepass!");
                if (result == IdentityResult.Success)
                {
                    throw new InvalidOperationException("Failed to create default user");
                }
            }
            var user1 = await _userManager.FindByEmailAsync("quarix1@wa.com");

            if (user1 == null)
            {
                user1 = new StoreUser()
                {
                    FirstName = "Dmitriy",
                    LastName = "Shapovalov",
                    UserName = "quarix1",
                    Email = "quarix@wa.com"
                };
                var result1 = await _userManager.CreateAsync(user, "12345678");
                if (result1 == IdentityResult.Success)
                {
                    throw new InvalidOperationException("Failed to create default user");
                }
            }
            if (!_ctx.Products.Any())
            {
                //Need to create sample data
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "12345",
                    User = user,
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    }
                };
                _ctx.Orders.Add(order);
                _ctx.SaveChanges();
            }
        }
    }
}
