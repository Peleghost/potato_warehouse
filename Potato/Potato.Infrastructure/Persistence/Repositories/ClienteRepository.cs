using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;
using System.Net.Mail;

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
                var dataCriacao = cliente.DataCriacao.ToString();

                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO Cliente(primeiroNome, sobrenome, cpf, endereco, email, telefone, ativo, dataCriacao) " +

                    $"VALUES('{cliente.Nome}', '{cliente.Sobrenome}', '{cliente.Cpf}', '{cliente.Endereco}', '{cliente.Email}', " +
                    $"'{cliente.Telefone}', '{cliente.Ativo}', '{dataCriacao}');" +

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

        public string ValidateEmailAddress(string emailAddress)
        {
            try
            {
                new MailAddress(emailAddress);
                return emailAddress;
            }
            catch (FormatException)
            {
                return "Error";
            }
        }

        public bool VerificarClienteEmServico(int clienteId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"SELECT ativo FROM Servico " +

                    $"WHERE clienteId = {clienteId}";

                var result = _connection.Query<int>(sql, commandType: CommandType.Text).Contains(1);

                return result;
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

                string query = @"SELECT id, primeiroNome as Nome, sobrenome, cpf, endereco, email, telefone, ativo, dataCriacao FROM Cliente";

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

                string query = $"SELECT primeiroNome as Nome, sobrenome, cpf, endereco, email, telefone, ativo, dataCriacao FROM Cliente" +
                    $" WHERE primeiroNome LIKE '%{nome}%'";

                var cliente = _connection.Query<Cliente>(query, commandType: CommandType.Text);

                _connection.Close();

                return cliente;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Cliente>();
            }

        }

        public Cliente GetClienteById(int id)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = $"SELECT * FROM Cliente WHERE id={id}";

                var cliente = _connection.QuerySingle<Cliente>(query, commandType: CommandType.Text);

                _connection.Close();
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void EditarCliente(Cliente cliente)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string clienteSql = $"UPDATE Cliente SET primeiroNome = '{cliente.Nome}', sobrenome = '{cliente.Sobrenome}', cpf = '{cliente.Cpf}', " +

                    $"endereco = '{cliente.Endereco}', email = '{cliente.Email}', telefone = '{cliente.Telefone}' " +

                    $"WHERE id = {cliente.Id}";

                _connection.Execute(clienteSql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteCliente(Cliente cliente)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"DELETE FROM Cliente WHERE id='{cliente.Id}'";

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
