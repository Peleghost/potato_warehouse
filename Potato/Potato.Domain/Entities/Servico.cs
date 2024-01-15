using Potato.Domain.Validation;

namespace Potato.Domain.Entities
{
    public class Servico : EntidadeBase
    {
        public string? Cliente_Nome { get; set; }
        public string? Veiculo_Placa { get; set; }
        public Cliente? Cliente { get; private set; }
        public List<Peca>? Pecas { get; private set; }
        public Veiculo? Veiculo { get; private set; }
        public string? Descricao { get; private set; }
        public double? Preco { get; private set; }
        

        public Servico()
        {
        }

        public Servico(Cliente cliente, /*List<Peca> pecas,*/ Veiculo veiculo, string descricao, double preco)
        {
            this.Cliente = cliente;
            //this.Pecas = pecas;
            this.Veiculo = veiculo;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        public static Result<Servico> Criar(Cliente cliente, /*List<Peca> pecas,*/ Veiculo veiculo, string descricao, double preco)
        {
            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            //if (pecas == null)
            //    return new Result<Servico>(isSuccess: false, null);

            if (veiculo == null)
                return new Result<Servico>(isSuccess: false, null);

            if (descricao == null)
                return new Result<Servico>(isSuccess: false, null);

            if (preco == 0)
                return new Result<Servico>(isSuccess: false, null);

            return new Result<Servico>(isSuccess: true, new Servico(cliente, veiculo, descricao, preco));
        }
    }
}
