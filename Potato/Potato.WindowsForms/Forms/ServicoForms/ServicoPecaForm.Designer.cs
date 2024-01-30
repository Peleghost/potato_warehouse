namespace Potato.WindowsForms.Forms.ServicoForms
{
    partial class ServicoPecaForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            servicoPecaServicoId_tb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            servicoPecaPlaca_tb = new TextBox();
            servicoPecaVeiculo_tb = new TextBox();
            servicoPecaCliente_tb = new TextBox();
            groupBox2 = new GroupBox();
            servicoPeca_dgv = new DataGridView();
            groupBox3 = new GroupBox();
            servicoPecaRemoveButton = new Button();
            servicoPecaAddButton = new Button();
            groupBox5 = new GroupBox();
            servicoPecaAdicionar_dgv = new DataGridView();
            groupBox4 = new GroupBox();
            label7 = new Label();
            servicoPecaNome_tb = new TextBox();
            label6 = new Label();
            servicoPecaCategoria_tb = new TextBox();
            label5 = new Label();
            servicoPecaPreco_tb = new TextBox();
            label4 = new Label();
            servicoPecaQuantidade_numeric = new NumericUpDown();
            servicoPecaListarPecasButton = new Button();
            servicoPecaSearchPecaButton = new Button();
            servicoPecaSearchTextBox = new TextBox();
            servicoPecaSearchPeca_combo = new ComboBox();
            panel1 = new Panel();
            servicoPecaFinalizarButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoPeca_dgv).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoPecaAdicionar_dgv).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoPecaQuantidade_numeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(servicoPecaServicoId_tb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(servicoPecaPlaca_tb);
            groupBox1.Controls.Add(servicoPecaVeiculo_tb);
            groupBox1.Controls.Add(servicoPecaCliente_tb);
            groupBox1.Location = new Point(326, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servico";
            // 
            // servicoPecaServicoId_tb
            // 
            servicoPecaServicoId_tb.Enabled = false;
            servicoPecaServicoId_tb.Location = new Point(69, 112);
            servicoPecaServicoId_tb.Name = "servicoPecaServicoId_tb";
            servicoPecaServicoId_tb.ReadOnly = true;
            servicoPecaServicoId_tb.Size = new Size(184, 22);
            servicoPecaServicoId_tb.TabIndex = 6;
            servicoPecaServicoId_tb.UseSystemPasswordChar = true;
            servicoPecaServicoId_tb.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(45, 14);
            label3.TabIndex = 5;
            label3.Text = "Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 14);
            label2.TabIndex = 4;
            label2.Text = "Veiculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(48, 14);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // servicoPecaPlaca_tb
            // 
            servicoPecaPlaca_tb.Location = new Point(69, 84);
            servicoPecaPlaca_tb.Name = "servicoPecaPlaca_tb";
            servicoPecaPlaca_tb.ReadOnly = true;
            servicoPecaPlaca_tb.Size = new Size(184, 22);
            servicoPecaPlaca_tb.TabIndex = 2;
            // 
            // servicoPecaVeiculo_tb
            // 
            servicoPecaVeiculo_tb.Location = new Point(69, 57);
            servicoPecaVeiculo_tb.Name = "servicoPecaVeiculo_tb";
            servicoPecaVeiculo_tb.ReadOnly = true;
            servicoPecaVeiculo_tb.Size = new Size(184, 22);
            servicoPecaVeiculo_tb.TabIndex = 1;
            // 
            // servicoPecaCliente_tb
            // 
            servicoPecaCliente_tb.Location = new Point(69, 30);
            servicoPecaCliente_tb.Name = "servicoPecaCliente_tb";
            servicoPecaCliente_tb.ReadOnly = true;
            servicoPecaCliente_tb.Size = new Size(184, 22);
            servicoPecaCliente_tb.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(servicoPeca_dgv);
            groupBox2.Location = new Point(12, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(620, 396);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pecas em Estoque";
            // 
            // servicoPeca_dgv
            // 
            servicoPeca_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicoPeca_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicoPeca_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            servicoPeca_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            servicoPeca_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoPeca_dgv.Dock = DockStyle.Fill;
            servicoPeca_dgv.EnableHeadersVisualStyles = false;
            servicoPeca_dgv.Location = new Point(3, 18);
            servicoPeca_dgv.Name = "servicoPeca_dgv";
            servicoPeca_dgv.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new Padding(3);
            servicoPeca_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            servicoPeca_dgv.RowTemplate.Height = 25;
            servicoPeca_dgv.Size = new Size(614, 375);
            servicoPeca_dgv.TabIndex = 2;
            servicoPeca_dgv.DataBindingComplete += servicoPeca_dgv_DataBindingComplete;
            servicoPeca_dgv.RowHeaderMouseDoubleClick += servicoPeca_dgv_RowHeaderMouseDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(servicoPecaRemoveButton);
            groupBox3.Controls.Add(servicoPecaAddButton);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(635, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(618, 429);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Revisao";
            // 
            // servicoPecaRemoveButton
            // 
            servicoPecaRemoveButton.BackColor = Color.IndianRed;
            servicoPecaRemoveButton.Enabled = false;
            servicoPecaRemoveButton.FlatStyle = FlatStyle.Flat;
            servicoPecaRemoveButton.ForeColor = Color.White;
            servicoPecaRemoveButton.Location = new Point(315, 174);
            servicoPecaRemoveButton.Name = "servicoPecaRemoveButton";
            servicoPecaRemoveButton.Size = new Size(297, 48);
            servicoPecaRemoveButton.TabIndex = 12;
            servicoPecaRemoveButton.Text = "Remover";
            servicoPecaRemoveButton.UseVisualStyleBackColor = false;
            servicoPecaRemoveButton.Click += servicoPecaRemoveButton_Click;
            // 
            // servicoPecaAddButton
            // 
            servicoPecaAddButton.BackColor = Color.LightSeaGreen;
            servicoPecaAddButton.FlatStyle = FlatStyle.Flat;
            servicoPecaAddButton.ForeColor = Color.White;
            servicoPecaAddButton.Location = new Point(6, 174);
            servicoPecaAddButton.Name = "servicoPecaAddButton";
            servicoPecaAddButton.Size = new Size(297, 48);
            servicoPecaAddButton.TabIndex = 11;
            servicoPecaAddButton.Text = "Add";
            servicoPecaAddButton.UseVisualStyleBackColor = false;
            servicoPecaAddButton.Click += servicoPecaAddButton_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(servicoPecaAdicionar_dgv);
            groupBox5.Location = new Point(6, 228);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(606, 195);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Peca -> Servico";
            // 
            // servicoPecaAdicionar_dgv
            // 
            servicoPecaAdicionar_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicoPecaAdicionar_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicoPecaAdicionar_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            servicoPecaAdicionar_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            servicoPecaAdicionar_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoPecaAdicionar_dgv.Dock = DockStyle.Fill;
            servicoPecaAdicionar_dgv.EnableHeadersVisualStyles = false;
            servicoPecaAdicionar_dgv.Location = new Point(3, 18);
            servicoPecaAdicionar_dgv.Name = "servicoPecaAdicionar_dgv";
            servicoPecaAdicionar_dgv.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new Padding(3);
            servicoPecaAdicionar_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            servicoPecaAdicionar_dgv.RowTemplate.Height = 25;
            servicoPecaAdicionar_dgv.Size = new Size(600, 174);
            servicoPecaAdicionar_dgv.TabIndex = 3;
            servicoPecaAdicionar_dgv.DataBindingComplete += servicoPecaAdicionar_dgv_DataBindingComplete;
            servicoPecaAdicionar_dgv.RowHeaderMouseDoubleClick += servicoPecaAdicionar_dgv_RowHeaderMouseDoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(servicoPecaNome_tb);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(servicoPecaCategoria_tb);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(servicoPecaPreco_tb);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(servicoPecaQuantidade_numeric);
            groupBox4.Location = new Point(6, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(311, 147);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Peca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 111);
            label7.Name = "label7";
            label7.Size = new Size(86, 14);
            label7.TabIndex = 7;
            label7.Text = "Quantidade:";
            // 
            // servicoPecaNome_tb
            // 
            servicoPecaNome_tb.Location = new Point(100, 25);
            servicoPecaNome_tb.Name = "servicoPecaNome_tb";
            servicoPecaNome_tb.ReadOnly = true;
            servicoPecaNome_tb.Size = new Size(200, 22);
            servicoPecaNome_tb.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 84);
            label6.Name = "label6";
            label6.Size = new Size(47, 14);
            label6.TabIndex = 6;
            label6.Text = "Preco:";
            // 
            // servicoPecaCategoria_tb
            // 
            servicoPecaCategoria_tb.Location = new Point(100, 53);
            servicoPecaCategoria_tb.Name = "servicoPecaCategoria_tb";
            servicoPecaCategoria_tb.ReadOnly = true;
            servicoPecaCategoria_tb.Size = new Size(200, 22);
            servicoPecaCategoria_tb.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 56);
            label5.Name = "label5";
            label5.Size = new Size(74, 14);
            label5.TabIndex = 5;
            label5.Text = "Categoria:";
            // 
            // servicoPecaPreco_tb
            // 
            servicoPecaPreco_tb.Location = new Point(100, 81);
            servicoPecaPreco_tb.Name = "servicoPecaPreco_tb";
            servicoPecaPreco_tb.ReadOnly = true;
            servicoPecaPreco_tb.Size = new Size(200, 22);
            servicoPecaPreco_tb.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(42, 14);
            label4.TabIndex = 4;
            label4.Text = "Peca:";
            // 
            // servicoPecaQuantidade_numeric
            // 
            servicoPecaQuantidade_numeric.Location = new Point(100, 109);
            servicoPecaQuantidade_numeric.Name = "servicoPecaQuantidade_numeric";
            servicoPecaQuantidade_numeric.Size = new Size(200, 22);
            servicoPecaQuantidade_numeric.TabIndex = 3;
            // 
            // servicoPecaListarPecasButton
            // 
            servicoPecaListarPecasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoPecaListarPecasButton.BackColor = Color.DimGray;
            servicoPecaListarPecasButton.FlatStyle = FlatStyle.Flat;
            servicoPecaListarPecasButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servicoPecaListarPecasButton.ForeColor = Color.White;
            servicoPecaListarPecasButton.Location = new Point(488, 9);
            servicoPecaListarPecasButton.MaximumSize = new Size(144, 43);
            servicoPecaListarPecasButton.Name = "servicoPecaListarPecasButton";
            servicoPecaListarPecasButton.Size = new Size(144, 29);
            servicoPecaListarPecasButton.TabIndex = 5;
            servicoPecaListarPecasButton.Text = "Listar Pecas";
            servicoPecaListarPecasButton.UseVisualStyleBackColor = false;
            servicoPecaListarPecasButton.Click += servicoPecaListarPecasButton_Click;
            // 
            // servicoPecaSearchPecaButton
            // 
            servicoPecaSearchPecaButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoPecaSearchPecaButton.BackColor = Color.DimGray;
            servicoPecaSearchPecaButton.FlatStyle = FlatStyle.Flat;
            servicoPecaSearchPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servicoPecaSearchPecaButton.ForeColor = Color.White;
            servicoPecaSearchPecaButton.Location = new Point(338, 9);
            servicoPecaSearchPecaButton.Name = "servicoPecaSearchPecaButton";
            servicoPecaSearchPecaButton.Size = new Size(144, 27);
            servicoPecaSearchPecaButton.TabIndex = 7;
            servicoPecaSearchPecaButton.Text = "Buscar";
            servicoPecaSearchPecaButton.UseVisualStyleBackColor = false;
            servicoPecaSearchPecaButton.Click += servicoPecaSearchPecaButton_Click;
            // 
            // servicoPecaSearchTextBox
            // 
            servicoPecaSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoPecaSearchTextBox.Location = new Point(139, 12);
            servicoPecaSearchTextBox.Name = "servicoPecaSearchTextBox";
            servicoPecaSearchTextBox.Size = new Size(193, 22);
            servicoPecaSearchTextBox.TabIndex = 6;
            // 
            // servicoPecaSearchPeca_combo
            // 
            servicoPecaSearchPeca_combo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoPecaSearchPeca_combo.AutoCompleteMode = AutoCompleteMode.Append;
            servicoPecaSearchPeca_combo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servicoPecaSearchPeca_combo.FormattingEnabled = true;
            servicoPecaSearchPeca_combo.Items.AddRange(new object[] { "ID", "Nome", "Categoria" });
            servicoPecaSearchPeca_combo.Location = new Point(12, 12);
            servicoPecaSearchPeca_combo.Name = "servicoPecaSearchPeca_combo";
            servicoPecaSearchPeca_combo.Size = new Size(121, 22);
            servicoPecaSearchPeca_combo.TabIndex = 8;
            servicoPecaSearchPeca_combo.Text = "Buscar Por...";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(servicoPecaFinalizarButton);
            panel1.Location = new Point(12, 444);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 80);
            panel1.TabIndex = 9;
            // 
            // servicoPecaFinalizarButton
            // 
            servicoPecaFinalizarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            servicoPecaFinalizarButton.BackColor = Color.SeaGreen;
            servicoPecaFinalizarButton.FlatStyle = FlatStyle.Flat;
            servicoPecaFinalizarButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servicoPecaFinalizarButton.ForeColor = Color.White;
            servicoPecaFinalizarButton.Location = new Point(476, 3);
            servicoPecaFinalizarButton.Name = "servicoPecaFinalizarButton";
            servicoPecaFinalizarButton.Size = new Size(305, 74);
            servicoPecaFinalizarButton.TabIndex = 49;
            servicoPecaFinalizarButton.Text = "Finalizar";
            servicoPecaFinalizarButton.UseVisualStyleBackColor = false;
            servicoPecaFinalizarButton.Click += servicoPecaFinalizarButton_Click;
            // 
            // ServicoPecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 536);
            Controls.Add(panel1);
            Controls.Add(servicoPecaListarPecasButton);
            Controls.Add(servicoPecaSearchPecaButton);
            Controls.Add(servicoPecaSearchTextBox);
            Controls.Add(servicoPecaSearchPeca_combo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(1281, 575);
            MinimumSize = new Size(1281, 575);
            Name = "ServicoPecaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicoPeca_dgv).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicoPecaAdicionar_dgv).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicoPecaQuantidade_numeric).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox servicoPecaPlaca_tb;
        private TextBox servicoPecaVeiculo_tb;
        private TextBox servicoPecaCliente_tb;
        private GroupBox groupBox2;
        private DataGridView servicoPeca_dgv;
        private GroupBox groupBox3;
        private NumericUpDown servicoPecaQuantidade_numeric;
        private TextBox servicoPecaPreco_tb;
        private TextBox servicoPecaCategoria_tb;
        private TextBox servicoPecaNome_tb;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button servicoPecaListarPecasButton;
        private Button servicoPecaSearchPecaButton;
        private TextBox servicoPecaSearchTextBox;
        private ComboBox servicoPecaSearchPeca_combo;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button servicoPecaAddButton;
        private Button servicoPecaRemoveButton;
        private Panel panel1;
        private Button servicoPecaFinalizarButton;
        private TextBox servicoPecaServicoId_tb;
        private DataGridView servicoPecaAdicionar_dgv;
    }
}