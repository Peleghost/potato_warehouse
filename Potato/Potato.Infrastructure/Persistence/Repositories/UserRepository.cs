using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;

        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<User> GetUserById(int id)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            string query = $"SELECT * FROM User WHERE id={id}";

            var user = _connection.Query<User>(query, commandType: CommandType.Text);

            return user;
        }

    }
}
