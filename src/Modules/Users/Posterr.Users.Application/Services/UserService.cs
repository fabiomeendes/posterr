using Posterr.Users.Application.ViewModels;
using Posterr.Users.Core.Repositories;

namespace Posterr.Users.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserViewModel> GetByIdAsync(Guid id)
        {
            var user = await _repository.GetByIdAsync(id);

            return new UserViewModel()
            {
                Id = user.Id,
                Username = user.Username,
                DateJoined = user.CreatedAt.ToString("MMMM dd, yyyy"),
                PostsCount = user.Posts.Count,
            };
        }
    }
}
