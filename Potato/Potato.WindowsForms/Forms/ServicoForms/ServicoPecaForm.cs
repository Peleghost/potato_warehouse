using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Potato.WindowsForms.Forms.ServicoForms
{
    public partial class ServicoPecaForm : Form
    {
        private readonly IPecaRepository _pecaRepository;
        private readonly IServicoRepository _servicoRepository;
        private readonly IClienteRepository _clienteRepository;

        public ServicoPecaForm(IPecaRepository pecaRepository, IClienteRepository clienteRepository, IServicoRepository servicoRepository)
        {
            _pecaRepository = pecaRepository;
            _servicoRepository = servicoRepository;
            _clienteRepository = clienteRepository;
            InitializeComponent();
        }

        // Global List Pecas
        private BindingList<Peca> pecas = new();

        private void PopulateServicoPecaFormTb(Servico servico)
        {
            servicoPecaCliente_tb.Text = servico.Cliente_Nome;
            servicoPecaVeiculo_tb.Text = servico.Veiculo_Nome;
            servicoPecaPlaca_tb.Text = servico.Veiculo_Placa;
            servicoPecaServicoId_tb.Text = servico.Id.ToString();
        }

        private void PopulateServicoPecaRevisaoTb(Peca peca)
        {
            servicoPecaNome_tb.Text = peca.Nome;
            servicoPecaCategoria_tb.Text = peca.Categoria;
            servicoPecaPreco_tb.Text = peca.Preco.ToString();
        }

        private void PecaQuantidadeZero()
        {
            var rows = servicoPeca_dgv.Rows;

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

        private void LoadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();

            servicoPeca_dgv.DataSource = pecas;

            PecaQuantidadeZero();
        }

        public void ShowDialog(ref Servico servico)
        {
            PopulateServicoPecaFormTb(servico);
            servicoPeca_dgv.DataSource = _pecaRepository.GetPecas();

            this.ShowDialog();
        }

        private void servicoPeca_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            servicoPeca_dgv.Columns["id"].Visible = false;
            servicoPeca_dgv.Columns["armazen"].Visible = false;
        }

        private void servicoPeca_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var peca = (Peca)servicoPeca_dgv.CurrentRow.DataBoundItem;

                PopulateServicoPecaRevisaoTb(peca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoPecaSearchPecaButton_Click(object sender, EventArgs e)
        {
            switch (servicoPecaSearchPeca_combo.Text)
            {
                case "ID":
                    try
                    {
                        var id = Convert.ToInt32(servicoPecaSearchTextBox.Text);
                        var peca = _pecaRepository.GetPecaById(id);

                        servicoPeca_dgv.DataSource = peca;
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
                        string criterio = servicoPecaSearchPeca_combo.Text;
                        string nome = servicoPecaSearchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, nome);

                        servicoPeca_dgv.DataSource = pecas;
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
                        string criterio = servicoPecaSearchPeca_combo.Text.ToLower();
                        string categoria = servicoPecaSearchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, categoria);

                        servicoPeca_dgv.DataSource = pecas;
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

        private void servicoPecaListarPecasButton_Click(object sender, EventArgs e)
        {
            LoadPecasData();
        }

        private void servicoPecaAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)servicoPeca_dgv.CurrentRow.DataBoundItem;
                int quantidade;

                if (servicoPecaQuantidade_numeric.Value > peca.Quantidade)
                {
                    throw new Exception("Error: Impossivel adicionar peca com quantidade maior que disponivel em estoque!");
                }
                else if (servicoPecaQuantidade_numeric.Value == 0)
                {
                    throw new Exception("Error: Quantidade nao especificada!");
                }
                else
                {
                    quantidade = Convert.ToInt32(servicoPecaQuantidade_numeric.Value);
                }

                var newPeca = new Peca()
                {
                    Id = peca.Id,
                    Nome = peca.Nome,
                    Categoria = peca.Categoria,
                    Preco = peca.Preco,
                    Quantidade = quantidade
                };

                foreach (var item in pecas)
                {
                    if (item.Id == newPeca.Id)
                    {
                        throw new Exception("Error: Peca ja adicionada!");
                    }
                }

                pecas.Add(newPeca);

                servicoPecaAdicionar_dgv.DataSource = pecas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoPecaRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = (Peca)servicoPecaAdicionar_dgv.CurrentRow.DataBoundItem;

                var index = pecas.IndexOf(peca);

                pecas.RemoveAt(index);

                servicoPecaAdicionar_dgv.DataSource = pecas;

                servicoPecaRemoveButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoPecaFinalizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int servicoId = Convert.ToInt32(servicoPecaServicoId_tb.Text);

                foreach (var peca in pecas)
                {
                    _servicoRepository.InsertServicoPeca(peca.Id, servicoId, peca.Quantidade);
                    _pecaRepository.VenderPeca(peca.Id, peca.Quantidade);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void servicoPecaAdicionar_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            servicoPecaAdicionar_dgv.Columns["armazen"].Visible = false;
        }

        private void servicoPecaAdicionar_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            servicoPecaRemoveButton.Enabled = true;
        }

        
    }
}
