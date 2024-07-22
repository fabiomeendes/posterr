using Posterr.Posts.Application.Helpers;
using Posterr.Posts.Application.InputModels;
using Posterr.Posts.Core.Repositories;
using Posterr.Shared.Core.Enums;

namespace Posterr.Posts.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> CreatePostAsync(CreatePostInputModel post)
        {
            if (post.PostReferenceId.HasValue)
            {
                var originalPost = await _repository.GetByIdAsync(post.PostReferenceId.Value);

                if (!post.CanPost(originalPost))
                {
                    throw new InvalidOperationException("Cannot post this type of post!");
                }
            }

            var entity = post.ToEntity();

            return await _repository.CreateAsync(entity);
        }
    }
}
