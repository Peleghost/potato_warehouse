using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly IDbConnection _connection;

        public ServicoRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Servico> GetAll()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string query = "SELECT Cliente.primeiroNome as Cliente_Nome, Veiculo.placa as Veiculo_Placa, Servico.id as Id, " +

                    "descricao, preco as Preco, Servico.dataCriacao as DataCriacao FROM Servico " +

                    $"LEFT JOIN Cliente on Servico.clienteId = Cliente.id " +

                    $"LEFT JOIN Veiculo on Servico.veiculoId = Veiculo.id";
                
                var servicos = _connection.Query<Servico>(query, commandType: CommandType.Text);
                
                _connection.Close();

                return servicos;
            }
            catch (Exception)
            {
                return Enumerable.Empty<Servico>();
            }
        }

        public int CriarServico(Servico servico)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                int clienteId = servico.Cliente!.Id;
                int veiculoId = servico.Veiculo!.Id;

                string sql = $"INSERT INTO Servico (clienteId, veiculoId, descricao, datacriacao, preco) " +

                    $"VALUES ({clienteId}, {veiculoId}, '{servico.Descricao}', '{servico.DataCriacao}', {servico.Preco});" +

                    $"SELECT last_insert_rowid();";

                int servicoId;

                var cmd = _connection.CreateCommand();
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    servicoId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                _connection.Close();

                return servicoId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        

    }
}
