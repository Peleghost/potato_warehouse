using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositeries
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;
        private readonly IArmazemRepository _armazemRepository;
        //
        public static int ArmazemId;
        public Form1(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository, IArmazemRepository armazemRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;
            _armazemRepository = armazemRepository;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPecasData();
            CriarArmazemSeNaoExiste();
            labelTotalRecords.Text = $"Total Records: {allPecasDGV.RowCount}";
        }

        private void CriarArmazemSeNaoExiste()
        {
            var armazem = _armazemRepository.GetArmazem();

            if (!armazem.Any())
                ArmazemId = _armazemRepository.CriarArmazem();
            else
                ArmazemId = armazem.FirstOrDefault().Id;
        }

        // Hide columns from DataGridView
        private void allDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPecasDGV.Columns["Id"].Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------

        #region ----- Control Methods / LoadData -----

        // To populate and refresh DataGridView
        public void loadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();
            allPecasDGV.DataSource = pecas;
            labelTotalRecords.Text = $"Total Records: {allPecasDGV.RowCount}";
        }

        // Enable controls
        public void EnablePecaControls()
        {
            venderButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            editNomeTB.Enabled = true;
            editCategoriaTB.Enabled = true;
            editPrecoTB.Enabled = true;
            editQuantidadeNumeric.Enabled = true;
        }

        // Clear Peca Edit TextBoxes
        public void ClearPecaEditTB()
        {
            editNomeTB.Clear();
            editPrecoTB.Clear();
            editCategoriaTB.Clear();
            editQuantidadeNumeric.Value = 0;
        }

        #endregion



        #region ----- Pecas -----
        public void getPecasButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pecas = _pecaRepository.GetPecas();
                allPecasDGV.DataSource = pecas;
                labelTotalRecords.Text = $"Total Records: {allPecasDGV.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void addPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Peca peca = new()
                {
                    Nome = nomeTextBox.Text,
                    Preco = double.Parse(precoTextBox.Text),
                    Categoria = categoriaTextBox.Text
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
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void venderButton_Click(object sender, EventArgs e)
        {

            try
            {
                var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

                var message = MessageBox.Show($"Vender Peca?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}, Quantidade: {peca.Quantidade}",
                    "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.VenderPeca(peca);
                    selectedDataGridView.Columns.Clear();
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
                    Nome = editNomeTB.Text,
                    Preco = Convert.ToDouble(editPrecoTB.Text),
                    Categoria = editCategoriaTB.Text,
                };

                int quantidade = Convert.ToInt32(editQuantidadeNumeric.Value);

                _pecaRepository.EditarPeca(peca, quantidade);

                ClearPecaEditTB();
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
                var message = MessageBox.Show($"Deletar Item?\n Nome: {peca.Nome}, Categoria: {peca.Categoria}",
                    "Confirmar", MessageBoxButtons.OKCancel);

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
            var selectedPeca = (Peca)allPecasDGV.CurrentRow.DataBoundItem;

            EnablePecaControls();

            editNomeTB.Text = selectedPeca.Nome;
            editCategoriaTB.Text = selectedPeca.Categoria;
            editPrecoTB.Text = selectedPeca.Preco.ToString();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchComboBox.Text)
            {
                case "ID":
                    try
                    {
                        var id = Convert.ToInt32(searchTextBox.Text);
                        var peca = _pecaRepository.GetPecaById(id);

                        allPecasDGV.DataSource = peca;
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

                        allPecasDGV.DataSource = pecas;
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

                        allPecasDGV.DataSource = pecas;
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