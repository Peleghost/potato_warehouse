namespace Potato.Domain.Entities
{
    public class Armazem
    {
        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Endereco { get; private set; }

        public Armazem()
        {
            Id = 101;
            Nome = "Batata Motos Ltda.";
            Endereco = "test";
        }
    }
}
