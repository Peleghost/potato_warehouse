using Potato.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Repositories
{
    public interface IServicoRepository
    {
        IEnumerable<Servico> GetAll();
        public int CriarServico(Servico servico);
    }
}
