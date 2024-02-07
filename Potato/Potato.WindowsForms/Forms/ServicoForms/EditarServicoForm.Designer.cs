namespace Potato.WindowsForms.Forms.ServicoForms
{
    partial class EditarServicoForm
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
            editarServico_gb = new GroupBox();
            groupBox2 = new GroupBox();
            editServicoClienteNome_tb = new TextBox();
            editServicoId_tb = new TextBox();
            label5 = new Label();
            editServicoVeiculo_tb = new TextBox();
            editServicoVeiculoPlaca_tb = new TextBox();
            editServicoPreco_tb = new TextBox();
            editServicoDescricao_tb = new RichTextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            editServicoPecaId_tb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            editServicoPecaPreco_tb = new TextBox();
            editServicoPecaCategoria_tb = new TextBox();
            editServicoPecaNome_tb = new TextBox();
            editServicoPecaQtd_numeric = new NumericUpDown();
            editarServicoPecaQtd_label = new Label();
            editServicoPecas_dgv = new DataGridView();
            editServicoButton = new Button();
            editarServico_gb.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editServicoPecaQtd_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editServicoPecas_dgv).BeginInit();
            SuspendLayout();
            // 
            // editarServico_gb
            // 
            editarServico_gb.Controls.Add(groupBox2);
            editarServico_gb.Controls.Add(groupBox1);
            editarServico_gb.Controls.Add(editServicoButton);
            editarServico_gb.Dock = DockStyle.Fill;
            editarServico_gb.Location = new Point(0, 0);
            editarServico_gb.Name = "editarServico_gb";
            editarServico_gb.Size = new Size(1009, 437);
            editarServico_gb.TabIndex = 0;
            editarServico_gb.TabStop = false;
            editarServico_gb.Text = "Editar Servico";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(editServicoClienteNome_tb);
            groupBox2.Controls.Add(editServicoId_tb);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(editServicoVeiculo_tb);
            groupBox2.Controls.Add(editServicoVeiculoPlaca_tb);
            groupBox2.Controls.Add(editServicoPreco_tb);
            groupBox2.Controls.Add(editServicoDescricao_tb);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 338);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalhes";
            // 
            // editServicoClienteNome_tb
            // 
            editServicoClienteNome_tb.Enabled = false;
            editServicoClienteNome_tb.Location = new Point(116, 44);
            editServicoClienteNome_tb.Name = "editServicoClienteNome_tb";
            editServicoClienteNome_tb.Size = new Size(314, 22);
            editServicoClienteNome_tb.TabIndex = 1;
            // 
            // editServicoId_tb
            // 
            editServicoId_tb.Enabled = false;
            editServicoId_tb.Location = new Point(116, 17);
            editServicoId_tb.Name = "editServicoId_tb";
            editServicoId_tb.Size = new Size(314, 22);
            editServicoId_tb.TabIndex = 0;
            editServicoId_tb.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 102);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 79;
            label5.Text = "Placa:";
            // 
            // editServicoVeiculo_tb
            // 
            editServicoVeiculo_tb.Enabled = false;
            editServicoVeiculo_tb.Location = new Point(116, 71);
            editServicoVeiculo_tb.Name = "editServicoVeiculo_tb";
            editServicoVeiculo_tb.Size = new Size(314, 22);
            editServicoVeiculo_tb.TabIndex = 2;
            // 
            // editServicoVeiculoPlaca_tb
            // 
            editServicoVeiculoPlaca_tb.Enabled = false;
            editServicoVeiculoPlaca_tb.Location = new Point(116, 99);
            editServicoVeiculoPlaca_tb.Name = "editServicoVeiculoPlaca_tb";
            editServicoVeiculoPlaca_tb.Size = new Size(314, 22);
            editServicoVeiculoPlaca_tb.TabIndex = 78;
            // 
            // editServicoPreco_tb
            // 
            editServicoPreco_tb.Location = new Point(116, 127);
            editServicoPreco_tb.Name = "editServicoPreco_tb";
            editServicoPreco_tb.Size = new Size(314, 22);
            editServicoPreco_tb.TabIndex = 0;
            // 
            // editServicoDescricao_tb
            // 
            editServicoDescricao_tb.Location = new Point(116, 154);
            editServicoDescricao_tb.Name = "editServicoDescricao_tb";
            editServicoDescricao_tb.Size = new Size(314, 80);
            editServicoDescricao_tb.TabIndex = 1;
            editServicoDescricao_tb.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 157);
            label4.Name = "label4";
            label4.Size = new Size(72, 14);
            label4.TabIndex = 8;
            label4.Text = "Descricao:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 5;
            label1.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(47, 14);
            label3.TabIndex = 7;
            label3.Text = "Preco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(55, 14);
            label2.TabIndex = 6;
            label2.Text = "Veiculo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(editServicoPecaId_tb);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(editServicoPecaPreco_tb);
            groupBox1.Controls.Add(editServicoPecaCategoria_tb);
            groupBox1.Controls.Add(editServicoPecaNome_tb);
            groupBox1.Controls.Add(editServicoPecaQtd_numeric);
            groupBox1.Controls.Add(editarServicoPecaQtd_label);
            groupBox1.Controls.Add(editServicoPecas_dgv);
            groupBox1.Location = new Point(498, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 338);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pecas";
            // 
            // editServicoPecaId_tb
            // 
            editServicoPecaId_tb.Enabled = false;
            editServicoPecaId_tb.Location = new Point(433, 221);
            editServicoPecaId_tb.Name = "editServicoPecaId_tb";
            editServicoPecaId_tb.ReadOnly = true;
            editServicoPecaId_tb.Size = new Size(60, 22);
            editServicoPecaId_tb.TabIndex = 12;
            editServicoPecaId_tb.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 285);
            label8.Name = "label8";
            label8.Size = new Size(47, 14);
            label8.TabIndex = 11;
            label8.Text = "Preco:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 257);
            label7.Name = "label7";
            label7.Size = new Size(74, 14);
            label7.TabIndex = 10;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 229);
            label6.Name = "label6";
            label6.Size = new Size(48, 14);
            label6.TabIndex = 9;
            label6.Text = "Nome:";
            // 
            // editServicoPecaPreco_tb
            // 
            editServicoPecaPreco_tb.Location = new Point(107, 277);
            editServicoPecaPreco_tb.Name = "editServicoPecaPreco_tb";
            editServicoPecaPreco_tb.ReadOnly = true;
            editServicoPecaPreco_tb.Size = new Size(320, 22);
            editServicoPecaPreco_tb.TabIndex = 8;
            // 
            // editServicoPecaCategoria_tb
            // 
            editServicoPecaCategoria_tb.Location = new Point(107, 249);
            editServicoPecaCategoria_tb.Name = "editServicoPecaCategoria_tb";
            editServicoPecaCategoria_tb.ReadOnly = true;
            editServicoPecaCategoria_tb.Size = new Size(320, 22);
            editServicoPecaCategoria_tb.TabIndex = 7;
            // 
            // editServicoPecaNome_tb
            // 
            editServicoPecaNome_tb.Location = new Point(107, 221);
            editServicoPecaNome_tb.Name = "editServicoPecaNome_tb";
            editServicoPecaNome_tb.ReadOnly = true;
            editServicoPecaNome_tb.Size = new Size(320, 22);
            editServicoPecaNome_tb.TabIndex = 6;
            // 
            // editServicoPecaQtd_numeric
            // 
            editServicoPecaQtd_numeric.Location = new Point(107, 305);
            editServicoPecaQtd_numeric.Name = "editServicoPecaQtd_numeric";
            editServicoPecaQtd_numeric.Size = new Size(320, 22);
            editServicoPecaQtd_numeric.TabIndex = 0;
            // 
            // editarServicoPecaQtd_label
            // 
            editarServicoPecaQtd_label.AutoSize = true;
            editarServicoPecaQtd_label.Location = new Point(8, 312);
            editarServicoPecaQtd_label.Name = "editarServicoPecaQtd_label";
            editarServicoPecaQtd_label.Size = new Size(86, 14);
            editarServicoPecaQtd_label.TabIndex = 4;
            editarServicoPecaQtd_label.Text = "Quantidade:";
            // 
            // editServicoPecas_dgv
            // 
            editServicoPecas_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            editServicoPecas_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            editServicoPecas_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            editServicoPecas_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            editServicoPecas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editServicoPecas_dgv.Dock = DockStyle.Top;
            editServicoPecas_dgv.EnableHeadersVisualStyles = false;
            editServicoPecas_dgv.Location = new Point(3, 18);
            editServicoPecas_dgv.Name = "editServicoPecas_dgv";
            editServicoPecas_dgv.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new Padding(3);
            editServicoPecas_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            editServicoPecas_dgv.RowTemplate.Height = 25;
            editServicoPecas_dgv.Size = new Size(493, 190);
            editServicoPecas_dgv.TabIndex = 3;
            editServicoPecas_dgv.RowHeaderMouseDoubleClick += editarServicoPecas_dgv_RowHeaderMouseDoubleClick;
            // 
            // editServicoButton
            // 
            editServicoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editServicoButton.BackColor = Color.SandyBrown;
            editServicoButton.FlatStyle = FlatStyle.Flat;
            editServicoButton.ForeColor = Color.White;
            editServicoButton.Location = new Point(294, 362);
            editServicoButton.Name = "editServicoButton";
            editServicoButton.Size = new Size(406, 63);
            editServicoButton.TabIndex = 0;
            editServicoButton.Text = "Editar";
            editServicoButton.UseVisualStyleBackColor = false;
            editServicoButton.Click += editServicoButton_Click;
            // 
            // EditarServicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 437);
            Controls.Add(editarServico_gb);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EditarServicoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            Load += EditarServicoForm_Load;
            editarServico_gb.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editServicoPecaQtd_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)editServicoPecas_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox editarServico_gb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox editServicoDescricao_tb;
        private TextBox editServicoPreco_tb;
        private TextBox editServicoVeiculo_tb;
        private TextBox editServicoClienteNome_tb;
        private TextBox editServicoId_tb;
        private Button editServicoButton;
        private Label label5;
        private TextBox editServicoVeiculoPlaca_tb;
        private GroupBox groupBox1;
        private Label editarServicoPecaQtd_label;
        private DataGridView editServicoPecas_dgv;
        private GroupBox groupBox2;
        private NumericUpDown editServicoPecaQtd_numeric;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox editServicoPecaPreco_tb;
        private TextBox editServicoPecaCategoria_tb;
        private TextBox editServicoPecaNome_tb;
        private TextBox editServicoPecaId_tb;
    }
}