using Posterr.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Application.Services
{
    public interface IUserService
    {
        public Task<User?> GetByIdAsync(Guid id);
    }
}
