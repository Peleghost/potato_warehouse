using Potato.Domain.Entities;
using Potato.Domain.Models;

namespace Potato.Domain.Repositories
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> GetAll();
        public int CriarServico(Servico servico);
        public void InsertServicoPeca(int pecaId, int servicoId, int quantidade);
        public void UpdateServicoPeca(int pecaId, int qtd);
        public List<Peca> GetServicoPecas(int servicoId);
        public IEnumerable<ServicoModel> GetByClienteOuVeiculo(string criterio, string busca);
        public IEnumerable<ServicoModel> GetByDate(string dateStart, string dateEnd);
        public IEnumerable<ServicoModel> GetByMecanico(string mecanico);
        public void FinalizarServico(int servicoId, string dataFinal, int ativo);
        public void EditarServico(int servicoId, string descricao, double preco);
        public void DeleteServico(int servicoId);
    }
}
