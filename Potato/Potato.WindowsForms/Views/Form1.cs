using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using Potato.WindowsForms.PecaForms;
using Potato.WindowsForms.Forms.ClienteForms;
using Potato.WindowsForms.Forms.ServicoForms;
using System.Collections;
using Potato.WindowsForms.Forms.PecaForms;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositories
        private readonly IArmazemRepository _armazemRepository;
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IServicoRepository _servicoRepository;
        //

        // Global Variables
        private static int ArmazemId;
        private static bool PecaTabEnter;
        private static bool ClienteTabEnter;
        private static bool ServicoTabEnter;
        //

        public Form1(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository
            , IArmazemRepository armazemRepository, IClienteRepository clienteRepository
            , IVeiculoRepository veiculoRepository, IServicoRepository servicoRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
            _armazemRepository = armazemRepository;
            _clienteRepository = clienteRepository;
            _veiculoRepository = veiculoRepository;
            _servicoRepository = servicoRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPecasData();
            LoadClienteData();
            LoadServicoData();
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

        // Load data on tab enter, if already entered once no load data
        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {

            if (mainTabControl.SelectedTab == pecaTabPage && !PecaTabEnter)
            {
                LoadPecasData();
                PecaTabEnter = true;
            }
            else if (mainTabControl.SelectedTab == clienteTabPage && !ClienteTabEnter)
            {
                LoadClienteData();
                ClienteTabEnter = true;
            }
            else if (mainTabControl.SelectedTab == servicoTabPage && !ServicoTabEnter)
            {
                LoadServicoData();
                ServicoTabEnter = true;
            }

        }

        // Hide columns from DataGridView
        private void allPecasDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPecas_dgv.Columns["Id"].Visible = false;
        }

        private void allClientes_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allClientes_dgv.Columns["Id"].Visible = false;
            allClientes_dgv.Columns["servicoId"].Visible = false;
            //allClientesDgv.Columns["veiculoId"].Visible = false;
        }

        private void allServicos_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allServicos_dgv.Columns["Id"].Visible = false;
            allServicos_dgv.Columns["Cliente"].Visible = false;
            allServicos_dgv.Columns["Veiculo"].Visible = false;
            allServicos_dgv.Columns["Ativo"].Visible = false;
            allServicos_dgv.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void servicoPecas_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            servicoPecas_dgv.Columns["id"].Visible = false;
            servicoPecas_dgv.Columns["armazen"].Visible = false;
        }
        //

        //----------------------------------------------------------------------------------------------------------

        #region ----- Control Methods / LoadData -----

        // LoadDatas
        //
        // To populate and refresh allPecasDGV
        private void LoadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();

            allPecas_dgv.DataSource = pecas;

            // Gray rows based on Peca quantidade
            PecaQuantidadeZero();

            labelTotalRecords.Text = $"Total Records: {allPecas_dgv.RowCount}";
        }

        // To populate and refresh allClientesDGV
        private void LoadClienteData()
        {
            var clientes = _clienteRepository.GetClientes();

            allClientes_dgv.DataSource = clientes;

            totalClientesLabel.Text = $"Total Records: {allClientes_dgv.RowCount}";
        }
        //

        // To populate and refresh allServicos_dgv
        private void LoadServicoData()
        {
            var servicos = _servicoRepository.GetAll();

            allServicos_dgv.DataSource = servicos;

            ServicoFinalizado();
        }
        //

        //---------------------------------------------------------------------
        private void PecaQuantidadeZero()
        {
            var rows = allPecas_dgv.Rows;

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

        private void ServicoFinalizado()
        {
            var rows = allServicos_dgv.Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                var servico = (Servico)rows[i].DataBoundItem;

                if (servico.Ativo == 0)
                {
                    rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.LightGreen
                    };
                }
            }
        }

        // Peca Controls
        private void EnablePecaControls()
        {
            venderButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void DisablePecaControls()
        {
            venderButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }
        //

        // Cliente Controls
        private void EnableClienteControls()
        {
            clienteServicoButton.Enabled = true;
            editClienteButton.Enabled = true;
            deleteClienteButton.Enabled = true;
        }

        private void DisableClienteControls()
        {
            clienteServicoButton.Enabled = false;
            editClienteButton.Enabled = false;
            deleteClienteButton.Enabled = false;
        }
        //

        // Servico Controls
        private void EnableServicoControls()
        {
            finalServicoButton.Enabled = true;
            editarServicoButton.Enabled = true;
            deleteServicoButton.Enabled = true;
            adicionarPecasButton.Enabled = true;
        }

        private void DisableServicoControls()
        {
            finalServicoButton.Enabled = false;
            editarServicoButton.Enabled = false;
            deleteServicoButton.Enabled = false;
            adicionarPecasButton.Enabled = false;
        }
        //

        private void SuccessMsg()
        {
            MessageBox.Show("    ----- Sucesso! -----", "Sucesso", MessageBoxButtons.OK);
        }

        //--------------------------------------------------
        #endregion



        #region ----- Pecas -----
        private void getPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPecasData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void novaPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var criarPecaForm = new CriarPecaForm(_pecaRepository, _pecaEstoqueRepository);
                criarPecaForm.ShowDialog();

                if (criarPecaForm.DialogResult == DialogResult.OK)
                {
                    criarPecaForm.Close();
                    SuccessMsg();
                    LoadPecasData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void venderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)allPecas_dgv.CurrentRow.DataBoundItem;

                if (peca.Quantidade == 0)
                {
                    MessageBox.Show("Fora de Estoque\nQuantidade: 0\n\nReponha ou Delete Peca", "Confirmar", MessageBoxButtons.OK);
                    return;
                }

                var venderPecaForm = new VenderPecaForm(_pecaRepository);

                venderPecaForm.ShowDialog(ref peca);

                if (venderPecaForm.DialogResult == DialogResult.OK)
                {
                    venderPecaForm.Close();
                    SuccessMsg();
                    LoadPecasData();
                    DisablePecaControls();
                }

                //var message = MessageBox.Show($"Vender Peca?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}, Quantidade: {peca.Quantidade}",
                //    "Confirmar", MessageBoxButtons.OKCancel);

                //if (message == DialogResult.OK)
                //{
                //    _pecaRepository.VenderPeca(peca);

                //    DisablePecaControls();
                //    LoadPecasData();
                //}

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
                var pecaEditar = allPecas_dgv.CurrentRow;
                var editPecaForm = new EditarPecaForm(_pecaRepository, _pecaEstoqueRepository);
                editPecaForm.ShowDialog(ref pecaEditar);

                if (editPecaForm.DialogResult == DialogResult.OK)
                {
                    editPecaForm.Close();

                    DisablePecaControls();
                    SuccessMsg();
                    LoadPecasData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var peca = (Peca)allPecas_dgv.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show($"Deletar Item?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.DeletePeca(peca);

                    DisablePecaControls();
                    LoadPecasData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void allPecasDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selectedPeca = (Peca)allPecas_dgv.CurrentRow.DataBoundItem;

                if (selectedPeca.Quantidade == 0)
                {
                    allPecas_dgv.CurrentRow.Selected = false;
                }

                EnablePecaControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //try
            //{
            //    var peca = _pecaRepository.GetPecaById(selectedPeca.Id);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex}");
            //}
        }

        private void searchPecaButton_Click(object sender, EventArgs e)
        {
            switch (searchPeca_combo.Text)
            {
                case "ID":
                    try
                    {
                        var id = Convert.ToInt32(searchTextBox.Text);
                        var peca = _pecaRepository.GetPecaById(id);

                        allPecas_dgv.DataSource = peca;
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
                        string criterio = searchPeca_combo.Text;
                        string nome = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, nome);

                        allPecas_dgv.DataSource = pecas;
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
                        string criterio = searchPeca_combo.Text.ToLower();
                        string categoria = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, categoria);

                        allPecas_dgv.DataSource = pecas;
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

        private void novoClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteForm = new CriarClienteForm(_clienteRepository);
                clienteForm.ShowDialog();

                if (clienteForm.DialogResult == DialogResult.OK)
                {
                    clienteForm.Close();
                    SuccessMsg();
                    LoadClienteData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buscarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = searchCliente_tb.Text;
                var cliente = _clienteRepository.GetClienteByNome(nome);

                allClientes_dgv.DataSource = cliente;
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
                LoadClienteData();
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
                var cliente = (Cliente)allClientes_dgv.CurrentRow.DataBoundItem;

                EnableClienteControls();
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
                var clienteEditar = allClientes_dgv.CurrentRow;
                var editClienteForm = new EditarClienteForm(_clienteRepository);
                editClienteForm.ShowDialog(ref clienteEditar);

                if (editClienteForm.DialogResult == DialogResult.OK)
                {
                    editClienteForm.Close();

                    DisableClienteControls();
                    SuccessMsg();
                    LoadClienteData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteClienteButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)allClientes_dgv.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show($"Deletar Cliente?\n Nome: {cliente.Nome}, Sobrenome: {cliente.Sobrenome}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _clienteRepository.DeleteCliente(cliente);

                    DisableClienteControls();
                    LoadClienteData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void clienteServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = (Cliente)allClientes_dgv.CurrentRow.DataBoundItem;

                var criarServicoForm = new CriarServicoForm(_clienteRepository, _veiculoRepository, _servicoRepository);
                criarServicoForm.ShowDialog(ref cliente);

                var dialogResult = criarServicoForm.DialogResult;

                if (dialogResult == DialogResult.OK)
                {
                    criarServicoForm.Close();
                    SuccessMsg();
                    DisableClienteControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        #endregion


        #region ----- Servicos -----

        private void listarServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadServicoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchServicoButton_Click(object sender, EventArgs e)
        {
            switch (searchServico_combo.Text)
            {
                case "Cliente_Nome":

                    try
                    {
                        const string criterio = "Cliente.primeiroNome";
                        string nome = searchServico_tb.Text;

                        var servicos = _servicoRepository.GetByClienteOuVeiculo(criterio, nome);

                        allServicos_dgv.DataSource = servicos;

                        ServicoFinalizado();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "Veiculo_Placa":

                    try
                    {
                        const string criterio = "Veiculo.placa";
                        string placa = searchServico_tb.Text;

                        var servicos = _servicoRepository.GetByClienteOuVeiculo(criterio, placa);

                        allServicos_dgv.DataSource = servicos;

                        ServicoFinalizado();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "Data":

                    try
                    {
                        string dateStart = dateStart_picker.Text;
                        string dateEnd = dateEnd_picker.Text;

                        var servicos = _servicoRepository.GetByDate(dateStart, dateEnd);

                        allServicos_dgv.DataSource = servicos;
                        ServicoFinalizado();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;


                default:
                    MessageBox.Show($"Error: Nenhum iten Encontrado");
                    break;
            }
        }

        private void finalServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var servico = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;

                if (servico.Ativo == 0)
                {
                    throw new Exception("Servico ja finalizado");
                }

                var message = MessageBox.Show("Finalizar Servico?", "Servico", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    string dataFinal = DateTime.Now.ToShortDateString();
                    int ativo = 0;

                    _servicoRepository.FinalizarServico(servico.Id, dataFinal, ativo);
                    _veiculoRepository.NullVeiculoServicoId(servico.Id);

                    SuccessMsg();
                    LoadServicoData();
                    DisableServicoControls();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allServicos_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var servico = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;

            var pecas = _servicoRepository.GetServicoPecas(servico.Id);

            servicoPecas_dgv.DataSource = pecas;

            servicoDescricao_tb.Text = servico.Descricao;

            EnableServicoControls();
        }

        private void editarServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var servicoEditar = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;
                var editServicoForm = new EditarServicoForm(_servicoRepository);

                if (servicoEditar.Ativo == 0)
                {
                    throw new Exception("Servico ja finalizado, impossivel editar!!");
                }
                else
                {
                    editServicoForm.ShowDialog(ref servicoEditar);
                }

                SuccessMsg();
                DisableServicoControls();
                LoadServicoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var servico = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;

                if (servico.Ativo == 1)
                {
                    throw new Exception("Veiculo em servico, impossibilitando Deletar\n" +
                        "Finalizar Servico primeiro!!");
                }

                var message = MessageBox.Show("Deletar Servico?", "Servico", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _servicoRepository.DeleteServico(servico.Id);
                }

                DisableServicoControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adicionarPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                var servico = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;

                var servicoPecaForm = new ServicoPecaForm(_pecaRepository, _clienteRepository, _servicoRepository);

                servicoPecaForm.ShowDialog(ref servico);

                if (servicoPecaForm.DialogResult == DialogResult.OK)
                {
                    servicoPecaForm.Close();
                    SuccessMsg();
                    DisableServicoControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        #endregion
















        
    }

}