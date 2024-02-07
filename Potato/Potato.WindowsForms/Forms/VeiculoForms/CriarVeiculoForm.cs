using Potato.Domain.Entities;
using Potato.Domain.Repositories;
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
    public partial class CriarVeiculoForm : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IVeiculoRepository _veiculoRepository;

        public CriarVeiculoForm(IClienteRepository clienteRepository, IVeiculoRepository veiculoRepository)
        {
            _clienteRepository = clienteRepository;
            _veiculoRepository = veiculoRepository;
            InitializeComponent();
        }

        private int _clienteId = 0;

        public void PopulateVeiculoClienteTb(Cliente cliente)
        {
            veiculoClienteNome_tb.Text = cliente.Nome;
            veiculoClienteSobrenome_tb.Text = cliente.Sobrenome;
            veiculoClienteTelefone_tb.Text = cliente.Telefone;
        }

        private void CriarVeiculoForm_Load(object sender, EventArgs e)
        {
            var clientes = _clienteRepository.GetClientes();

            criarVeiculoClientes_dgv.DataSource = clientes;
        }

        private void searchVeiculoClientes_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = searchVeiculoClientes_tb.Text;
                var cliente = _clienteRepository.GetClienteByNome(nome);

                criarVeiculoClientes_dgv.DataSource = cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void listarVeiculoClientes_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var clientes = _clienteRepository.GetClientes();

                criarVeiculoClientes_dgv.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void criarVeiculoClientes_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cliente = (Cliente)criarVeiculoClientes_dgv.CurrentRow.DataBoundItem;

            _clienteId = cliente.Id;

            PopulateVeiculoClienteTb(cliente);
        }

        private void cadastrarVeiculo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteId == 0)
                {
                    throw new Exception("Selecionar cliente para cadastro de Veiculo.");
                }

                var regex = new Regex("[A-Z][0-9]");
                var placa = criarVeiculoPlaca_tb.Text;

                if (!regex.IsMatch(placa))
                {
                    throw new Exception("Campo Placa nao preenchido corretamente");
                }

                var veiculoExiste = _veiculoRepository.VerificarPlaca(placa);

                if (veiculoExiste > 0)
                {
                    throw new Exception($"Error: Veciulo de Placa: {placa} ja existe.");
                }

                var veiculo = new Veiculo()
                {
                    Marca = criarVeiculoMarca_tb.Text,
                    Modelo = criarVeiculoModelo_tb.Text,
                    Cor = criarVeiculoCor_tb.Text,
                    Ano = criarVeiculoAno_tb.Text,
                    Placa = criarVeiculoPlaca_tb.Text,
                    ClienteId = _clienteId
                };

                _veiculoRepository.CriarVeiculo(veiculo);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void criarVeiculoClientes_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            criarVeiculoClientes_dgv.Columns["ativo"].Visible = false;
            criarVeiculoClientes_dgv.Columns["id"].Visible = false;
            criarVeiculoClientes_dgv.Columns["servicoId"].Visible = false;
            criarVeiculoClientes_dgv.Columns["dataCriacao"].Visible = false;
            criarVeiculoClientes_dgv.Columns["datafinal"].Visible = false;
        }
    }
}
