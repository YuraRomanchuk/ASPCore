using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Persistance.Contexts;
using WebApplication2.Repositories;

namespace WebApplication2.Persistance.Repositories
{
    public class UnitOfWork : BaseRepository, IUnitOfWork
    {

        public UnitOfWork(AppDbContext context) : base(context) { }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
