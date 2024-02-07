using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public string? Ano { get; set; }
        public string? Placa { get; set; }
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
    }
}
