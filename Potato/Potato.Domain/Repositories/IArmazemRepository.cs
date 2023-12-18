using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IArmazemRepository
    {
        public int CriarArmazem();

        public IEnumerable<Armazem> GetArmazem();

    }
}
