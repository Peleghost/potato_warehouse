﻿using Potato.Domain.Entities;
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
    public partial class CriarServicoForm : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IServicoRepository _servicoRepository;
        public CriarServicoForm(IClienteRepository clienteRepository, IVeiculoRepository veiculoRepository, IServicoRepository servicoRepository)
        {
            _clienteRepository = clienteRepository;
            _veiculoRepository = veiculoRepository;
            InitializeComponent();
            _servicoRepository = servicoRepository;
        }

        public void ShowDialog(ref Cliente cliente)
        {
            ServicoClienteTbControls(cliente);

            this.ShowDialog();
        }

        public void LoadClienteVeiculos()
        {
            var clienteId = Convert.ToInt32(servicoClienteId_tb.Text);

            var veiculos = _veiculoRepository.GetVeiculoByClienteId(clienteId);

            servicoVeiculo_dgv.DataSource = veiculos;
        }

        // Controls
        public void ServicoClienteTbControls(Cliente cliente)
        {
            servicoClienteNome_tb.Text = cliente.Nome;
            servicoClienteSobrenome_tb.Text = cliente.Sobrenome;
            servicoClienteTelefone_tb.Text = cliente.Telefone;
            servicoClienteId_tb.Text = cliente.Id.ToString();
        }

        private void PopulateServicoVeiculoTb(Veiculo veiculo)
        {
            servicoVeiculoMarca_tb.Text = veiculo.Marca;
            servicoVeiculoModelo_tb.Text = veiculo.Modelo;
            servicoVeiculoCor_tb.Text = veiculo.Cor;
            servicoVeiculoAno_datePicker.Text = veiculo.Ano;
            servicoVeiculoPlaca_tb.Text = veiculo.Placa;
            //servicoVeiculoId_tb.Text = veiculo.Id.ToString();
        }

        private void EnableControls()
        {
            servicoVeiculoMarca_tb.Enabled = true;
            servicoVeiculoModelo_tb.Enabled = true;
            servicoVeiculoCor_tb.Enabled = true;
            servicoVeiculoAno_datePicker.Enabled = true;
            servicoVeiculoPlaca_tb.Enabled = true;
            cadastrarVeiculoButton.Enabled = true;
        }

        private void DisableControls()
        {
            servicoVeiculoMarca_tb.Clear();
            servicoVeiculoModelo_tb.Clear();
            servicoVeiculoCor_tb.Clear();
            servicoVeiculoPlaca_tb.Clear();

            servicoVeiculoMarca_tb.Enabled = false;
            servicoVeiculoModelo_tb.Enabled = false;
            servicoVeiculoCor_tb.Enabled = false;
            servicoVeiculoPlaca_tb.Enabled = false;
            cadastrarVeiculoButton.Enabled = false;
        }
        //

        private void servicoNovoVeiculo_check_CheckedChanged(object sender, EventArgs e)
        {
            if (servicoNovoVeiculo_check.CheckState == CheckState.Checked)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        private void cadastrarVeiculoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicoNovoVeiculo_check.Checked == true)
                {
                    var clienteId = Convert.ToInt32(servicoClienteId_tb.Text);

                    var veiculo = new Veiculo()
                    {
                        Marca = servicoVeiculoMarca_tb.Text,
                        Modelo = servicoVeiculoModelo_tb.Text,
                        Cor = servicoVeiculoCor_tb.Text,
                        Ano = servicoVeiculoAno_datePicker.Text,
                        Placa = servicoVeiculoPlaca_tb.Text,
                        ClienteId = clienteId,
                    };

                    var veiculoExiste = _veiculoRepository.VerificarPlaca(veiculo.Placa);

                    if (veiculoExiste > 0)
                    {
                        throw new Exception($"Error: Veciulo de Placa: {veiculo.Placa} ja existe.");
                    }

                    var veiculoId = _veiculoRepository.CriarVeiculo(veiculo);

                    _veiculoRepository.UpdateVeiculoClienteId(clienteId, veiculoId);

                    MessageBox.Show("Successo", "Confirmar", MessageBoxButtons.OK);
                    LoadClienteVeiculos();

                    DisableControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CriarServicoForm_Load(object sender, EventArgs e)
        {
            LoadClienteVeiculos();
        }

        private void servicoVeiculo_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            servicoVeiculo_dgv.Columns["Id"].Visible = false;
            servicoVeiculo_dgv.Columns["ClienteId"].Visible = false;
            servicoVeiculo_dgv.Columns["ServicoId"].Visible = false;
        }

        private void servicoVeiculo_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var veiculo = (Veiculo)servicoVeiculo_dgv.CurrentRow.DataBoundItem;

            PopulateServicoVeiculoTb(veiculo);
        }

        private void criarServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteId = Convert.ToInt32(servicoClienteId_tb.Text);

                var cliente = _clienteRepository.GetClienteById(clienteId);

                var veiculo = (Veiculo)servicoVeiculo_dgv.CurrentRow.DataBoundItem;

                var veiculoEmServico = _veiculoRepository.VerificarVeiculoEmServico(veiculo.Id);

                if (veiculoEmServico)
                {
                    throw new Exception("Veiculo em servico.");
                }

                string descricao = servicoDescricao_tb.Text;

                double preco = Convert.ToDouble(servicoPreco_tb.Text);

                var temp = Servico.Criar(cliente, veiculo, descricao, preco, 1);

                if (temp.IsSuccess)
                {
                    temp.Value.DataCriacao = DateTime.UtcNow;

                    var servico = temp.Value;

                    int servicoId = _servicoRepository.CriarServico(servico);
                    _veiculoRepository.UpdateVeiculoServicoId(servicoId, veiculo.Id);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
