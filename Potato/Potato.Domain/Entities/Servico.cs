using Potato.Domain.Validation;

namespace Potato.Domain.Entities
{
    public class Servico : EntidadeBase
    {
        public Cliente? Cliente { get; private set; }
        public List<Peca>? Pecas { get; set; }
        public Veiculo? Veiculo { get; private set; }
        public string? Descricao { get; private set; }
        public double? Preco { get; private set; }
        public int Ativo { get; private set; }


        public Servico()
        {
        }


        public Servico(Cliente cliente, Veiculo veiculo, string descricao, double preco, int ativo)
        {
            this.Cliente = cliente;
            this.Veiculo = veiculo;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Ativo = ativo;
        }
        public static Result<Servico> Criar(Cliente cliente, Veiculo veiculo, string descricao, double preco, int ativo)
        {
            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (veiculo == null)
                return new Result<Servico>(isSuccess: false, null);

            if (descricao == null)
                return new Result<Servico>(isSuccess: false, null);

            if (preco == 0)
                return new Result<Servico>(isSuccess: false, null);

            if (ativo == 0)
                return new Result<Servico>(isSuccess: false, null);

            return new Result<Servico>(isSuccess: true, new Servico(cliente, veiculo, descricao, preco, ativo));
        }
    }
}
