using System.ComponentModel.DataAnnotations;

namespace Potato.Domain.Entities
{
    public class Cliente : EntidadeBase
    {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Cpf { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public int Ativo { get; set; }
        public int ServicoId { get; set; }
        public int VeiculoId { get; set; }
    }
}
