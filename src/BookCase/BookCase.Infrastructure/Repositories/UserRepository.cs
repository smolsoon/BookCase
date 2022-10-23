using AutoMapper;
using BookCase.Core.Entities;
using BookCase.Core.Repositories;
using BookCase.Infrastructure.DTO;
using BookCase.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace BookCase.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DbSet<User> _users;
    
    public UserRepository(DbSet<User> users)
    {
        _users = users;
    }

    public async Task<User> GetUserAsync(Guid id)
    {
        var user = await _users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
        {
            throw new NoExistingUserException(id);
        }

        return user;
    }

    public async Task<User> GetUserAsync(string email)
    {
        var user = await _users.FirstOrDefaultAsync(x => x.Email == email);
        if (user == null)
        {
            throw new NoExistingUserException(email);
        }

        return user;
    }
    

    public Task<IEnumerable<User>> BrowseAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}