using Posterr.Posts.Application.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Posts.Application.Services
{
    public interface IPostService
    {
        public Task<Guid> CreatePostAsync(CreatePostInputModel model);
    }
}
