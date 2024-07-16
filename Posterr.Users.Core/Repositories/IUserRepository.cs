using Posterr.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posterr.Users.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
    }
}
