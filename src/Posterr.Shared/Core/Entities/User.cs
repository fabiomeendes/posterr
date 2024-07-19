using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Shared.Core.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
