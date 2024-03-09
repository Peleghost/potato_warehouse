using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Text.RegularExpressions;

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

        private void CriarServicoForm_Load(object sender, EventArgs e)
        {
            LoadClienteVeiculos();
        }

        private void servicoVeiculo_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            servicoVeiculo_dgv.Columns["Id"].Visible = false;
            servicoVeiculo_dgv.Columns["Cliente"].Visible = false;
            servicoVeiculo_dgv.Columns["ClienteId"].Visible = false;
            servicoVeiculo_dgv.Columns["ServicoId"].Visible = false;
        }

        private void LoadClienteVeiculos()
        {
            var clienteId = Convert.ToInt32(servicoClienteId_tb.Text);

            var veiculos = _veiculoRepository.GetVeiculoByClienteId(clienteId);

            servicoVeiculo_dgv.DataSource = veiculos;
        }

        // Controls
        private void ServicoClienteTbControls(Cliente cliente)
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
            servicoVeiculoAno_tb.Text = veiculo.Ano;
            servicoVeiculoPlaca_tb.Text = veiculo.Placa;
            //servicoVeiculoId_tb.Text = veiculo.Id.ToString();
        }

        private void EnableControls()
        {
            servicoVeiculoMarca_tb.Enabled = true;
            servicoVeiculoModelo_tb.Enabled = true;
            servicoVeiculoCor_tb.Enabled = true;
            servicoVeiculoAno_tb.Enabled = true;
            servicoVeiculoPlaca_tb.Enabled = true;
            cadastrarVeiculoButton.Enabled = true;
        }

        private void DisableControls()
        {
            servicoVeiculoMarca_tb.Clear();
            servicoVeiculoModelo_tb.Clear();
            servicoVeiculoCor_tb.Clear();
            servicoVeiculoAno_tb.Clear();
            servicoVeiculoPlaca_tb.Clear();

            servicoVeiculoMarca_tb.Enabled = false;
            servicoVeiculoModelo_tb.Enabled = false;
            servicoVeiculoCor_tb.Enabled = false;
            servicoVeiculoAno_tb.Enabled = false;
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
                if (servicoNovoVeiculo_check.Checked)
                {
                    var clienteId = Convert.ToInt32(servicoClienteId_tb.Text);

                    string placa = servicoVeiculoPlaca_tb.Text;

                    var regex = new Regex("[A-Z][0-9]");

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
                        Marca = servicoVeiculoMarca_tb.Text,
                        Modelo = servicoVeiculoModelo_tb.Text,
                        Cor = servicoVeiculoCor_tb.Text,
                        Ano = servicoVeiculoAno_tb.Text,
                        Placa = placa,
                        ClienteId = clienteId,
                    };

                    _veiculoRepository.CriarVeiculo(veiculo);

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

        private void servicoVeiculo_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var veiculo = (Veiculo)servicoVeiculo_dgv.CurrentRow.DataBoundItem;

            servicoDescricao_tb.Text = $"********************\nCliente Id: {veiculo.ClienteId} \nVeiculo: {veiculo.Marca} {veiculo.Modelo}" +
                $"\n********************\n";

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

                if (servicoMecanico_combo.Text == "")
                {
                    throw new Exception("Error: Favor selecionar Mecanico Responsavel!");
                }

                string descricao = servicoDescricao_tb.Text;

                string mecanico = servicoMecanico_combo.Text;

                double preco = Convert.ToDouble(servicoPreco_tb.Text);

                var temp = Servico.Criar(cliente, veiculo, descricao, mecanico, preco, 1);

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
