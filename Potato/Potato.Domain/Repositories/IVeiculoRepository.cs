﻿using Potato.Domain.Entities;

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
        public void DeleteVeiculo(int veiculoId);
        public void UpdateVeiculoServicoId(int servicoId, int veiculoId);
        public void NullVeiculoServicoId(int servicoId);
    }
}
