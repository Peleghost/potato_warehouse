using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Data;

namespace Potato.Infrastructure.Persistence.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly IDbConnection _connection;

        public VeiculoRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int VerificarPlaca(string placa)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"SELECT id FROM Veiculo WHERE placa = '{placa}'";
                var id = _connection.Query<int>(sql, commandType: CommandType.Text);
                var result = Convert.ToInt32(id.FirstOrDefault());

                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool VerificarVeiculoEmServico(int veiculoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"SELECT ativo FROM Servico " +

                    $"WHERE veiculoId = {veiculoId}";

                var result = _connection.Query<int>(sql, commandType: CommandType.Text).Contains(1);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public IEnumerable<Veiculo> GetVeiculoByClienteId(int clienteId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"SELECT id, marca, modelo, cor, ano, placa, clienteId FROM Veiculo WHERE clienteId = {clienteId}";

                var veiculos = _connection.Query<Veiculo>(sql, commandType: CommandType.Text);

                return veiculos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public int CriarVeiculo(Veiculo veiculo)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"INSERT INTO Veiculo(marca, modelo, cor, ano, placa, clienteId) " +

                    $"VALUES('{veiculo.Marca}', '{veiculo.Modelo}', '{veiculo.Cor}', '{veiculo.Ano}', '{veiculo.Placa}', {veiculo.ClienteId});" +

                    $"SELECT last_insert_rowid();";

                int veiculoId;

                var cmd = _connection.CreateCommand();
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    veiculoId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                _connection.Close();

                return veiculoId;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void UpdateVeiculoClienteId(int clienteId, int veiculoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Veiculo SET clienteId = {clienteId} " +
                    $"WHERE Veiculo.Id = {veiculoId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateVeiculoServicoId(int servicoId, int veiculoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Veiculo SET servicoId = {servicoId} " +
                    $"WHERE Veiculo.Id = {veiculoId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void NullVeiculoServicoId(int servicoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Veiculo SET servicoId = NULL " +
                    $"WHERE Veiculo.servicoId = {servicoId};";

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
