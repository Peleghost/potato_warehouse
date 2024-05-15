using Potato.Domain.Entities;
using Potato.Domain.Models;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms.Forms.ServicoForms
{
    public partial class EditarServicoForm : Form
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IPecaRepository _pecaRepository;

        private int quantidadePeca;

        public EditarServicoForm(IServicoRepository servicoRepository, IPecaRepository pecaRepository)
        {
            _servicoRepository = servicoRepository;
            _pecaRepository = pecaRepository;
            InitializeComponent();
        }

        public void ShowDialog(ref ServicoModel servicoEditar)
        {
            PopulateEditServicoTb(servicoEditar);

            var pecas = _servicoRepository.GetServicoPecas(servicoEditar.Id);

            editServicoPecas_dgv.DataSource = pecas;

            this.ShowDialog();
        }

        private void EditarServicoForm_Load(object sender, EventArgs e)
        {
            quantidadePeca = Convert.ToInt32(editServicoPecaQtd_numeric.Value);
        }

        private void PopulateEditServicoPecaTb(Peca peca)
        {
            editServicoPecaId_tb.Text = peca.Id.ToString();
            editServicoPecaNome_tb.Text = peca.Nome;
            editServicoPecaCategoria_tb.Text = peca.Categoria;
            editServicoPecaPreco_tb.Text = peca.Preco.ToString();
            editServicoPecaQtd_numeric.Value = peca.Quantidade;
        }

        private void PopulateEditServicoTb(ServicoModel servico)
        {
            editServicoId_tb.Text = servico.Id.ToString();
            editServicoClienteNome_tb.Text = servico.Cliente_Nome;
            editServicoVeiculo_tb.Text = servico.Veiculo_Nome;
            editServicoVeiculoPlaca_tb.Text = servico.Veiculo_Placa;
            editServicoPreco_tb.Text = servico.Preco.ToString();
            editServicoDescricao_tb.Text = servico.Descricao;
        }

        private void editServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int servicoId = Convert.ToInt32(editServicoId_tb.Text);
                string descricao = editServicoDescricao_tb.Text;
                double preco = Convert.ToDouble(editServicoPreco_tb.Text);

                var message = MessageBox.Show($"Editar Servico?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    int newQuantidade = 0;
                    int pecaId = 0;
                    if (editServicoPecaId_tb.Text != "")
                    {
                        newQuantidade = Convert.ToInt32(editServicoPecaQtd_numeric.Value);
                        pecaId = Convert.ToInt32(editServicoPecaId_tb.Text);
                    }

                    if (newQuantidade > quantidadePeca)
                    {
                        int qtdVender = newQuantidade - quantidadePeca;
                        var qtdEstoque = _pecaRepository.GetPecaById(pecaId).FirstOrDefault()!.Quantidade;

                        if (qtdVender > qtdEstoque)
                        {
                            throw new Exception("Quantidade a vender maior que disponivel em estoque");
                        }

                        _pecaRepository.VenderPeca(pecaId, qtdVender);
                        _servicoRepository.UpdateServicoPeca(pecaId, newQuantidade);
                    }
                    else if (newQuantidade < quantidadePeca)
                    {
                        int qtdRepor = quantidadePeca - newQuantidade;

                        _pecaRepository.ReporPeca(pecaId, qtdRepor);
                        _servicoRepository.UpdateServicoPeca(pecaId, newQuantidade);
                    }
                    
                    _servicoRepository.EditarServico(servicoId, descricao, preco);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editarServicoPecas_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var peca = (Peca)editServicoPecas_dgv.CurrentRow.DataBoundItem;

            quantidadePeca = peca.Quantidade;

            PopulateEditServicoPecaTb(peca);
        }

        
    }
}
