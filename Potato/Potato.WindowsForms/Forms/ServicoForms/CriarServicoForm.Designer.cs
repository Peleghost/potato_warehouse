namespace Potato.WindowsForms.Forms.ServicoForms
{
    partial class CriarServicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            servicoCliente_gb = new GroupBox();
            label6 = new Label();
            servicoClienteId_tb = new TextBox();
            servicoClienteTelefone_tb = new MaskedTextBox();
            label3 = new Label();
            label7 = new Label();
            servicoClienteSobrenome_tb = new TextBox();
            label8 = new Label();
            servicoClienteNome_tb = new TextBox();
            servicoVeiculo_gb = new GroupBox();
            servicoVeiculo_dgv = new DataGridView();
            servicoVeiculoAno_tb = new MaskedTextBox();
            servicoVeiculoId_tb = new TextBox();
            servicoVeiculoId_label = new Label();
            cadastrarVeiculoButton = new Button();
            servicoVeiculoPlaca_tb = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            servicoVeiculoCor_tb = new TextBox();
            label2 = new Label();
            servicoVeiculoModelo_tb = new TextBox();
            label1 = new Label();
            servicoVeiculoMarca_tb = new TextBox();
            servicoVeiculoMarca_label = new Label();
            servicoNovoVeiculo_check = new CheckBox();
            groupBox1 = new GroupBox();
            criarServicoButton = new Button();
            label9 = new Label();
            servicoPreco_tb = new TextBox();
            groupBox2 = new GroupBox();
            servicoDescricao_tb = new RichTextBox();
            servicoCliente_gb.SuspendLayout();
            servicoVeiculo_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoVeiculo_dgv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // servicoCliente_gb
            // 
            servicoCliente_gb.Controls.Add(label6);
            servicoCliente_gb.Controls.Add(servicoClienteId_tb);
            servicoCliente_gb.Controls.Add(servicoClienteTelefone_tb);
            servicoCliente_gb.Controls.Add(label3);
            servicoCliente_gb.Controls.Add(label7);
            servicoCliente_gb.Controls.Add(servicoClienteSobrenome_tb);
            servicoCliente_gb.Controls.Add(label8);
            servicoCliente_gb.Controls.Add(servicoClienteNome_tb);
            servicoCliente_gb.Location = new Point(6, 21);
            servicoCliente_gb.Name = "servicoCliente_gb";
            servicoCliente_gb.Size = new Size(476, 131);
            servicoCliente_gb.TabIndex = 0;
            servicoCliente_gb.TabStop = false;
            servicoCliente_gb.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 103);
            label6.Name = "label6";
            label6.Size = new Size(25, 14);
            label6.TabIndex = 83;
            label6.Text = "Id:";
            label6.Visible = false;
            // 
            // servicoClienteId_tb
            // 
            servicoClienteId_tb.Location = new Point(109, 100);
            servicoClienteId_tb.Name = "servicoClienteId_tb";
            servicoClienteId_tb.ReadOnly = true;
            servicoClienteId_tb.Size = new Size(176, 22);
            servicoClienteId_tb.TabIndex = 82;
            servicoClienteId_tb.UseSystemPasswordChar = true;
            servicoClienteId_tb.Visible = false;
            // 
            // servicoClienteTelefone_tb
            // 
            servicoClienteTelefone_tb.Location = new Point(109, 72);
            servicoClienteTelefone_tb.Mask = "(00) 00000-0000";
            servicoClienteTelefone_tb.Name = "servicoClienteTelefone_tb";
            servicoClienteTelefone_tb.ReadOnly = true;
            servicoClienteTelefone_tb.Size = new Size(259, 22);
            servicoClienteTelefone_tb.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 80;
            label3.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(84, 14);
            label7.TabIndex = 79;
            label7.Text = "Sobrenome:";
            // 
            // servicoClienteSobrenome_tb
            // 
            servicoClienteSobrenome_tb.Location = new Point(109, 45);
            servicoClienteSobrenome_tb.Name = "servicoClienteSobrenome_tb";
            servicoClienteSobrenome_tb.ReadOnly = true;
            servicoClienteSobrenome_tb.Size = new Size(259, 22);
            servicoClienteSobrenome_tb.TabIndex = 78;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 21);
            label8.Name = "label8";
            label8.Size = new Size(48, 14);
            label8.TabIndex = 77;
            label8.Text = "Nome:";
            // 
            // servicoClienteNome_tb
            // 
            servicoClienteNome_tb.Location = new Point(109, 19);
            servicoClienteNome_tb.Name = "servicoClienteNome_tb";
            servicoClienteNome_tb.ReadOnly = true;
            servicoClienteNome_tb.Size = new Size(259, 22);
            servicoClienteNome_tb.TabIndex = 76;
            // 
            // servicoVeiculo_gb
            // 
            servicoVeiculo_gb.Controls.Add(servicoVeiculo_dgv);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoAno_tb);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoId_tb);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoId_label);
            servicoVeiculo_gb.Controls.Add(cadastrarVeiculoButton);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoPlaca_tb);
            servicoVeiculo_gb.Controls.Add(label5);
            servicoVeiculo_gb.Controls.Add(label4);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoCor_tb);
            servicoVeiculo_gb.Controls.Add(label2);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoModelo_tb);
            servicoVeiculo_gb.Controls.Add(label1);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoMarca_tb);
            servicoVeiculo_gb.Controls.Add(servicoVeiculoMarca_label);
            servicoVeiculo_gb.Controls.Add(servicoNovoVeiculo_check);
            servicoVeiculo_gb.Location = new Point(12, 12);
            servicoVeiculo_gb.Name = "servicoVeiculo_gb";
            servicoVeiculo_gb.Size = new Size(481, 516);
            servicoVeiculo_gb.TabIndex = 1;
            servicoVeiculo_gb.TabStop = false;
            servicoVeiculo_gb.Text = "Veiculo";
            // 
            // servicoVeiculo_dgv
            // 
            servicoVeiculo_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicoVeiculo_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicoVeiculo_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            servicoVeiculo_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            servicoVeiculo_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoVeiculo_dgv.Dock = DockStyle.Top;
            servicoVeiculo_dgv.EnableHeadersVisualStyles = false;
            servicoVeiculo_dgv.Location = new Point(3, 18);
            servicoVeiculo_dgv.Name = "servicoVeiculo_dgv";
            servicoVeiculo_dgv.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new Padding(3);
            servicoVeiculo_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            servicoVeiculo_dgv.RowTemplate.Height = 25;
            servicoVeiculo_dgv.Size = new Size(475, 209);
            servicoVeiculo_dgv.TabIndex = 54;
            servicoVeiculo_dgv.DataBindingComplete += servicoVeiculo_dgv_DataBindingComplete;
            servicoVeiculo_dgv.RowHeaderMouseDoubleClick += servicoVeiculo_dgv_RowHeaderMouseDoubleClick;
            // 
            // servicoVeiculoAno_tb
            // 
            servicoVeiculoAno_tb.Enabled = false;
            servicoVeiculoAno_tb.Location = new Point(190, 378);
            servicoVeiculoAno_tb.Mask = "0000";
            servicoVeiculoAno_tb.Name = "servicoVeiculoAno_tb";
            servicoVeiculoAno_tb.Size = new Size(148, 22);
            servicoVeiculoAno_tb.TabIndex = 53;
            // 
            // servicoVeiculoId_tb
            // 
            servicoVeiculoId_tb.Enabled = false;
            servicoVeiculoId_tb.Location = new Point(190, 266);
            servicoVeiculoId_tb.Name = "servicoVeiculoId_tb";
            servicoVeiculoId_tb.Size = new Size(148, 22);
            servicoVeiculoId_tb.TabIndex = 51;
            servicoVeiculoId_tb.UseSystemPasswordChar = true;
            servicoVeiculoId_tb.Visible = false;
            // 
            // servicoVeiculoId_label
            // 
            servicoVeiculoId_label.AutoSize = true;
            servicoVeiculoId_label.Location = new Point(110, 269);
            servicoVeiculoId_label.Name = "servicoVeiculoId_label";
            servicoVeiculoId_label.Size = new Size(25, 14);
            servicoVeiculoId_label.TabIndex = 50;
            servicoVeiculoId_label.Text = "Id:";
            servicoVeiculoId_label.Visible = false;
            // 
            // cadastrarVeiculoButton
            // 
            cadastrarVeiculoButton.Anchor = AnchorStyles.None;
            cadastrarVeiculoButton.BackColor = Color.LightSeaGreen;
            cadastrarVeiculoButton.Enabled = false;
            cadastrarVeiculoButton.FlatStyle = FlatStyle.Flat;
            cadastrarVeiculoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarVeiculoButton.ForeColor = Color.White;
            cadastrarVeiculoButton.Location = new Point(110, 461);
            cadastrarVeiculoButton.Name = "cadastrarVeiculoButton";
            cadastrarVeiculoButton.Size = new Size(228, 49);
            cadastrarVeiculoButton.TabIndex = 49;
            cadastrarVeiculoButton.Text = "Cadastrar Veiculo";
            cadastrarVeiculoButton.UseVisualStyleBackColor = false;
            cadastrarVeiculoButton.Click += cadastrarVeiculoButton_Click;
            // 
            // servicoVeiculoPlaca_tb
            // 
            servicoVeiculoPlaca_tb.Enabled = false;
            servicoVeiculoPlaca_tb.Location = new Point(190, 407);
            servicoVeiculoPlaca_tb.Mask = "AAAAAAA";
            servicoVeiculoPlaca_tb.Name = "servicoVeiculoPlaca_tb";
            servicoVeiculoPlaca_tb.Size = new Size(148, 22);
            servicoVeiculoPlaca_tb.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 410);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 11;
            label5.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 381);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 8;
            label4.Text = "Ano:";
            // 
            // servicoVeiculoCor_tb
            // 
            servicoVeiculoCor_tb.Enabled = false;
            servicoVeiculoCor_tb.Location = new Point(190, 350);
            servicoVeiculoCor_tb.Name = "servicoVeiculoCor_tb";
            servicoVeiculoCor_tb.Size = new Size(148, 22);
            servicoVeiculoCor_tb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 353);
            label2.Name = "label2";
            label2.Size = new Size(34, 14);
            label2.TabIndex = 6;
            label2.Text = "Cor:";
            // 
            // servicoVeiculoModelo_tb
            // 
            servicoVeiculoModelo_tb.Enabled = false;
            servicoVeiculoModelo_tb.Location = new Point(190, 322);
            servicoVeiculoModelo_tb.Name = "servicoVeiculoModelo_tb";
            servicoVeiculoModelo_tb.Size = new Size(148, 22);
            servicoVeiculoModelo_tb.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 326);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 4;
            label1.Text = "Modelo:";
            // 
            // servicoVeiculoMarca_tb
            // 
            servicoVeiculoMarca_tb.Enabled = false;
            servicoVeiculoMarca_tb.Location = new Point(190, 294);
            servicoVeiculoMarca_tb.Name = "servicoVeiculoMarca_tb";
            servicoVeiculoMarca_tb.Size = new Size(148, 22);
            servicoVeiculoMarca_tb.TabIndex = 3;
            // 
            // servicoVeiculoMarca_label
            // 
            servicoVeiculoMarca_label.AutoSize = true;
            servicoVeiculoMarca_label.Location = new Point(108, 297);
            servicoVeiculoMarca_label.Name = "servicoVeiculoMarca_label";
            servicoVeiculoMarca_label.Size = new Size(49, 14);
            servicoVeiculoMarca_label.TabIndex = 2;
            servicoVeiculoMarca_label.Text = "Marca:";
            // 
            // servicoNovoVeiculo_check
            // 
            servicoNovoVeiculo_check.AutoSize = true;
            servicoNovoVeiculo_check.Location = new Point(6, 233);
            servicoNovoVeiculo_check.Name = "servicoNovoVeiculo_check";
            servicoNovoVeiculo_check.Size = new Size(172, 18);
            servicoNovoVeiculo_check.TabIndex = 0;
            servicoNovoVeiculo_check.Text = "Cadastrar Novo Veiculo";
            servicoNovoVeiculo_check.UseVisualStyleBackColor = true;
            servicoNovoVeiculo_check.CheckedChanged += servicoNovoVeiculo_check_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(criarServicoButton);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(servicoPreco_tb);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(servicoCliente_gb);
            groupBox1.Location = new Point(499, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 516);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servico";
            // 
            // criarServicoButton
            // 
            criarServicoButton.Anchor = AnchorStyles.None;
            criarServicoButton.BackColor = Color.SeaGreen;
            criarServicoButton.FlatStyle = FlatStyle.Flat;
            criarServicoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            criarServicoButton.ForeColor = Color.White;
            criarServicoButton.Location = new Point(6, 460);
            criarServicoButton.Name = "criarServicoButton";
            criarServicoButton.Size = new Size(476, 49);
            criarServicoButton.TabIndex = 1;
            criarServicoButton.Text = "Criar Servico";
            criarServicoButton.UseVisualStyleBackColor = false;
            criarServicoButton.Click += criarServicoButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 305);
            label9.Name = "label9";
            label9.Size = new Size(96, 14);
            label9.TabIndex = 84;
            label9.Text = "Servico Preco:";
            // 
            // servicoPreco_tb
            // 
            servicoPreco_tb.Location = new Point(115, 302);
            servicoPreco_tb.Name = "servicoPreco_tb";
            servicoPreco_tb.Size = new Size(259, 22);
            servicoPreco_tb.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(servicoDescricao_tb);
            groupBox2.Location = new Point(6, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 133);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descricao";
            // 
            // servicoDescricao_tb
            // 
            servicoDescricao_tb.Dock = DockStyle.Fill;
            servicoDescricao_tb.Location = new Point(3, 18);
            servicoDescricao_tb.Name = "servicoDescricao_tb";
            servicoDescricao_tb.Size = new Size(470, 112);
            servicoDescricao_tb.TabIndex = 0;
            servicoDescricao_tb.Text = "";
            // 
            // CriarServicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 541);
            Controls.Add(groupBox1);
            Controls.Add(servicoVeiculo_gb);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(1014, 580);
            MinimumSize = new Size(1014, 580);
            Name = "CriarServicoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            Load += CriarServicoForm_Load;
            servicoCliente_gb.ResumeLayout(false);
            servicoCliente_gb.PerformLayout();
            servicoVeiculo_gb.ResumeLayout(false);
            servicoVeiculo_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicoVeiculo_dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox servicoCliente_gb;
        private GroupBox servicoVeiculo_gb;
        private MaskedTextBox servicoClienteTelefone_tb;
        private Label label3;
        private Label label7;
        private TextBox servicoClienteSobrenome_tb;
        private Label label8;
        private TextBox servicoClienteNome_tb;
        private CheckBox servicoNovoVeiculo_check;
        private TextBox servicoVeiculoMarca_tb;
        private Label servicoVeiculoMarca_label;
        private Label label1;
        private TextBox servicoVeiculoModelo_tb;
        private Label label4;
        private TextBox servicoVeiculoCor_tb;
        private Label label2;
        private Label label5;
        private MaskedTextBox servicoVeiculoPlaca_tb;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox servicoDescricao_tb;
        private Button cadastrarVeiculoButton;
        private TextBox servicoVeiculoId_tb;
        private Label servicoVeiculoId_label;
        private Label label6;
        private TextBox servicoClienteId_tb;
        private Button criarServicoButton;
        private Label label9;
        private TextBox servicoPreco_tb;
        private MaskedTextBox servicoVeiculoAno_tb;
        private DataGridView servicoVeiculo_dgv;
    }
}