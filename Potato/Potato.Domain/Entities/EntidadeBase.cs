namespace Potato.Domain.Entities
{
    public class EntidadeBase
    {
        public int Id { get; set; }

        // DataCriacao e DataFinal como string pois DateTime estava conflitando entre regioes
        public string? DataCriacao { get; set; }
        public string? DataFinal { get; set; }
    }
}
