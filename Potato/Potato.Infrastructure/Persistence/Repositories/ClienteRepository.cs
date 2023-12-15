using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly IDbConnection _connection;

        public ClienteRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public int CriarCliente(Cliente cliente)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO Cliente(primeiroNome, sobrenome, cpf, endereco, email, telefone, ativo) " +

                    $"VALUES('{cliente.primeiroNome}', '{cliente.Sobrenome}', '{cliente.Cpf}', '{cliente.Endereco}', '{cliente.Email}' " +
                    $"'{cliente.Telefone}', '{cliente.Ativo}');" +

                    $"SELECT last_insert_rowid();";

                int clienteId;

                var cmd = _connection.CreateCommand();
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    clienteId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                _connection.Close();

                return clienteId;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<Cliente> GetClientes()
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = @"SELECT * FROM Cliente";

                var clientes = _connection.Query<Cliente>(query, commandType: CommandType.Text);

                _connection.Close();
                return clientes;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Cliente>();
            }
        }

        public IEnumerable<Cliente> GetClienteByNome(string nome)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = $"SELECT * FROM Cliente WHERE primeiroNome={nome}";

                var cliente = _connection.Query<Cliente>(query, commandType: CommandType.Text);

                _connection.Close();

                return cliente;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Cliente>();
            }

        }

        //public IEnumerable<Cliente> GetClienteById(int id)
        //{

        //    try
        //    {
        //        if (_connection.State == ConnectionState.Closed)
        //        {
        //            _connection.Open();
        //        }

        //        string query = $"SELECT * FROM Cliente WHERE id='{id}'";

        //        var peca = _connection.Query<Cliente>(query, commandType: CommandType.Text);

        //        _connection.Close();
        //        return peca;
        //    }
        //    catch (Exception)
        //    {
        //        return Enumerable.Empty<Cliente>();
        //    }

        //}

        public void DeleteCliente(Cliente cliente)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"DELETE FROM Cliente WHERE id='{cliente}'";

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
