using Microsoft.EntityFrameworkCore;
using Posterr.Shared.Core.Entities;
using Posterr.Shared.Infra;
using Posterr.Users.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await _context.Users.Include(x => x.Posts).SingleOrDefaultAsync(u => u.Id == id);

            return user;
        }
    }
}
