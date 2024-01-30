using Potato.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Repositories
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> GetAll();
        public int CriarServico(Servico servico);
        public void InsertServicoPeca(int pecaId, int servicoId, int quantidade);
        public List<Peca> GetServicoPecas(int servicoId);
        public IEnumerable<Servico> GetByClienteOuVeiculo(string criterio, string busca);
        public IEnumerable<Servico> GetByDate(string dateStart, string dateEnd);
        public void FinalizarServico(int servicoId, string dataFinal, int ativo);
        public void EditarServico(int servicoId, string descricao, double preco);
        public void DeleteServico(int servicoId);
    }
}
