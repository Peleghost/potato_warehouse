using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using Potato.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potato.WindowsForms.Forms.VeiculoForms
{
    public partial class EditarVeiculoForm : Form
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public EditarVeiculoForm(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
            InitializeComponent();
        }

        private void PopulateVeiculoTb(Veiculo veiculo)
        {
            editarVeiculoId_tb.Text = veiculo.Id.ToString();
            editarVeiculoMarca_tb.Text = veiculo.Marca;
            editarVeiculoModelo_tb.Text = veiculo.Modelo;
            editarVeiculoCor_tb.Text = veiculo.Cor;
            editarVeiculoAno_tb.Text = veiculo.Ano;
            editarVeiculoPlaca_tb.Text = veiculo.Placa;
        }

        public void ShowDialog(ref Veiculo veiculo)
        {
            PopulateVeiculoTb(veiculo);

            this.ShowDialog();
        }

        private void ConfirmarEditVeiculo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var regex = new Regex("[A-Z][0-9]");
                string placa = editarVeiculoPlaca_tb.Text;

                if (!regex.IsMatch(placa))
                {
                    throw new Exception("Error: Campo Placa nao preenchido corretamente");
                }

                var veiculoExiste = _veiculoRepository.VerificarPlaca(placa);

                if (veiculoExiste > 0)
                {
                    throw new Exception($"Error: Veciulo de Placa: {placa} ja existe.");
                }

                var veiculo = new Veiculo() 
                {
                    Id = Convert.ToInt32(editarVeiculoId_tb.Text),
                    Marca = editarVeiculoMarca_tb.Text,
                    Modelo = editarVeiculoModelo_tb.Text,
                    Cor = editarVeiculoCor_tb.Text,
                    Ano = editarVeiculoAno_tb.Text,
                    Placa = placa
                };

                var message = MessageBox.Show($"Editar Veiculo?", "Confirmar", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    _veiculoRepository.EditarVeiculo(veiculo);

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
