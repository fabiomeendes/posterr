using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Core.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(14)]
        public string Username { get; set; }
    }
}
