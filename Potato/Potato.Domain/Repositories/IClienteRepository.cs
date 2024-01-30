using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IClienteRepository
    {
        public int CriarCliente(Cliente cliente);
        public string ValidateEmailAddress(string emailAddress);
        IEnumerable<Cliente> GetClientes();
        IEnumerable<Cliente> GetClienteByNome(string nome);
        public Cliente GetClienteById(int id);
        public void EditarCliente(Cliente cliente);
        public void DeleteCliente(Cliente cliente);
        //public void UpdateClienteVeiculo(int clienteId, int veiculoId);
        //public void UpdateClienteServico(int clienteId, int servicoId);
    }
}
