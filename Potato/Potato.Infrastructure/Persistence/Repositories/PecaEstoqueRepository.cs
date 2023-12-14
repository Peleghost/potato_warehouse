using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class PecaEstoqueRepository : IPecaEstoqueRepository
    {
        private readonly IDbConnection _connection;

        public PecaEstoqueRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CriarPecaEstoque(PecaEstoque pecaEstoque)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO PecaEstoque(pecaId, armazenId, quantidade)" +
                    $"VALUES ({pecaEstoque.PecaId}, {pecaEstoque.ArmazenId}, {pecaEstoque.Quantidade})";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
