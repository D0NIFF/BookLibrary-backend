using BookLibrary.Core.Models;

namespace BookLibrary.Application.Services
{
    public interface IUserService
    {
        Task<Guid> Create(User user);
        Task<Guid> Delete(Guid id);
        Task<List<User>> GetAll(int page, int pageSize);
        Task<List<User>> GetById(Guid id);
        Task<Guid> Update(Guid id, string nickname, string email, string passwordHash);
    }
}