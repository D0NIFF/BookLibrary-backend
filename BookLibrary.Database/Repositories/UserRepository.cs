using BookLibrary.Core.Models;
using BookLibrary.Core.Interfaces;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Database.Repositories;

public class UserRepository : IUserRepository
{
    private readonly BookLibraryDBContext _dbContext;

    public UserRepository(BookLibraryDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetAll(int page, int pageCount)
    {
        var userEntities = await _dbContext
            .Users
            .AsNoTracking()
            .Skip((page - 1) * pageCount)
            .Take(pageCount)
            .ToListAsync();
        var users = userEntities
            .Select(u => User.Create(u.Id, u.Nickname, u.Email, u.PasswordHash).user)
            .ToList();
        return users;
    }

    public async Task<List<User>> GetById(Guid id)
    {
        var userEntity = await _dbContext
            .Users
            .Where(u => u.Id == id)
            .ToListAsync();

        var user = userEntity
            .Select(u => User.Create(u.Id, u.Nickname, u.Email, u.PasswordHash).user)
            .ToList();
        return user;
    }

    public async Task<Guid> Create(User user)
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

    public async Task<Guid> Update(Guid id, string nickname, string email, string passwordHash)
    {
        await _dbContext.Users
            .Where(u => u.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.Nickname, nickname)
                .SetProperty(u => u.Email, email)
                .SetProperty(u => u.PasswordHash, passwordHash));
        return id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _dbContext.Users
            .Where(u => u.Id == id)
            .ExecuteDeleteAsync();
        return id;
    }

}

