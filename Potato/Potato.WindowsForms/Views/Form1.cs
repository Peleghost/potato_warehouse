using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositories
        private readonly IArmazemRepository _armazemRepository;
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;
        private readonly IClienteRepository _clienteRepository;
        //

        // Global Variables
        public static int ArmazemId;
        public static bool PecaTabEnter;
        public static bool ClienteTabEnter;
        //

        public Form1(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository,
            IArmazemRepository armazemRepository, IClienteRepository clienteRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
            _armazemRepository = armazemRepository;
            _clienteRepository = clienteRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPecasData();
            CriarArmazemSeNaoExiste();
        }

        private void CriarArmazemSeNaoExiste()
        {
            var armazem = _armazemRepository.GetArmazem();

            if (!armazem.Any())
                ArmazemId = _armazemRepository.CriarArmazem();
            else
                ArmazemId = armazem.FirstOrDefault()!.Id;
        }

        // Hide columns from DataGridView
        private void allPecasDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPecasDgv.Columns["Id"].Visible = false;
        }

        private void allClientes_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allClientesDgv.Columns["Id"].Visible = false;
            allClientesDgv.Columns["servicoId"].Visible = false;
            allClientesDgv.Columns["Veiculo"].Visible = false;
        }
        //

        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {

            if (mainTabControl.SelectedTab == pecaTabPage && !PecaTabEnter)
            {
                loadPecasData();
                PecaTabEnter = true;
            }
            else if (mainTabControl.SelectedTab == clienteTabPage && !ClienteTabEnter)
            {
                loadClienteData();
                ClienteTabEnter = true;
            }

        }

        //----------------------------------------------------------------------------------------------------------

        #region ----- Control Methods / LoadData -----

        // LoadDatas
        // To populate and refresh allPecasDGV
        private void loadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();

            allPecasDgv.DataSource = pecas;

            // Gray rows based on Peca quantidade
            PecaQuantidadeZero();

            labelTotalRecords.Text = $"Total Records: {allPecasDgv.RowCount}";
        }

        // To populate and refresh allClientesDGV
        public void loadClienteData()
        {
            var clientes = _clienteRepository.GetClientes();

            allClientesDgv.DataSource = clientes;

            totalClientesLabel.Text = $"Total Records: {allClientesDgv.RowCount}";
        }
        //

        //---------------------------------------------------------------------
        public void PecaQuantidadeZero()
        {
            var rows = allPecasDgv.Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                var peca = (Peca)rows[i].DataBoundItem;

                if (peca.Quantidade == 0)
                {
                    rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.DarkGray
                    };
                }
            }
        }

        // Peca Controls
        public void EnablePecaControls()
        {
            venderButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            editNome_tb.Enabled = true;
            editCategoria_tb.Enabled = true;
            editPreco_masktb.Enabled = true;
            editQuantidadeNumeric.Enabled = true;
        }

        public void DisablePecaControls()
        {
            venderButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            editNome_tb.Enabled = false;
            editCategoria_tb.Enabled = false;
            editPreco_masktb.Enabled = false;
            editQuantidadeNumeric.Enabled = false;
        }

        // Clear Peca Edit TextBoxes
        public void ClearPecaEdit()
        {
            editNome_tb.Clear();
            editPreco_masktb.Clear();
            editCategoria_tb.Clear();
            editQuantidadeNumeric.Value = 0;
        }

        // Cliente Controls
        public void EnableClienteControls()
        {
            clienteServicoButton.Enabled = true;
            editClienteButton.Enabled = true;
            deleteClienteButton.Enabled = true;
            editClienteNome_tb.Enabled = true;
            editClienteSobrenome_tb.Enabled = true;
            editClienteCpf_tb.Enabled = true;
            editClienteEndereco_tb.Enabled = true;
            editClienteEmail_tb.Enabled = true;
            editClienteTelefone_tb.Enabled = true;
        }

        public void DisableClienteControls()
        {
            clienteServicoButton.Enabled = false;
            editClienteButton.Enabled = false;
            deleteClienteButton.Enabled = false;
            editClienteNome_tb.Enabled = false;
            editClienteSobrenome_tb.Enabled = false;
            editClienteCpf_tb.Enabled = false;
            editClienteEndereco_tb.Enabled = false;
            editClienteEmail_tb.Enabled = false;
            editClienteTelefone_tb.Enabled = false;
        }

        public void ClearClienteEdit()
        {
            editClienteNome_tb.Clear();
            editClienteSobrenome_tb.Clear();
            editClienteCpf_tb.Clear();
            editClienteEndereco_tb.Clear();
            editClienteEmail_tb.Clear();
            editClienteTelefone_tb.Clear();
        }

        //--------------------------------------------------
        #endregion



        #region ----- Pecas -----
        private void getPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pecas = _pecaRepository.GetPecas();
                allPecasDgv.DataSource = pecas;
                loadPecasData();
                labelTotalRecords.Text = $"Total Records: {allPecasDgv.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void addPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Peca peca = new()
                {
                    Nome = nome_tb.Text,
                    Preco = double.Parse(preco_masktb.Text),
                    Categoria = categoria_tb.Text
                };

                var pecaId = _pecaRepository.CriarPeca(peca);

                PecaEstoque pecaEstoque = new PecaEstoque()
                {
                    PecaId = pecaId,
                    ArmazenId = ArmazemId,
                    Quantidade = Convert.ToInt32(pecaEstoqueNumeric.Value),
                };

                _pecaEstoqueRepository.CriarPecaEstoque(pecaEstoque);

                loadPecasData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nErro: Formato nao aceito ou campo nao preenchido");
            }
        }

        private void venderButton_Click(object sender, EventArgs e)
        {

            try
            {
                var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

                if (peca.Quantidade == 0)
                {
                    MessageBox.Show("Fora de Estoque\nQuantidade: 0.\n\nReponha ou Delete Peca", "Confirmar", MessageBoxButtons.OK);
                    return;
                }

                var message = MessageBox.Show($"Vender Peca?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}, Quantidade: {peca.Quantidade}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.VenderPeca(peca);

                    loadPecasData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

                peca = new Peca()
                {
                    Id = peca.Id,
                    Nome = editNome_tb.Text,
                    Preco = Convert.ToDouble(editPreco_masktb.Text),
                    Categoria = editCategoria_tb.Text,
                };

                int quantidade = Convert.ToInt32(editQuantidadeNumeric.Value);

                var message = MessageBox.Show($"Editar Peca?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.EditarPeca(peca, quantidade);

                    selectedDataGridView.Columns.Clear();
                    ClearPecaEdit();
                    DisablePecaControls();
                    loadPecasData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show($"Deletar Item?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.DeletePeca(peca);

                    selectedDataGridView.Columns.Clear();
                    ClearPecaEdit();
                    DisablePecaControls();
                    loadPecasData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void allPecasDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedPeca = (Peca)allPecasDgv.CurrentRow.DataBoundItem;

            if (selectedPeca.Quantidade == 0)
            {
                allPecasDgv.CurrentRow.Selected = false;
            }

            EnablePecaControls();

            editNome_tb.Text = selectedPeca.Nome;
            editCategoria_tb.Text = selectedPeca.Categoria;
            editPreco_masktb.Text = selectedPeca.Preco.ToString();
            editQuantidadeNumeric.Value = selectedPeca.Quantidade;

            //var listPeca = new List<IEnumerable<Peca>>();
            try
            {
                var peca = _pecaRepository.GetPecaById(selectedPeca.Id);
                selectedDataGridView.DataSource = peca;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void searchPecaButton_Click(object sender, EventArgs e)
        {
            switch (searchComboBox.Text)
            {
                case "ID":
                    try
                    {
                        var id = Convert.ToInt32(searchTextBox.Text);
                        var peca = _pecaRepository.GetPecaById(id);

                        allPecasDgv.DataSource = peca;
                        PecaQuantidadeZero();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    break;


                case "Nome":

                    try
                    {
                        string criterio = searchComboBox.Text;
                        string nome = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, nome);

                        allPecasDgv.DataSource = pecas;
                        PecaQuantidadeZero();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    break;

                case "Categoria":

                    try
                    {
                        string criterio = searchComboBox.Text.ToLower();
                        string categoria = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, categoria);

                        allPecasDgv.DataSource = pecas;
                        PecaQuantidadeZero();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    break;

                default:
                    MessageBox.Show($"Error: Nenhum iten Encontrado");
                    break;
            }

        }

        #endregion




        #region ----- Clientes -----

        private void cadastrarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var email = "";

                try
                {
                    clienteEmail_tb.ForeColor = Color.Black;
                    email = new MailAddress(clienteEmail_tb.Text).Address;
                }
                catch (FormatException)
                {
                    clienteEmail_tb.ForeColor = Color.Red;
                    MessageBox.Show("Error: Formato de Email nao aceito.\nEx: usuario@email.com");
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

                loadClienteData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buscarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = searchCliente_tb.Text;
                var cliente = _clienteRepository.GetClienteByNome(nome);

                allClientesDgv.DataSource = cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void listarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clientes = _clienteRepository.GetClientes();
                loadClienteData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void allClientesDgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var cliente = (Cliente)allClientesDgv.CurrentRow.DataBoundItem;

                EnableClienteControls();

                editClienteNome_tb.Text = cliente.Nome;
                editClienteSobrenome_tb.Text = cliente.Sobrenome;
                editClienteCpf_tb.Text = cliente.Cpf;
                editClienteEndereco_tb.Text = cliente.Endereco;
                editClienteEmail_tb.Text = cliente.Email;
                editClienteTelefone_tb.Text = cliente.Telefone;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void editClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = (Cliente)allClientesDgv.CurrentRow.DataBoundItem;

                cliente = new Cliente()
                {
                    Id = cliente.Id,
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

                    ClearClienteEdit();
                    DisableClienteControls();
                    loadClienteData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deleteClienteButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)allClientesDgv.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show($"Deletar Cliente?\n Nome: {cliente.Nome}, Sobrenome: {cliente.Sobrenome}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _clienteRepository.DeleteCliente(cliente);

                    ClearClienteEdit();
                    DisableClienteControls();
                    loadClienteData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #endregion







    }

}