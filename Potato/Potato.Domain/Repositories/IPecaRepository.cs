using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IPecaRepository
    {
        public int CriarPeca(Peca peca);
        public void VenderPeca(int pecaId, int quantidade);
        public void EditarPeca(Peca peca, int quantidade);
        IEnumerable<Peca> GetPecas();
        IEnumerable<Peca> GetPecaById(int id);
        IEnumerable<Peca> GetPecasByNomeOuCategoria(string criterio, string busca);
        public void DeletePeca(Peca peca);
    }
}
