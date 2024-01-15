using Potato.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Repositories
{
    public interface IVeiculoRepository
    {
        public int CriarVeiculo(Veiculo veiculo);
        public int VerificarPlaca(string placa);
        public IEnumerable<Veiculo> GetVeiculoByClienteId(int clienteId);
    }
}
