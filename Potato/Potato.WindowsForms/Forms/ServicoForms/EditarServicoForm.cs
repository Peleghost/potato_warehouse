using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potato.WindowsForms.Forms.ServicoForms
{
    public partial class EditarServicoForm : Form
    {
        private readonly IServicoRepository _servicoRepository;

        public EditarServicoForm(IServicoRepository servicoRepository)
        {
            _servicoRepository = servicoRepository;
            InitializeComponent();
        }

        private void EditServicoTbControls(Servico servico)
        {
            editServicoId_tb.Text = servico.Id.ToString();
            editServicoClienteNome_tb.Text = servico.Cliente_Nome;
            editServicoVeiculo_tb.Text = servico.Veiculo_Nome;
            editServicoVeiculoPlaca_tb.Text = servico.Veiculo_Placa;
            editServicoPreco_tb.Text = servico.Preco.ToString();
            editServicoDescricao_tb.Text = servico.Descricao;
        }

        public void ShowDialog(ref Servico servicoEditar)
        {
            //var servico = (Servico)servicoEditar.DataBoundItem;
            EditServicoTbControls(servicoEditar);
            
            this.ShowDialog();
        }

        private void editClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int servicoId = Convert.ToInt32(editServicoId_tb.Text);
                string descricao = editServicoDescricao_tb.Text;
                double preco = Convert.ToDouble(editServicoPreco_tb.Text);

                var message = MessageBox.Show($"Editar Servico?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _servicoRepository.EditarServico(servicoId, descricao, preco);

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
