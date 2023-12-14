namespace Potato.Domain.Entities
{
    public class Armazen
    {
        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public string? Endereco { get; private set; }

        public Armazen()
        {
            Id = 101;
            Nome = "Batata Motos Ltda.";
            Endereco = "test";
        }
    }
}
