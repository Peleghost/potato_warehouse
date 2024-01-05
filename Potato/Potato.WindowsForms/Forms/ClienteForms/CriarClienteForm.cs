using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potato.WindowsForms.Forms.ClienteForms
{
    public partial class CriarClienteForm : Form
    {
        private readonly IClienteRepository _clienteRepository;
        public CriarClienteForm(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            InitializeComponent();
        }

        private void cadastrarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var email = _clienteRepository.ValidateEmailAddress(clienteEmail_tb.Text);

                if (email.StartsWith("Error"))
                {
                    clienteEmail_tb.ForeColor = Color.Red;
                    throw new Exception("Error: Formato de Email não aceito.\n Ex: email@exemplo.com");
                }

                var cliente = new Cliente()
                {
                    Nome = clienteNome_tb.Text,
                    Sobrenome = clienteSobrenome_tb.Text,
                    Cpf = clienteCpf_masktb.Text,
                    Endereco = clienteEndereco_tb.Text,
                    Email = email,
                    Telefone = clienteTelefone_masktb.Text,
                    Ativo = 1,
                    DataCriacao = DateTime.UtcNow
                };

                _clienteRepository.CriarCliente(cliente);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
