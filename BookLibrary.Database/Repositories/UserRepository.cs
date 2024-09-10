using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Database.Repositories;

public class UserRepository
{
    private readonly BookLibraryDBContext _dbContext;

    public UserRepository(BookLibraryDBContext dbContext)
    {
        _dbContext = dbContext; 
    }

    public async Task<List<UserEntity>> GetAll(int page, int pageCount)
    {
        var users = await _dbContext
            .Users
            .AsNoTracking()
            .Skip((page - 1) * pageCount)
            .Take(pageCount)
            .ToListAsync();
        return users;
    }

    public async Task<List<UserEntity>> Get(Guid id)
    {
        var user = await _dbContext
            .Users
            .Where(u => u.Id == id)
            .ToListAsync();
        return user;
    }

    public async Task<Guid> Add(User user)
    {
        var userEntity = new UserEntity
        {
            Id = user.Id,
            Nickname = user.Nickname,
            Email = user.Email,
            PasswordHash = user.PasswordHash
        };

        await _dbContext.Users.AddAsync(userEntity);
        await _dbContext.SaveChangesAsync();

        return userEntity.Id;
    }


}

