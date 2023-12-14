using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IPecaEstoqueRepository
    {
        public void CriarPecaEstoque(PecaEstoque pecaEstoque);
    }
}
