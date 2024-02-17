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
                string nome, categoria;

                if (pecaNome_tb.Text.Trim() == string.Empty || pecaCategoria_tb.Text.Trim() == string.Empty)
                {
                    throw new Exception("Campos Nome ou Categoria nao preenchido.");
                }
                else
                {
                    string tempNome = pecaNome_tb.Text.Trim();
                    string tempCategoria = pecaCategoria_tb.Text.Trim();

                    nome = char.ToUpper(tempNome[0]) + tempNome.Substring(1);
                    categoria = char.ToUpper(tempCategoria[0]) + tempCategoria.Substring(1);
                }

                Peca peca = new()
                {
                    Nome = nome,
                    Preco = double.Parse(pecaPreco_tb.Text),
                    Categoria = categoria
                };

                var pecaId = _pecaRepository.CriarPeca(peca);

                PecaEstoque pecaEstoque = new PecaEstoque()
                {
                    PecaId = pecaId,
                    ArmazenId = 1,
                    Quantidade = Convert.ToInt32(pecaEstoqueNumeric.Value),
                };

                _pecaEstoqueRepository.CriarPecaEstoque(pecaEstoque);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nError: Formato nao aceito ou campo nao preenchido.");
            }
        }
    }
}
