using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string DateJoined { get; set; }
        public int PostsCount { get; set; }
    }
}
