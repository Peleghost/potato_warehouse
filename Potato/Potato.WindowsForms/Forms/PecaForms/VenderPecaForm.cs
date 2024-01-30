using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms.Forms.PecaForms
{
    public partial class VenderPecaForm : Form
    {
        private readonly IPecaRepository _pecaRepository;

        public VenderPecaForm(IPecaRepository pecaRepository)
        {
            _pecaRepository = pecaRepository;
            InitializeComponent();
        }

        public void PopulateVenderPecaTb(Peca peca)
        {
            venderPecaNome_tb.Text = peca.Nome;
            venderPecaPreco_tb.Text = peca.Preco.ToString();
            venderPecaCategoria_tb.Text = peca.Categoria;
            venderPecaQtdEstoque_numeric.Value = peca.Quantidade;
            venderPecaId_tb.Text = peca.Id.ToString();
        }

        public void ShowDialog(ref Peca peca)
        {
            PopulateVenderPecaTb(peca);

            this.ShowDialog();
        }

        private void venderPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pecaId = Convert.ToInt32(venderPecaId_tb.Text);
                var quantidadeEstoque = venderPecaQtdEstoque_numeric.Value;
                var quantidadeVender = Convert.ToInt32(venderPecaQuantidade_numeric.Value);

                if (quantidadeVender > quantidadeEstoque)
                {
                    throw new Exception("Error: Quantidade a vender maior que disponivel em Estoque!");
                }
                else if (quantidadeVender == 0)
                {
                    throw new Exception("Error: Quantidade nao especificada!");
                }
                else
                {
                    _pecaRepository.VenderPeca(pecaId, quantidadeVender);
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
