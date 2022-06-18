using Inceliyo.Domain.Entities;
using Inceliyo.Infrastructure.Services;
using Inceliyo.Persistence.Contexts;
using Inceliyo.Persistence.Repositories;
using Inceliyo.Persistence.UnitOfWorks;

namespace TestGenericService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var _context = new AppDbContext();
            var _gp = new GenericRepository<Category>(_context);
            var _uow = new UnitOfWorks(_context);
            
            GenericService<Category> gs = new GenericService<Category>(_gp, _uow);





            var resultGetAllAsync = await gs.GetAllAsync();
            Console.WriteLine($"GetAllAsync: {resultGetAllAsync.FirstOrDefault().Name}\n\n");

            var resultGetByIdAsync = await gs.GetByIdAsync(Guid.Parse("FFBF052B-833E-47D8-925F-9CBE83623347"));
            Console.WriteLine($"GetByIdAsync: {resultGetByIdAsync.Name}\n\n");

            var resultWhere = gs.Where(x => x.Name == "Category 272128").ToList();
            Console.WriteLine($"Where: {resultWhere[0].Name}\n\n");

            var resultAnyAsync = await gs.AnyAsync(x => x.Name == "Category 272128");
            Console.WriteLine($"AnyAsync: {resultAnyAsync}\n\n");

            var AddCategoryItem = new Category()
            {
                Name = "Category " + DateTime.Now.ToString("dd/HH:mm"),
                ParentId = Guid.NewGuid()
            };
            await gs.AddAsync(AddCategoryItem);
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

            await gs.AddRangeAsync(AddRangeCategoriesItems);
            Console.WriteLine($"AddRangeAsync: DONE \n\n");


            Console.WriteLine("press key to update data \n\n");
            Console.ReadLine();

            AddCategoryItem.Name = "New_" + AddCategoryItem.Name;
           await gs.UpdateAsync(AddCategoryItem);
            Console.WriteLine($"UpdateAsync: DONE \n\n");

            Console.WriteLine("press key to delete added data \n\n");
            Console.ReadLine();

            await gs.RemoveAsync(AddCategoryItem);
            Console.WriteLine($"RemoveAsync: DONE \n\n");

            await gs.RemoveRangeAsync(AddRangeCategoriesItems);
            Console.WriteLine($"RemoveRangeAsync: DONE \n\n");

            Console.ReadLine();
        }
    }
}