using Posterr.Shared.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Posts.Core.Repositories
{
    public interface IPostRepository
    {
        public Task<Guid> CreatePostAsync(Post model);
    }
}
