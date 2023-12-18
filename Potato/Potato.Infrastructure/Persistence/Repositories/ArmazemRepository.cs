using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class ArmazemRepository : IArmazemRepository
    {
        private readonly IDbConnection _connection;

        public ArmazemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int CriarArmazem()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                var armazem = new Armazem();

                string sql = "INSERT INTO Armazen(nome, endereco) " +
                    $"VALUES('{armazem.Nome}', '{armazem.Endereco}');" +
                    $"SELECT last_insert_rowid();";

                var armazemId = 0;

                var cmd = _connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                armazemId = Convert.ToInt32(cmd.ExecuteScalar());

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();

                return armazemId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Armazem> GetArmazem()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = @"SELECT * FROM Armazen";

                var armazens = _connection.Query<Armazem>(query, commandType: CommandType.Text);

                _connection.Close();
                return armazens;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Armazem>();
            }
        }
    }
}
