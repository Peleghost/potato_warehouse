using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositeries
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;


        public Form1(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPecasData();
            labelTotalRecords.Text = $"Total Records: {allDataGridView.RowCount}";
        }

        // To populate and refresh DataGridView
        public void loadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();
            allDataGridView.DataSource = pecas;
            labelTotalRecords.Text = $"Total Records: {allDataGridView.RowCount}";
        }

        // Hide columns from DataGridView
        private void allDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allDataGridView.Columns["Id"].Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------

        #region ----- Pecas -----
        public void getPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pecas = _pecaRepository.GetPecas();
                allDataGridView.DataSource = pecas;
                labelTotalRecords.Text = $"Total Records: {allDataGridView.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void addPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                var armazenId = new Armazen().Id;

                Peca peca = new Peca()
                {
                    Nome = nomeTextBox.Text,
                    Preco = double.Parse(precoTextBox.Text),
                    Categoria = categoriaTextBox.Text
                };

                var pecaId = _pecaRepository.CriarPeca(peca);

                PecaEstoque pecaEstoque = new PecaEstoque()
                {
                    PecaId = pecaId,
                    ArmazenId = armazenId,
                    Quantidade = Convert.ToInt32(pecaEstoqueNumeric.Value),
                    //Peca = peca
                };

                _pecaEstoqueRepository.CriarPecaEstoque(pecaEstoque);

                loadPecasData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

            try
            {
                var message = MessageBox.Show("Deletar Item?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.DeleteFromDb(peca);
                    selectedDataGridView.Columns.Clear();
                    loadPecasData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void allDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedPeca = (Peca)allDataGridView.CurrentRow.DataBoundItem;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchComboBox.Text)
            {
                case "ID":
                    try
                    {
                        var id = Convert.ToInt32(searchTextBox.Text);
                        var peca = _pecaRepository.GetPecaById(id);

                        allDataGridView.DataSource = peca;
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

                        allDataGridView.DataSource = pecas;
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

                        allDataGridView.DataSource = pecas;
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







        #endregion

        #region ----- Servicos -----





        #endregion

    }

}