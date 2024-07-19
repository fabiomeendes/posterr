using Posterr.Posts.Application.InputModels;
using Posterr.Posts.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Posts.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> CreatePostAsync(CreatePostInputModel model)
        {
            var entity = model.ToEntity();

            return await _repository.CreatePostAsync(entity);
        }
    }
}
