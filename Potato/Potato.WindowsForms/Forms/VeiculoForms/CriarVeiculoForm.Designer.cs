namespace Potato.WindowsForms.Forms.VeiculoForms
{
    partial class CriarVeiculoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cadastrarVeiculo_btn = new Button();
            criarVeiculoAno_tb = new MaskedTextBox();
            criarVeiculoPlaca_tb = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            criarVeiculoCor_tb = new TextBox();
            label2 = new Label();
            criarVeiculoModelo_tb = new TextBox();
            label1 = new Label();
            criarVeiculoMarca_tb = new TextBox();
            servicoVeiculoMarca_label = new Label();
            groupBox2 = new GroupBox();
            listarVeiculoClientes_btn = new Button();
            searchVeiculoClientes_btn = new Button();
            searchVeiculoClientes_tb = new TextBox();
            criarVeiculoClientes_dgv = new DataGridView();
            label6 = new Label();
            veiculoClienteTelefone_tb = new TextBox();
            veiculoClienteNome_tb = new TextBox();
            veiculoClienteSobrenome_tb = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)criarVeiculoClientes_dgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cadastrarVeiculo_btn);
            groupBox1.Controls.Add(criarVeiculoAno_tb);
            groupBox1.Controls.Add(criarVeiculoPlaca_tb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(criarVeiculoCor_tb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(criarVeiculoModelo_tb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(criarVeiculoMarca_tb);
            groupBox1.Controls.Add(servicoVeiculoMarca_label);
            groupBox1.Location = new Point(14, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veiculo";
            // 
            // cadastrarVeiculo_btn
            // 
            cadastrarVeiculo_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cadastrarVeiculo_btn.BackColor = Color.SeaGreen;
            cadastrarVeiculo_btn.FlatStyle = FlatStyle.Flat;
            cadastrarVeiculo_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarVeiculo_btn.ForeColor = Color.White;
            cadastrarVeiculo_btn.Location = new Point(5, 312);
            cadastrarVeiculo_btn.Name = "cadastrarVeiculo_btn";
            cadastrarVeiculo_btn.Size = new Size(217, 49);
            cadastrarVeiculo_btn.TabIndex = 82;
            cadastrarVeiculo_btn.Text = "Cadastrar";
            cadastrarVeiculo_btn.UseVisualStyleBackColor = false;
            cadastrarVeiculo_btn.Click += cadastrarVeiculo_btn_Click;
            // 
            // criarVeiculoAno_tb
            // 
            criarVeiculoAno_tb.Location = new Point(69, 131);
            criarVeiculoAno_tb.Mask = "0000";
            criarVeiculoAno_tb.Name = "criarVeiculoAno_tb";
            criarVeiculoAno_tb.Size = new Size(153, 22);
            criarVeiculoAno_tb.TabIndex = 63;
            // 
            // criarVeiculoPlaca_tb
            // 
            criarVeiculoPlaca_tb.Location = new Point(69, 158);
            criarVeiculoPlaca_tb.Mask = "AAAAAAA";
            criarVeiculoPlaca_tb.Name = "criarVeiculoPlaca_tb";
            criarVeiculoPlaca_tb.Size = new Size(153, 22);
            criarVeiculoPlaca_tb.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 161);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 61;
            label5.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 133);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 60;
            label4.Text = "Ano:";
            // 
            // criarVeiculoCor_tb
            // 
            criarVeiculoCor_tb.Location = new Point(69, 104);
            criarVeiculoCor_tb.Name = "criarVeiculoCor_tb";
            criarVeiculoCor_tb.Size = new Size(153, 22);
            criarVeiculoCor_tb.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(34, 14);
            label2.TabIndex = 58;
            label2.Text = "Cor:";
            // 
            // criarVeiculoModelo_tb
            // 
            criarVeiculoModelo_tb.Location = new Point(69, 77);
            criarVeiculoModelo_tb.Name = "criarVeiculoModelo_tb";
            criarVeiculoModelo_tb.Size = new Size(153, 22);
            criarVeiculoModelo_tb.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 56;
            label1.Text = "Modelo:";
            // 
            // criarVeiculoMarca_tb
            // 
            criarVeiculoMarca_tb.Location = new Point(69, 51);
            criarVeiculoMarca_tb.Name = "criarVeiculoMarca_tb";
            criarVeiculoMarca_tb.Size = new Size(153, 22);
            criarVeiculoMarca_tb.TabIndex = 55;
            // 
            // servicoVeiculoMarca_label
            // 
            servicoVeiculoMarca_label.AutoSize = true;
            servicoVeiculoMarca_label.Location = new Point(6, 54);
            servicoVeiculoMarca_label.Name = "servicoVeiculoMarca_label";
            servicoVeiculoMarca_label.Size = new Size(49, 14);
            servicoVeiculoMarca_label.TabIndex = 54;
            servicoVeiculoMarca_label.Text = "Marca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listarVeiculoClientes_btn);
            groupBox2.Controls.Add(searchVeiculoClientes_btn);
            groupBox2.Controls.Add(searchVeiculoClientes_tb);
            groupBox2.Controls.Add(criarVeiculoClientes_dgv);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(veiculoClienteTelefone_tb);
            groupBox2.Controls.Add(veiculoClienteNome_tb);
            groupBox2.Controls.Add(veiculoClienteSobrenome_tb);
            groupBox2.Location = new Point(248, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 367);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // listarVeiculoClientes_btn
            // 
            listarVeiculoClientes_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarVeiculoClientes_btn.BackColor = Color.DimGray;
            listarVeiculoClientes_btn.FlatStyle = FlatStyle.Flat;
            listarVeiculoClientes_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarVeiculoClientes_btn.ForeColor = Color.White;
            listarVeiculoClientes_btn.Location = new Point(505, 21);
            listarVeiculoClientes_btn.MaximumSize = new Size(144, 43);
            listarVeiculoClientes_btn.Name = "listarVeiculoClientes_btn";
            listarVeiculoClientes_btn.Size = new Size(144, 29);
            listarVeiculoClientes_btn.TabIndex = 83;
            listarVeiculoClientes_btn.Text = "Listar Clientes";
            listarVeiculoClientes_btn.UseVisualStyleBackColor = false;
            listarVeiculoClientes_btn.Click += listarVeiculoClientes_btn_Click;
            // 
            // searchVeiculoClientes_btn
            // 
            searchVeiculoClientes_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchVeiculoClientes_btn.BackColor = Color.DimGray;
            searchVeiculoClientes_btn.FlatStyle = FlatStyle.Flat;
            searchVeiculoClientes_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchVeiculoClientes_btn.ForeColor = Color.White;
            searchVeiculoClientes_btn.Location = new Point(355, 22);
            searchVeiculoClientes_btn.Name = "searchVeiculoClientes_btn";
            searchVeiculoClientes_btn.Size = new Size(144, 27);
            searchVeiculoClientes_btn.TabIndex = 85;
            searchVeiculoClientes_btn.Text = "Buscar";
            searchVeiculoClientes_btn.UseVisualStyleBackColor = false;
            searchVeiculoClientes_btn.Click += searchVeiculoClientes_btn_Click;
            // 
            // searchVeiculoClientes_tb
            // 
            searchVeiculoClientes_tb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchVeiculoClientes_tb.Location = new Point(116, 24);
            searchVeiculoClientes_tb.Name = "searchVeiculoClientes_tb";
            searchVeiculoClientes_tb.Size = new Size(233, 22);
            searchVeiculoClientes_tb.TabIndex = 84;
            // 
            // criarVeiculoClientes_dgv
            // 
            criarVeiculoClientes_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            criarVeiculoClientes_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            criarVeiculoClientes_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            criarVeiculoClientes_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            criarVeiculoClientes_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            criarVeiculoClientes_dgv.EnableHeadersVisualStyles = false;
            criarVeiculoClientes_dgv.Location = new Point(7, 56);
            criarVeiculoClientes_dgv.Name = "criarVeiculoClientes_dgv";
            criarVeiculoClientes_dgv.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new Padding(3);
            criarVeiculoClientes_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            criarVeiculoClientes_dgv.RowTemplate.Height = 25;
            criarVeiculoClientes_dgv.Size = new Size(642, 254);
            criarVeiculoClientes_dgv.TabIndex = 5;
            criarVeiculoClientes_dgv.DataBindingComplete += criarVeiculoClientes_dgv_DataBindingComplete;
            criarVeiculoClientes_dgv.RowHeaderMouseDoubleClick += criarVeiculoClientes_dgv_RowHeaderMouseDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 329);
            label6.Name = "label6";
            label6.Size = new Size(88, 14);
            label6.TabIndex = 4;
            label6.Text = "Selecionado:";
            // 
            // veiculoClienteTelefone_tb
            // 
            veiculoClienteTelefone_tb.Location = new Point(390, 326);
            veiculoClienteTelefone_tb.Name = "veiculoClienteTelefone_tb";
            veiculoClienteTelefone_tb.ReadOnly = true;
            veiculoClienteTelefone_tb.Size = new Size(138, 22);
            veiculoClienteTelefone_tb.TabIndex = 2;
            // 
            // veiculoClienteNome_tb
            // 
            veiculoClienteNome_tb.Location = new Point(101, 326);
            veiculoClienteNome_tb.Name = "veiculoClienteNome_tb";
            veiculoClienteNome_tb.ReadOnly = true;
            veiculoClienteNome_tb.Size = new Size(146, 22);
            veiculoClienteNome_tb.TabIndex = 0;
            // 
            // veiculoClienteSobrenome_tb
            // 
            veiculoClienteSobrenome_tb.Location = new Point(253, 326);
            veiculoClienteSobrenome_tb.Name = "veiculoClienteSobrenome_tb";
            veiculoClienteSobrenome_tb.ReadOnly = true;
            veiculoClienteSobrenome_tb.Size = new Size(131, 22);
            veiculoClienteSobrenome_tb.TabIndex = 1;
            // 
            // CriarVeiculoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 385);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(931, 424);
            MinimumSize = new Size(931, 424);
            Name = "CriarVeiculoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veiculos";
            Load += CriarVeiculoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)criarVeiculoClientes_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox criarVeiculoAno_tb;
        private MaskedTextBox criarVeiculoPlaca_tb;
        private Label label5;
        private Label label4;
        private TextBox criarVeiculoCor_tb;
        private Label label2;
        private TextBox criarVeiculoModelo_tb;
        private Label label1;
        private TextBox criarVeiculoMarca_tb;
        private Label servicoVeiculoMarca_label;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox veiculoClienteTelefone_tb;
        private TextBox veiculoClienteNome_tb;
        private TextBox veiculoClienteSobrenome_tb;
        private Button cadastrarVeiculo_btn;
        private DataGridView criarVeiculoClientes_dgv;
        private Button listarVeiculoClientes_btn;
        private Button searchVeiculoClientes_btn;
        private TextBox searchVeiculoClientes_tb;
    }
}