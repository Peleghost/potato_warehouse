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

        public int CriarPeca(Peca peca)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO Peca(nome, preco, categoria) " +

                    $"VALUES('{peca.Nome}', '{peca.Preco}', '{peca.Categoria}');" +

                    $"SELECT last_insert_rowid();";

                int pecaId = 0;

                var cmd = _connection.CreateCommand();
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    pecaId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //_connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();

                return pecaId;
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

                string query = @"SELECT Peca.id as Id, Peca.nome as Nome, preco, categoria, quantidade, Armazen.nome as armazen FROM Peca " +

                    "INNER JOIN PecaEstoque ON pecaId=Peca.id " +

                    "INNER JOIN Armazen ON Armazen.id=PecaEstoque.armazenId";

                var pecas = _connection.Query<Peca>(query, commandType: CommandType.Text);

                _connection.Close();
                return pecas;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Peca>();
            }
        }

        public IEnumerable<Peca> GetPecasByNomeOuCategoria(string criterio, string busca)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = @"SELECT Peca.id as Id, Peca.nome as Nome, preco, categoria, quantidade, Armazen.nome as armazen FROM Peca " +

                    "INNER JOIN PecaEstoque ON pecaId=Peca.id " +

                    "INNER JOIN Armazen ON Armazen.id=PecaEstoque.armazenId " +

                    $"WHERE Peca.{criterio} LIKE '%{busca}%'";

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

