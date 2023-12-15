using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IClienteRepository
    {
        public int CriarCliente(Cliente cliente);
        IEnumerable<Cliente> GetClientes();
        IEnumerable<Cliente> GetClienteByNome(string nome);
        public void DeleteCliente(Cliente cliente);
    }
}
