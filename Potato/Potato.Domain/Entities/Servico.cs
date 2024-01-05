using Potato.Domain.Validation;

namespace Potato.Domain.Entities
{
    public class Servico : EntidadeBase
    {
        public Cliente Cliente { get; private set; }
        public Peca Peca { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public string VeiculoSemCadastro { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }

        public Servico(Cliente cliente, Peca peca, Veiculo veiculo, string veiculoSemCadastro, string descricao, double preco)
        {
            this.Cliente = cliente;
            this.Peca = peca;
            this.Veiculo = veiculo;
            this.VeiculoSemCadastro = veiculoSemCadastro;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        public static Result<Servico> Criar(Cliente cliente, Peca peca, Veiculo veiculo, string veiculoSemCadastro, string descricao, double preco)
        {
            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (peca == null)
                return new Result<Servico>(isSuccess: false, null);

            if (veiculo == null)
                return new Result<Servico>(isSuccess: false, null);

            if (veiculoSemCadastro == null)
                return new Result<Servico>(isSuccess: false, null);

            if (descricao == null)
                return new Result<Servico>(isSuccess: false, null);

            if (preco == 0)
                return new Result<Servico>(isSuccess: false, null);

            return new Result<Servico>(isSuccess: true, new Servico(cliente, peca, veiculo, veiculoSemCadastro, descricao, preco));
        }
    }
}
