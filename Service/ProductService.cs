using Database;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class ProductService
    {
        public async void Create(Product product)
        {
            using var context = new AppDbContext();
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public List<Product> ReadAll()
        {
            using var context = new AppDbContext();
            return context.Products.ToList();
        }

        public async void Update(string code, string name)
        {
            using var context = new AppDbContext();
            var product = context.Products.FirstOrDefault(x => x.Code == code);
            if(product != null)
            {
                product.Name = name;
                context.Products.Update(product);
                await context.SaveChangesAsync();
            }            
        }

        public async void Delete(string code)
        {
            using var context = new AppDbContext();
            var product = await context.Products.FirstOrDefaultAsync(x => x.Code == code);
            context.Products.Remove(product);
            await context.SaveChangesAsync();
        }
    }
}