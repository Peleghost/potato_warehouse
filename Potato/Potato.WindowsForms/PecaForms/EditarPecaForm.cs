using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms.PecaForms
{
    public partial class EditarPecaForm : Form
    {
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;

        public EditarPecaForm(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository)
        {
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
            InitializeComponent();
        }

        public void ShowDialog(ref DataGridViewRow pecaEditar)
        {
            var peca = (Peca)pecaEditar.DataBoundItem;

            editPecaId_tb.Text = peca.Id.ToString();
            editPecaNome_tb.Text = peca.Nome;
            editPecaCategoria_tb.Text = peca.Categoria;
            editPecaPreco_tb.Text = peca.Preco.ToString();
            editPecaQtdNumeric.Value = peca.Quantidade;

            this.ShowDialog();
        }

        private void editPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var peca = new Peca()
                {
                    Id = Convert.ToInt32(editPecaId_tb.Text),
                    Nome = editPecaNome_tb.Text,
                    Preco = Convert.ToDouble(editPecaPreco_tb.Text),
                    Categoria = editPecaCategoria_tb.Text,
                };

                int quantidade = Convert.ToInt32(editPecaQtdNumeric.Value);

                var message = MessageBox.Show($"Editar Peca?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.EditarPeca(peca, quantidade);

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
