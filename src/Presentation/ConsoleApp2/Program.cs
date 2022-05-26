using Inceliyo.Domain.Entities;
using Inceliyo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            context.Database.EnsureCreated();



            context.Categories.AddAsync(new Category()
            {
                Name = "Category 4",
                ParentId = Guid.NewGuid()
            });

            context.SaveChangesAsync();

            var categories = await context.Categories.ToListAsync();
            
            foreach (var category in categories)
            {
                Console.WriteLine(category.Id);
                Console.WriteLine(category.Name);
                Console.WriteLine(category.ParentId);
            }

            




            Console.ReadLine();
        }
    }
}
