using Posterr.Shared.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Shared.Core.Entities
{
    [Table("Posts")]
    public class Post : BaseEntity
    {
        public Post(string content, Guid userId, PostType postType, Guid? postReferenceId) : base()
        {
            Content = content;
            UserId = userId;
            PostType = postType;
            PostReferenceId = postReferenceId;
        }

        public string? Content { get; private set; }
        public Guid UserId { get; private set; }
        public PostType PostType { get; private set; }
        public User User { get; set; }
        public Guid? PostReferenceId { get; private set; }
        public Post? PostReference { get; set; }
    }
}
