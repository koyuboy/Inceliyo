using Inceliyo.Application.Interfaces.Repositories;
using Inceliyo.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Persistence.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly AppDbContext _context;

        public UnitOfWorks(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
