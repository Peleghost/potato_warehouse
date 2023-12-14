namespace Potato.Domain.Entities
{
    public class PecaEstoque
    {
        public int Id { get; set; }
        public int PecaId { get; set; }
        public int ArmazenId { get; set; }
        public int Quantidade { get; set; }
        //public Peca? Peca { get; set; }

    }
}
