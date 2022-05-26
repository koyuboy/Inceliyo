using Inceliyo.Domain.Entities;
using Inceliyo.Persistence.Contexts;
using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            AppDbContext context = new AppDbContext();

            context.Database.EnsureCreated();



            context.Categories.AddAsync(new Category()
            {
                Name = "Category 1",
                ParentId = Guid.NewGuid()
            });

            context.SaveChangesAsync();

            var category = context.Categories.ToList();

            Console.WriteLine(category[0].Id);
            Console.WriteLine(category[0].Name);
            Console.WriteLine(category[0].ParentId);




            Console.ReadLine();


        }
    }
}
