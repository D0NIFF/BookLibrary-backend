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

    public async Task<List<User>> Get()
    {
        return await _dbContext.Users
            .Take(1)
            .AsNoTracking()
            .ToListAsync();
    }
}

