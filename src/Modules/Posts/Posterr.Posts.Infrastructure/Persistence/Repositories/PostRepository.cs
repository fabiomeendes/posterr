using Microsoft.EntityFrameworkCore;
using Posterr.Posts.Core.Repositories;
using Posterr.Shared.Core.Entities;
using Posterr.Shared.Infra;

namespace Posterr.Posts.Infrastructure.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateAsync(Post model)
        {
            await _context.Posts.AddAsync(model);

            await _context.SaveChangesAsync();

            return model.Id;
        }

        public async Task<Post?> GetByIdAsync(Guid id)
        {
            var post = await _context.Posts.SingleOrDefaultAsync(u => u.Id == id);

            return post;
        }
    }
}
