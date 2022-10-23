using BookCase.Core.Entities;

namespace BookCase.Core.Repositories;

public interface IUserRepository
{
    Task<User> GetUserAsync(Guid id);
    Task<User> GetUserAsync(string email);
    Task<IEnumerable<User>> BrowseAsync();
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(User user);
}