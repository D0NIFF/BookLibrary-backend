using BookLibrary.Core.Models;

namespace BookLibrary.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<Guid> Create(User user);
        Task<Guid> Delete(Guid id);
        Task<List<User>> GetById(Guid id);
        Task<List<User>> GetAll(int page, int pageCount);
        Task<Guid> Update(Guid id, string nickname, string email, string passwordHash);
    }
}
