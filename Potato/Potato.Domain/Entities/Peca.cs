namespace Potato.Domain.Entities
{
    public class Peca
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string? Armazen { get; }

    }

}
