using Inceliyo.Domain.Entities;
using Inceliyo.Persistence.Contexts;
using Inceliyo.Persistence.Repositories;

namespace TestGenericRepository
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            GenericRepository<Category> gp = new GenericRepository<Category>(new AppDbContext());

            

            var resultGetAll = gp.GetAll().ToList();
            Console.WriteLine($"GetAll: {resultGetAll[0].Name}\n\n");

            var resultGetByIdAsync = await gp.GetByIdAsync(Guid.Parse("FFBF052B-833E-47D8-925F-9CBE83623347"));
            Console.WriteLine($"GetByIdAsync: {resultGetByIdAsync.Name}\n\n");

            var resultWhere = gp.Where(x=> x.Name == "Category 272128").ToList();
            Console.WriteLine($"Where: {resultWhere[0].Name}\n\n");

            var resultAnyAsync = await gp.AnyAsync(x => x.Name == "Category 272128");
            Console.WriteLine($"AnyAsync: {resultAnyAsync}\n\n");

            var AddCategoryItem = new Category()
            {
                Name = "Category " + DateTime.Now.ToString("dd/HH:mm"),
                ParentId = Guid.NewGuid()
            };
            await gp.AddAsync(AddCategoryItem);
            Console.WriteLine($"AddAsync: DONE \n\n");


            List<Category> AddRangeCategoriesItems = new List<Category>(); ;
            AddRangeCategoriesItems.Add(new Category()
            {
                Name = "CategoryRange " + DateTime.Now.ToString("dd/HH:mm"),
                ParentId = Guid.NewGuid()
            });
            AddRangeCategoriesItems.Add(new Category()
            {
                Name = "CategoryRange " + DateTime.Now.ToString("dd/HH:mm"),
                ParentId = Guid.NewGuid()
            });

            await gp.AddRangeAsync(AddRangeCategoriesItems);
            Console.WriteLine($"AddRangeAsync: DONE \n\n");


            Console.WriteLine("press key to update data \n\n");
            Console.ReadLine();

            AddCategoryItem.Name = "New_" + AddCategoryItem.Name;
            gp.Update(AddCategoryItem);
            Console.WriteLine($"Update: DONE \n\n");

            Console.WriteLine("press key to delete added data \n\n");
            Console.ReadLine();

            gp.Remove(AddCategoryItem);
            Console.WriteLine($"Remove: DONE \n\n");

            gp.RemoveRange(AddRangeCategoriesItems);
            Console.WriteLine($"RemoveRange: DONE \n\n");

            Console.ReadLine();
        }
    }
}