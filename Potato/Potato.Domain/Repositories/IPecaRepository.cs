using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IPecaRepository
    {

        public void CriarPeca(Peca peca);

        IEnumerable<Peca> GetPecas();

        IEnumerable<Peca> GetPecaById(string id);

        IEnumerable<Peca> GetPecasByCategoria(string categoria);

        public void DeleteFromDb(Peca peca);

    }
}
