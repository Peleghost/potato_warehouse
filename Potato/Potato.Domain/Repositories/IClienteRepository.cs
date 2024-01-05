﻿using Potato.Domain.Entities;

namespace Potato.Domain.Repositories
{
    public interface IClienteRepository
    {
        public int CriarCliente(Cliente cliente);
        public string ValidateEmailAddress(string emailAddress);
        IEnumerable<Cliente> GetClientes();
        IEnumerable<Cliente> GetClienteByNome(string nome);
        public void EditarCliente(Cliente cliente);
        public void DeleteCliente(Cliente cliente);
    }
}
