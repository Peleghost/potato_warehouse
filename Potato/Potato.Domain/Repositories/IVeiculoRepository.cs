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
        public IEnumerable<Veiculo> GetAll();
        public int CriarVeiculo(Veiculo veiculo);
        public void EditarVeiculo(Veiculo veiculo);
        public int VerificarPlaca(string placa);
        public bool VerificarVeiculoEmServico(int veiculoId);
        public IEnumerable<Veiculo> GetVeiculoByClienteId(int clienteId);
        //public void UpdateVeiculoClienteId(int clienteId, int veiculoId);
        public void DeleteVeiculo(int veiculoId);
        public void UpdateVeiculoServicoId(int servicoId, int veiculoId);
        public void NullVeiculoServicoId(int servicoId);
    }
}
