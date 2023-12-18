using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Linq.Expressions;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositeries
        private readonly IPecaRepository _pecaRepository;
        private readonly IPecaEstoqueRepository _pecaEstoqueRepository;
        //

        public Form1(IPecaRepository pecaRepository, IPecaEstoqueRepository pecaEstoqueRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
            _pecaEstoqueRepository = pecaEstoqueRepository;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPecasData();
            labelTotalRecords.Text = $"Total Records: {allPecasDGV.RowCount}";
        }

        // Hide columns from DataGridView
        private void allDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPecasDGV.Columns["Id"].Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------

        #region ----- Control Methods / LoadData -----

        // To populate and refresh allPecasDGV
        public void loadPecasData()
        {
            var pecas = _pecaRepository.GetPecas();

            allPecasDGV.DataSource = pecas;

            // Gray rows based on Peca quantidade
            PecaQuantidadeZero();

            labelTotalRecords.Text = $"Total Records: {allPecasDGV.RowCount}";
        }

        public void PecaQuantidadeZero()
        {
            var rows = allPecasDGV.Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                var peca = (Peca)rows[i].DataBoundItem;

                if (peca.Quantidade == 0)
                {
                    rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.LightGray
                    };
                }
            }
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
                loadPecasData();
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
                MessageBox.Show($"Error: {ex.Message}\n\nErro: Formato nao aceito ou campo nao preenchido");
            }
        }

        private void venderButton_Click(object sender, EventArgs e)
        {

            try
            {
                var peca = (Peca)selectedDataGridView.CurrentRow.DataBoundItem;

                if (peca.Quantidade == 0)
                {
                    MessageBox.Show("Fora de Estoque\nQuantidade: 0.\n\nReponha ou Delete Peca", "Confirmar", MessageBoxButtons.OK);
                    return;
                }

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

                var message = MessageBox.Show($"Editar Peca?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _pecaRepository.EditarPeca(peca, quantidade);

                    ClearPecaEditTB();
                    loadPecasData();
                }
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

        public void allPecasDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedPeca = (Peca)allPecasDGV.CurrentRow.DataBoundItem;

            if (selectedPeca.Quantidade == 0)
            {
                allPecasDGV.CurrentRow.Selected = false;
            }

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
                        string criterio = searchComboBox.Text;
                        string nome = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, nome);

                        allPecasDGV.DataSource = pecas;
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
                        string criterio = searchComboBox.Text.ToLower();
                        string categoria = searchTextBox.Text;
                        var pecas = _pecaRepository.GetPecasByNomeOuCategoria(criterio, categoria);

                        allPecasDGV.DataSource = pecas;
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







        #endregion


        #region ----- Servicos -----





        #endregion



    }

}