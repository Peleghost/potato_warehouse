using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms.PecaForms
{
    public partial class CriarPecaForm : Form
    {
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;

        public CriarPecaForm(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository)
        {
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
            InitializeComponent();
        }

        private void CriarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pecaNome_tb.Text == String.Empty)
                {
                    throw new Exception(message: "Error: Campo Nome nao preenchido.");
                }

                Peca peca = new()
                {
                    Nome = pecaNome_tb.Text,
                    Preco = double.Parse(pecaPreco_tb.Text),
                    Categoria = pecaCategoria_tb.Text
                };

                var pecaId = _pecaRepository.CriarPeca(peca);

                PecaEstoque pecaEstoque = new PecaEstoque()
                {
                    PecaId = pecaId,
                    ArmazenId = 101,
                    Quantidade = Convert.ToInt32(pecaEstoqueNumeric.Value),
                };

                _pecaEstoqueRepository.CriarPecaEstoque(pecaEstoque);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nErro: Formato nao aceito ou campo nao preenchido.");
            }
        }

        //private void pecaPreco_tb_Click(object sender, EventArgs e)
        //{
        //    var pecaPrecoTb = this.pecaPreco_tb;
        //    pecaPrecoTb.Select(6, 0);
            
        //}
    }
}
