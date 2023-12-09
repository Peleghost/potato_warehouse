using Dapper;
using Microsoft.EntityFrameworkCore;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class PecaRepository : IPecaRepository
    {

        private readonly IDbConnection _connection;

        public PecaRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public void CriarPeca(Peca peca)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO Peca(nome, preco, categoria) " +
                    $"VALUES('{peca.Nome}', '{peca.Preco}', '{peca.Categoria}')";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<Peca> GetPecas()
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                const string query = "SELECT * FROM Peca";

                var pecas = _connection.Query<Peca>(query, commandType: CommandType.Text);

                _connection.Close();
                return pecas;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Peca>();
            }
        }

        public IEnumerable<Peca> GetPecasByCategoria(string categoria)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = $"SELECT * FROM Peca WHERE categoria LIKE '%{categoria}%'";

                var pecas = _connection.Query<Peca>(query, commandType: CommandType.Text);

                _connection.Close();
                return pecas;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Peca>();
            }

        }

        public IEnumerable<Peca> GetPecaById(int id)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = $"SELECT * FROM Peca WHERE id='{id}'";

                var peca = _connection.Query<Peca>(query, commandType: CommandType.Text);

                _connection.Close();
                return peca;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Peca>();
            }

        }

        public void DeleteFromDb(Peca peca)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"DELETE FROM Peca WHERE id='{peca.Id}'";

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

