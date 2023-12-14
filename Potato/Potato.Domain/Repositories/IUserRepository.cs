using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUserById(int id);
    }
}
