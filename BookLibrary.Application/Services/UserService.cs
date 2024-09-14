using BookLibrary.Core.Interfaces;
using BookLibrary.Core.Models;

namespace BookLibrary.Application.Services
{

    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAll(int page, int pageSize)
        {
            return await _userRepository.GetAll(page, pageSize);
        }

        public async Task<List<User>> GetById(Guid id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<Guid> Create(User user)
        {
            return await _userRepository.Create(user);
        }

        public async Task<Guid> Update(Guid id, string nickname, string email, string passwordHash)
        {
            return await _userRepository.Update(id, nickname, email, passwordHash);
        }

        public async Task<Guid> Delete(Guid id)
        {
            return await _userRepository.Delete(id);
        }

    }
}
