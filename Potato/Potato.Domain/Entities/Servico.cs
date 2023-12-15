using Potato.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Entities
{
    public class Servico : EntidadeBase
    {
        public Cliente Cliente { get; private set; }
        public Peca Peca { get; private set; }
        public string Veiculo { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }

        public Servico(Cliente cliente, Peca peca, string veiculo, string descricao, double preco)
        {
            this.Cliente = cliente;
            this.Peca = peca;
            this.Veiculo = veiculo;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        public static Result<Servico> Criar(Cliente cliente, Peca peca, string veiculo, string descricao, double preco)
        {
            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            if (cliente == null)
                return new Result<Servico>(isSuccess: false, null);

            return new Result<Servico>(isSuccess: true, new Servico(cliente, peca, veiculo, descricao, preco));
        }
    }
}
