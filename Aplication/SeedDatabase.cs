using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplication
{
    public class SeedDatabase
    {
        private readonly ApplicationDbContext _dbContext;
        public SeedDatabase(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle()
        {
            await AddProducts();
        }

        private async Task AddProducts()
        {
            if (await _dbContext.Products.AnyAsync())
            {
                return;
            }

            var products = new List<Product>
            {
                new () { Name = "Iphone", Description = "The Best", Price = 1000 },
                new () { Name = "Samsung", Description = "The Best", Price = 500 },
            };

            _dbContext.AddRange(products);
            await _dbContext.SaveChangesAsync();
        }
    }
}
