using Posterr.Shared.Core.Entities;

namespace Posterr.Posts.Core.Repositories
{
    public interface IPostRepository
    {
        public Task<Guid> CreateAsync(Post model);

        Task<Post?> GetByIdAsync(Guid id);
    }
}
