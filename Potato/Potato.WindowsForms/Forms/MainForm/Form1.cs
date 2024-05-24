using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using Potato.WindowsForms.PecaForms;
using Potato.WindowsForms.Forms.ClienteForms;
using Potato.WindowsForms.Forms.ServicoForms;
using Potato.WindowsForms.Forms.PecaForms;
using Potato.WindowsForms.Forms.VeiculoForms;
using Potato.Domain.Models;
using System.ComponentModel;

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
        private BindingList<Peca>? PecasVender = new();
        private static int ArmazemId;
        private static bool ClienteTabEnter;
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

        #region ----- Control Methods / LoadData -----

        private void CriarArmazemSeNaoExiste()
        {
            var armazem = _armazemRepository.GetArmazem();

            if (!armazem.Any())
                ArmazemId = _armazemRepository.CriarArmazem();
            else
                ArmazemId = armazem.FirstOrDefault()!.Id;
        }

        // Load data on tab enter
        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {

            if (mainTabControl.SelectedTab == pecaTabPage)
            {
                LoadPecasData();
            }
            else if (mainTabControl.SelectedTab == clienteTabPage && !ClienteTabEnter)
            {
                LoadClienteData();
                ClienteTabEnter = true;
            }
            else if (mainTabControl.SelectedTab == servicoTabPage)
            {
                LoadServicoData();
            }
            else if (mainTabControl.SelectedTab == veiculoTabPage)
            {
                LoadVeiculoData();
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

        private void allVeiculos_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allVeiculos_dgv.Columns["Id"].Visible = false;
            allVeiculos_dgv.Columns["clienteId"].Visible = false;
            allVeiculos_dgv.Columns["servicoId"].Visible = false;
        }

        private void venderPeca_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            venderPeca_dgv.Columns["id"].Visible = false;
            venderPeca_dgv.Columns["armazen"].Visible = false;
        }
        //
        //----------------------------------------------------------------------------------------------------------
        //
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
        //
        //
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
        //
        private void ServicoPecasVazio()
        {
            var rows = servicoPecas_dgv.Rows;

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
        // ---------- LoadDatas ----------
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

        private void PopulateVenderPecaTb(Peca peca)
        {
            venderPecaId_tb.Text = peca.Id.ToString();
            venderPecaNome_tb.Text = peca.Nome;
            venderPecaCategoria_tb.Text = peca.Categoria;
            venderPecaPreco_tb.Text = peca.Preco.ToString();
        }

        // To populate and refresh allClientesDGV
        private void LoadClienteData()
        {
            var clientes = _clienteRepository.GetClientes();

            allClientes_dgv.DataSource = clientes;

            totalClientesLabel.Text = $"Total Records: {allClientes_dgv.RowCount}";
        }

        // To populate and refresh allServicos_dgv
        private void LoadServicoData()
        {
            var servicos = _servicoRepository.GetAll();

            allServicos_dgv.DataSource = servicos;

            ServicoFinalizado();

            totalServicoLabel.Text = $"Total Records: {allServicos_dgv.RowCount}";
        }

        // To populate and refresh allVeiculos_dgv
        private void LoadVeiculoData()
        {
            var veiculos = _veiculoRepository.GetAll();

            allVeiculos_dgv.DataSource = veiculos;

            totalVeiculosLabel.Text = $"Total Records: {allVeiculos_dgv.RowCount}";
        }
        //

        // Peca Controls
        private void EnablePecaControls()
        {
            venderPeca_btn.Enabled = true;
            editPeca_btn.Enabled = true;
            deletePeca_btn.Enabled = true;
        }

        private void DisablePecaControls()
        {
            venderPeca_btn.Enabled = false;
            editPeca_btn.Enabled = false;
            deletePeca_btn.Enabled = false;
        }

        private void ClearPecaControls()
        {
            PecasVender.Clear();
            venderPecaTotal_tb.Clear();
            venderPecaId_tb.Clear();
            venderPecaNome_tb.Clear();
            venderPecaCategoria_tb.Clear();
            venderPecaPreco_tb.Clear();
            venderPecaNumeric_tb.Value = 0;
        }
        //

        // Cliente Controls
        private void EnableClienteControls()
        {
            clienteServico_btn.Enabled = true;
            editCliente_btn.Enabled = true;
            deleteCliente_btn.Enabled = true;
        }

        private void DisableClienteControls()
        {
            clienteServico_btn.Enabled = false;
            editCliente_btn.Enabled = false;
            deleteCliente_btn.Enabled = false;
        }
        //

        // Servico Controls
        private void EnableServicoControls()
        {
            finalServico_btn.Enabled = true;
            editarServico_btn.Enabled = true;
            deleteServico_btn.Enabled = true;
            adicionarPecas_btn.Enabled = true;
        }

        private void DisableServicoControls()
        {
            finalServico_btn.Enabled = false;
            editarServico_btn.Enabled = false;
            deleteServico_btn.Enabled = false;
            adicionarPecas_btn.Enabled = false;
        }
        //

        // Veiculo Controls
        private void EnableVeiculoControls()
        {
            editVeiculo_btn.Enabled = true;
            deleteVeiculo_btn.Enabled = true;
        }

        private void DisableVeiculoControls()
        {
            editVeiculo_btn.Enabled = false;
            deleteVeiculo_btn.Enabled = false;
        }
        //

        private void SuccessMsg()
        {
            MessageBox.Show("    ----- Sucesso! -----", "Mensagem", MessageBoxButtons.OK);
        }

        //--------------------------------------------------
        #endregion




        #region ----- Pecas -----
        private void listarPecas_btn_Click(object sender, EventArgs e)
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

        private void novaPeca_btn_Click(object sender, EventArgs e)
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

        private void venderPeca_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PecasVender.Count == 0)
                {
                    throw new Exception("Carrinho vazio!");
                }

                var venderPecaForm = new VenderPecaForm(_pecaRepository);

                venderPecaForm.ShowDialog(ref PecasVender);

                if (venderPecaForm.DialogResult == DialogResult.OK)
                {
                    venderPecaForm.Close();

                    ClearPecaControls();

                    SuccessMsg();
                    LoadPecasData();
                    DisablePecaControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void editPeca_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var pecaEditar = allPecas_dgv.CurrentRow;
                var editPecaForm = new EditarPecaForm(_pecaRepository, _pecaEstoqueRepository);
                editPecaForm.ShowDialog(ref pecaEditar);

                if (editPecaForm.DialogResult == DialogResult.OK)
                {
                    editPecaForm.Close();

                    SuccessMsg();
                }

                DisablePecaControls();
                LoadPecasData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void addPeca_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)allPecas_dgv.CurrentRow.DataBoundItem;
                int quantidade;

                if (venderPecaNumeric_tb.Value > peca.Quantidade)
                {
                    throw new Exception("Error: Impossivel adicionar peca com quantidade maior que disponivel em estoque!");
                }
                else if (venderPecaNumeric_tb.Value == 0)
                {
                    throw new Exception("Error: Quantidade nao especificada!");
                }
                else
                {
                    quantidade = Convert.ToInt32(venderPecaNumeric_tb.Value);
                }

                var newPeca = new Peca() 
                {
                    Id = peca.Id,
                    Nome = peca.Nome,
                    Categoria = peca.Categoria,
                    Preco = peca.Preco,
                    Quantidade = quantidade,
                };

                if (PecasVender.Where(x => x.Id == newPeca.Id).Any())
                {
                    throw new Exception("Error: Peca ja adicionada!");
                }

                PecasVender.Add(newPeca);

                venderPeca_dgv.DataSource = PecasVender;

                double preco = 0;

                foreach (var item in PecasVender)
                {
                    preco += item.Preco * item.Quantidade;
                    venderPecaTotal_tb.Text = $"{preco:C}";
                }

                venderPecaNumeric_tb.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removePeca_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)venderPeca_dgv.CurrentRow.DataBoundItem;

                double preco = Convert.ToDouble(venderPecaTotal_tb.Text.Substring(1)) - (peca.Preco * peca.Quantidade);

                venderPecaTotal_tb.Text = $"{preco:C}";

                int index = PecasVender.IndexOf(peca);

                PecasVender.RemoveAt(index);

                venderPeca_dgv.DataSource = PecasVender;

                removePeca_btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void venderPeca_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            removePeca_btn.Enabled = true;
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

                PopulateVenderPecaTb(selectedPeca);

                EnablePecaControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void deletePeca_btn_Click(object sender, EventArgs e)
        {
            var peca = (Peca)allPecas_dgv.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show($"Deletar Item?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.DeletePeca(peca);
                    SuccessMsg();
                }

                DisablePecaControls();
                LoadPecasData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void searchPeca_btn_Click(object sender, EventArgs e)
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

        private void novoCliente_btn_Click(object sender, EventArgs e)
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

        private void buscarCliente_btn_Click(object sender, EventArgs e)
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

        private void listarCliente_btn_Click(object sender, EventArgs e)
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

        private void editCliente_btn_Click(object sender, EventArgs e)
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

        private void deleteCliente_btn_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)allClientes_dgv.CurrentRow.DataBoundItem;

            try
            {
                bool clienteEmServico = _clienteRepository.VerificarClienteEmServico(cliente.Id);

                if (clienteEmServico)
                {
                    throw new Exception("Cliente tem Veiculo em Servico!");
                }

                var message = MessageBox.Show($"Deletar Cliente?\n\nNome: {cliente.Nome} {cliente.Sobrenome}",
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

        private void clienteServico_btn_Click(object sender, EventArgs e)
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

        private void listarServico_btn_Click(object sender, EventArgs e)
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

        private void searchServico_btn_Click(object sender, EventArgs e)
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

                case "Mecanico":

                    try
                    {
                        string mecanico = searchServico_tb.Text;

                        var servicos = _servicoRepository.GetByMecanico(mecanico);

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

        private void finalServico_btn_Click(object sender, EventArgs e)
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
            try
            {
                var servico = (Servico)allServicos_dgv.CurrentRow.DataBoundItem;

                var pecas = _servicoRepository.GetServicoPecas(servico.Id);

                servicoPecas_dgv.DataSource = pecas;

                ServicoPecasVazio();

                servicoDescricao_tb.Text = servico.Descricao;

                double pecaPreco = 0;
                foreach (var peca in pecas)
                {
                    var preco = peca.Preco * peca.Quantidade;
                    pecaPreco += preco;
                }

                servicoValor_tb.Text = String.Format("{0:C}", servico.Preco);
                servicoPecaValor_tb.Text = String.Format("{0:C}", pecaPreco);

                var total = servico.Preco + pecaPreco;

                servicoValorTotal_tb.Text = String.Format("{0:C}", total);
                if (servico.Ativo != 0)
                {
                    servicoValorTotal_tb.BackColor = Color.PeachPuff;
                }
                else
                {
                    servicoValorTotal_tb.BackColor = Color.PaleGreen;
                }

                EnableServicoControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editarServico_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var servicoEditar = (ServicoModel)allServicos_dgv.CurrentRow.DataBoundItem;
                var editServicoForm = new EditarServicoForm(_servicoRepository, _pecaRepository);

                if (servicoEditar.Ativo == 0)
                {
                    throw new Exception("Servico ja finalizado, impossivel editar!!");
                }
                else
                {
                    editServicoForm.ShowDialog(ref servicoEditar);
                }

                if (editServicoForm.DialogResult == DialogResult.OK)
                {
                    SuccessMsg();
                    DisableServicoControls();
                    LoadServicoData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteServico_btn_Click(object sender, EventArgs e)
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
                    SuccessMsg();
                }

                DisableServicoControls();
                LoadServicoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adicionarPecas_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var servico = (ServicoModel)allServicos_dgv.CurrentRow.DataBoundItem;

                if (servico.Ativo == 0)
                {
                    throw new Exception("Servico Finalizado");
                }

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




        #region ----- Veiculo -----

        private void criarVeiculoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculoForm = new CriarVeiculoForm(_clienteRepository, _veiculoRepository);

                veiculoForm.ShowDialog();

                if (veiculoForm.DialogResult == DialogResult.OK)
                {
                    veiculoForm.Close();
                    SuccessMsg();
                    LoadVeiculoData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allVeiculos_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EnableVeiculoControls();
        }

        private void editVeiculo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = (Veiculo)allVeiculos_dgv.CurrentRow.DataBoundItem;

                if (veiculo.ServicoId > 0)
                {
                    throw new Exception("Error: Veiculo em Servico!");
                }

                var editVeiculoForm = new EditarVeiculoForm(_veiculoRepository);

                editVeiculoForm.ShowDialog(ref veiculo);

                if (editVeiculoForm.DialogResult == DialogResult.OK)
                {
                    editVeiculoForm.Close();

                    SuccessMsg();
                    DisableVeiculoControls();
                    LoadVeiculoData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteVeiculo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = (Veiculo)allVeiculos_dgv.CurrentRow.DataBoundItem;
                int veiculoId = veiculo.Id;

                if (veiculo.ServicoId > 0)
                {
                    throw new Exception("Veiculo em Servico!");
                }

                var message = MessageBox.Show($"Deletar Veiculo?\nVeiculo: {veiculo.Marca} {veiculo.Modelo}" +
                    $"\nPlaca: {veiculo.Placa}", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _veiculoRepository.DeleteVeiculo(veiculoId);
                    SuccessMsg();
                }

                DisableVeiculoControls();
                LoadVeiculoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }

}