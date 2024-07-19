using Posterr.Shared.Core.Entities;
using Posterr.Shared.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Posts.Application.InputModels
{
    public class CreatePostInputModel
    {
        public string Content { get; set; }
        public PostType PostType { get; set; }
        public Guid UserId { get; set; }

        public Post ToEntity()
            => new Post(Content, UserId);
    }
}
