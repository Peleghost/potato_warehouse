using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IPecaRepository
    {

        public int CriarPeca(Peca peca);

        IEnumerable<Peca> GetPecas();

        IEnumerable<Peca> GetPecaById(int id);

        IEnumerable<Peca> GetPecasByNomeOuCategoria(string criterio, string busca);

        public void DeleteFromDb(Peca peca);

    }
}
