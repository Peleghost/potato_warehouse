using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using Potato.WindowsForms.Models;
using System.Data;

namespace Potato.WindowsForms
{
    public partial class Form1 : Form
    {
        // Repositeries
        private readonly IPecaRepository _pecaRepository;


        public Form1(IPecaRepository pecaRepository)
        {
            InitializeComponent();
            _pecaRepository = pecaRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            labelTotalRecords.Text = $"Total Records: {allDataGridView.RowCount}";
        }

        // To populate and refresh DataGridView
        public void loadData()
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
                Peca peca = new Peca()
                {
                    Nome = nomeTextBox.Text,
                    Preco = double.Parse(precoTextBox.Text),
                    Categoria = categoriaTextBox.Text
                };

                _pecaRepository.CriarPeca(peca);
                loadData();
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
                    loadData();
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
            if (searchComboBox.Text == "ID")
            {
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
            }

            if (searchComboBox.Text == "Categoria")
            {
                try
                {
                    string categoria = searchTextBox.Text;
                    var pecas = _pecaRepository.GetPecasByCategoria(categoria);

                    allDataGridView.DataSource = pecas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }

}