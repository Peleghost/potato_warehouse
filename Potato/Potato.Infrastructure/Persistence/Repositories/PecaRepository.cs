using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;
using System.Data.SQLite;

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

                int pecaId;

                var cmd = _connection.CreateCommand();
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    pecaId = Convert.ToInt32(cmd.ExecuteScalar());
                }

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

                string query = @"SELECT Peca.id as Id, Peca.nome as Nome, preco, categoria, quantidade, Armazen.nome as armazen FROM Peca " +

                    "INNER JOIN PecaEstoque ON pecaId=Peca.id " +

                    "INNER JOIN Armazen ON Armazen.id=PecaEstoque.armazenId " +

                    $"WHERE Peca.id={id}";

                var peca = _connection.Query<Peca>(query, commandType: CommandType.Text);

                _connection.Close();
                return peca;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Peca>();
            }

        }

        public void VenderPeca(int pecaId, int quantidade)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open(); 
                }

                string sql = $"UPDATE PecaEstoque SET quantidade = quantidade -{quantidade} " +
                    
                    $"WHERE pecaId={pecaId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ReporPeca(int pecaId, int quantidade)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE PecaEstoque SET quantidade = quantidade +{quantidade} " +

                    $"WHERE pecaId={pecaId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditarPeca(Peca peca, int quantidade)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string pecaEstoqueSql = $"UPDATE PecaEstoque SET quantidade = {quantidade} " +
                    $"WHERE pecaId = {peca.Id}";

                string pecaSql = $"UPDATE Peca SET nome = '{peca.Nome}', preco = {peca.Preco}, categoria = '{peca.Categoria}' " +
                    $"WHERE id = {peca.Id}";

                _connection.Execute(pecaEstoqueSql, commandType: CommandType.Text);
                _connection.Execute(pecaSql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletePeca(Peca peca)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connection.ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand deletePecaCommand = new SQLiteCommand($"DELETE FROM PecaEstoque WHERE PecaId = {peca.Id};", connection))
                    {
                        deletePecaCommand.ExecuteNonQuery();
                    }

                    // Excluir a Peca com ID 1 (a exclusão em cascata também removerá o registro correspondente em PecaEstoque)
                    using (SQLiteCommand deletePecaCommand = new SQLiteCommand($"DELETE FROM Peca WHERE id = {peca.Id};", connection))
                    {
                        deletePecaCommand.ExecuteNonQuery();
                    }
                    _connection.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

    }


}

