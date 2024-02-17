using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.ComponentModel;

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

        public void ShowDialog(ref BindingList<Peca> pecas)
        {
            venderPeca_dgv.DataSource = pecas;
            double preco = 0;

            foreach (Peca peca in pecas) 
            { 
                preco += peca.Preco * peca.Quantidade;
            }

            vendaTotal_tb.Text = $"{preco:C}";

            this.ShowDialog();
        }

        private void venderPecaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var message = MessageBox.Show("Confirmar Venda?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    int pecaId, quantidade;
                    var pecas = venderPeca_dgv.DataSource as BindingList<Peca>;

                    foreach (var peca in pecas)
                    {
                        try
                        {
                            pecaId = peca.Id;
                            quantidade = peca.Quantidade;

                            _pecaRepository.VenderPeca(pecaId, quantidade);
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void venderPeca_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            venderPeca_dgv.Columns["id"].Visible = false;
            venderPeca_dgv.Columns["armazen"].Visible = false;
        }

    }

}
