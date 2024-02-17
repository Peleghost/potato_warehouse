using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
                var regex = new Regex("^[A-Z a-z]+$");
                string nome, sobrenome;
                var telefone = clienteTelefone_masktb.Text.Trim();

                if (clienteNome_tb.Text.Trim() == string.Empty || clienteSobrenome_tb.Text.Trim() == string.Empty)
                {
                    throw new Exception("Error: Favor preencher campos Nome e Sobrenome!");
                }
                else if (!regex.IsMatch(clienteNome_tb.Text.Trim()) || !regex.IsMatch(clienteSobrenome_tb.Text.Trim()))
                {
                    throw new Exception("Error: Favor preencher campos Nome e Sobrenome corretamente!");
                }
                else if (telefone.Length < 14)
                {
                    throw new Exception("Error: Favor preencher campo Telefone corretamente!");
                }
                else
                {
                    var tempNome = clienteNome_tb.Text.Trim();
                    var tempSobrenome = clienteSobrenome_tb.Text.Trim();

                    nome = char.ToUpper(tempNome[0]) + tempNome.Substring(1);
                    sobrenome = char.ToUpper(tempSobrenome[0]) + tempSobrenome.Substring(1);
                }

                var cliente = new Cliente()
                {
                    Nome = nome,
                    Sobrenome = sobrenome,
                    Cpf = clienteCpf_masktb.Text,
                    Endereco = clienteEndereco_tb.Text,
                    Email = clienteEmail_tb.Text,
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
