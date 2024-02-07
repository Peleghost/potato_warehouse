using Dapper;
using Potato.Domain.Entities;
using Potato.Domain.Models;
using Potato.Domain.Repositories;
using System.Data;
using System.Globalization;

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

                string query = "SELECT Cliente.primeiroNome || ' ' || Cliente.sobrenome as Cliente_Nome" +

                    ", Veiculo.Marca || ' ' || Veiculo.Modelo as Veiculo_Nome" +

                    ", Veiculo.placa as Veiculo_Placa, Servico.id as Id" +

                    ", descricao, preco as Preco, Servico.dataCriacao as DataCriacao" +

                    ", Servico.dataFinal as DataFinal, Servico.ativo as Ativo " +
                    
                    "FROM Servico " +

                    $"INNER JOIN Cliente on Servico.clienteId = Cliente.id " +

                    $"INNER JOIN Veiculo on Servico.veiculoId = Veiculo.id " +

                    $"ORDER BY ativo DESC";
                
                var servicos = _connection.Query<ServicoModel>(query, commandType: CommandType.Text);
                
                _connection.Close();

                return servicos;
            }
            catch (Exception)
            {
                return Enumerable.Empty<ServicoModel>();
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

                string sql = $"INSERT INTO Servico (clienteId, veiculoId, pecaId, descricao, datacriacao, preco, ativo) " +

                    $"VALUES ({clienteId}, {veiculoId}, NULL, '{servico.Descricao}'" +
                    
                    $", '{servico.DataCriacao}', {servico.Preco}, {servico.Ativo});" +

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

        public void InsertServicoPeca(int pecaId, int servicoId, int quantidade)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = "INSERT INTO Servico_Peca (pecaId, servicoId, quantidade) " +
                    
                    $"VALUES ({pecaId}, {servicoId}, {quantidade})";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Peca> GetServicoPecas(int servicoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                List<Peca> pecas = new();

                string sql = "SELECT pecaId as Id, nome, categoria, preco, quantidade FROM Servico_Peca " +
                    
                    "INNER JOIN Peca on Peca.id = pecaId " +
                    
                    $"WHERE Servico_Peca.servicoId = {servicoId}";

                pecas = _connection.Query<Peca>(sql, commandType: CommandType.Text).ToList();

                return pecas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateServicoPeca(int pecaId, int qtd)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Servico_Peca SET quantidade = {qtd} " +
                    
                    $"WHERE pecaId = {pecaId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Servico> GetByClienteOuVeiculo(string criterio, string busca) 
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = "SELECT Cliente.primeiroNome || ' ' || Cliente.sobrenome as Cliente_Nome" +
                    
                    ", Veiculo.Marca || ' ' || Veiculo.Modelo as Veiculo_Nome" +
                    
                    ", Veiculo.placa as Veiculo_Placa, Servico.id as Id" +

                    ", descricao, preco as Preco, Servico.dataCriacao as DataCriacao" +
                    
                    ", Servico.dataFinal as DataFinal, Servico.ativo as Ativo " +

                    "FROM Servico " +

                    "INNER JOIN Cliente on Servico.clienteId = Cliente.id " +

                    "INNER JOIN Veiculo on Servico.veiculoId = Veiculo.id " +

                    $"WHERE {criterio} LIKE '%{busca}%'";

                var servicos = _connection.Query<Servico>(sql, commandType: CommandType.Text);

                return servicos;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<Servico> GetByDate(string dateStart, string dateEnd)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = "SELECT Cliente.primeiroNome || ' ' || Cliente.sobrenome as Cliente_Nome" +

                    ", Veiculo.Marca || ' ' || Veiculo.Modelo as Veiculo_Nome" +
                    
                    ", Veiculo.placa as Veiculo_Placa, Servico.id as Id" +

                    ", descricao, preco as Preco, Servico.dataCriacao as DataCriacao" +
                    
                    ", Servico.dataFinal as DataFinal, Servico.ativo as Ativo " +

                    "FROM Servico " +

                    "INNER JOIN Cliente on Servico.clienteId = Cliente.id " +

                    "INNER JOIN Veiculo on Servico.veiculoId = Veiculo.id " +

                    $"WHERE Servico.dataCriacao BETWEEN '{dateStart}' AND '{dateEnd}';";

                var servicos = _connection.Query<Servico>(sql, commandType: CommandType.Text);

                return servicos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FinalizarServico(int servicoId, string dataFinal, int ativo)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Servico SET dataFinal = '{dataFinal}', ativo = {ativo} " +

                    $"WHERE Servico.id = {servicoId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarServico(int servicoId, string descricao, double preco)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"UPDATE Servico SET descricao = '{descricao}', preco = {preco} " +
                    $"WHERE Servico.id = {servicoId}";

                _connection.Execute(sql, commandType: CommandType.Text);

                _connection.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteServico(int servicoId)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                string sql = $"DELETE FROM Servico WHERE Servico.id = {servicoId}";

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
