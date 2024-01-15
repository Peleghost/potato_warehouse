using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms.Forms.ClienteForms
{
    public partial class EditarClienteForm : Form
    {
        private readonly IClienteRepository _clienteRepository;

        public EditarClienteForm(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            InitializeComponent();
        }

        // Overloading ShowDialog Method to take a reference 
        public void ShowDialog(ref DataGridViewRow clienteEditar)
        {
            var cliente = (Cliente)clienteEditar.DataBoundItem;
            EditClienteTbControls(cliente);

            this.ShowDialog();
        }

        // Edit TextBox Controls
        private void EditClienteTbControls(Cliente cliente)
        {
            editClienteId_tb.Text = cliente.Id.ToString();
            editClienteNome_tb.Text = cliente.Nome;
            editClienteSobrenome_tb.Text = cliente.Sobrenome;
            editClienteCpf_tb.Text = cliente.Cpf;
            editClienteEndereco_tb.Text = cliente.Endereco;
            editClienteEmail_tb.Text = cliente.Email;
            editClienteTelefone_tb.Text = cliente.Telefone;
        }



        private void editClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var email = _clienteRepository.ValidateEmailAddress(editClienteEmail_tb.Text);

                if (email.StartsWith("Error"))
                {
                    editClienteEmail_tb.ForeColor = Color.Red;
                    throw new Exception("Error: Formato de Email não aceito.\n Ex: email@exemplo.com");
                }

                var cliente = new Cliente()
                {
                    Id = Convert.ToInt32(editClienteId_tb.Text),
                    Nome = editClienteNome_tb.Text,
                    Sobrenome = editClienteSobrenome_tb.Text,
                    Cpf = editClienteCpf_tb.Text,
                    Endereco = editClienteEndereco_tb.Text,
                    Email = editClienteEmail_tb.Text,
                    Telefone = editClienteTelefone_tb.Text
                };

                var message = MessageBox.Show($"Editar Cliente?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _clienteRepository.EditarCliente(cliente);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
