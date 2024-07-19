using Microsoft.EntityFrameworkCore;
using Posterr.Posts.Core.Repositories;
using Posterr.Shared.Core.Entities;
using Posterr.Shared.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Posts.Infrastructure.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreatePostAsync(Post model)
        {
            await _context.Posts.AddAsync(model);

            await _context.SaveChangesAsync();

            return model.Id;
        }
    }
}
