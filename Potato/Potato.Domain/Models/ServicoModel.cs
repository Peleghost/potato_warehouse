using Potato.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Models
{
    public class ServicoModel : Servico
    {
        public string? Cliente_Nome { get; set; }
        public string? Veiculo_Nome { get; set; }
        public string? Veiculo_Placa { get; set; }
    }
}
