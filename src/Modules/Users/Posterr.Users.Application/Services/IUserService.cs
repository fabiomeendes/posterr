using Posterr.Users.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Application.Services
{
    public interface IUserService
    {
        public Task<UserViewModel?> GetByIdAsync(Guid id);
    }
}
