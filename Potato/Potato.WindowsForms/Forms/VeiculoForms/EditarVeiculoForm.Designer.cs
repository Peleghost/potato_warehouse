namespace Potato.WindowsForms.Forms.VeiculoForms
{
    partial class EditarVeiculoForm
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
            groupBox1 = new GroupBox();
            editarVeiculoId_tb = new TextBox();
            ConfirmarEditVeiculo_btn = new Button();
            editarVeiculoAno_tb = new MaskedTextBox();
            editarVeiculoPlaca_tb = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            editarVeiculoCor_tb = new TextBox();
            label2 = new Label();
            editarVeiculoModelo_tb = new TextBox();
            label1 = new Label();
            editarVeiculoMarca_tb = new TextBox();
            servicoVeiculoMarca_label = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(editarVeiculoId_tb);
            groupBox1.Controls.Add(ConfirmarEditVeiculo_btn);
            groupBox1.Controls.Add(editarVeiculoAno_tb);
            groupBox1.Controls.Add(editarVeiculoPlaca_tb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(editarVeiculoCor_tb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(editarVeiculoModelo_tb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(editarVeiculoMarca_tb);
            groupBox1.Controls.Add(servicoVeiculoMarca_label);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Veiculo";
            // 
            // editarVeiculoId_tb
            // 
            editarVeiculoId_tb.Enabled = false;
            editarVeiculoId_tb.Location = new Point(111, 19);
            editarVeiculoId_tb.Name = "editarVeiculoId_tb";
            editarVeiculoId_tb.ReadOnly = true;
            editarVeiculoId_tb.Size = new Size(245, 22);
            editarVeiculoId_tb.TabIndex = 85;
            // 
            // ConfirmarEditVeiculo_btn
            // 
            ConfirmarEditVeiculo_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConfirmarEditVeiculo_btn.BackColor = Color.SandyBrown;
            ConfirmarEditVeiculo_btn.FlatStyle = FlatStyle.Flat;
            ConfirmarEditVeiculo_btn.ForeColor = Color.White;
            ConfirmarEditVeiculo_btn.Location = new Point(41, 294);
            ConfirmarEditVeiculo_btn.Name = "ConfirmarEditVeiculo_btn";
            ConfirmarEditVeiculo_btn.Size = new Size(315, 53);
            ConfirmarEditVeiculo_btn.TabIndex = 84;
            ConfirmarEditVeiculo_btn.Text = "Editar";
            ConfirmarEditVeiculo_btn.UseVisualStyleBackColor = false;
            ConfirmarEditVeiculo_btn.Click += ConfirmarEditVeiculo_btn_Click;
            // 
            // editarVeiculoAno_tb
            // 
            editarVeiculoAno_tb.Location = new Point(111, 121);
            editarVeiculoAno_tb.Mask = "0000";
            editarVeiculoAno_tb.Name = "editarVeiculoAno_tb";
            editarVeiculoAno_tb.Size = new Size(245, 22);
            editarVeiculoAno_tb.TabIndex = 63;
            // 
            // editarVeiculoPlaca_tb
            // 
            editarVeiculoPlaca_tb.Location = new Point(111, 147);
            editarVeiculoPlaca_tb.Mask = "AAAAAAA";
            editarVeiculoPlaca_tb.Name = "editarVeiculoPlaca_tb";
            editarVeiculoPlaca_tb.Size = new Size(245, 22);
            editarVeiculoPlaca_tb.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 149);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 61;
            label5.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 123);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 60;
            label4.Text = "Ano:";
            // 
            // editarVeiculoCor_tb
            // 
            editarVeiculoCor_tb.Location = new Point(111, 96);
            editarVeiculoCor_tb.Name = "editarVeiculoCor_tb";
            editarVeiculoCor_tb.Size = new Size(245, 22);
            editarVeiculoCor_tb.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(34, 14);
            label2.TabIndex = 58;
            label2.Text = "Cor:";
            // 
            // editarVeiculoModelo_tb
            // 
            editarVeiculoModelo_tb.Location = new Point(111, 71);
            editarVeiculoModelo_tb.Name = "editarVeiculoModelo_tb";
            editarVeiculoModelo_tb.Size = new Size(245, 22);
            editarVeiculoModelo_tb.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 75);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 56;
            label1.Text = "Modelo:";
            // 
            // editarVeiculoMarca_tb
            // 
            editarVeiculoMarca_tb.Location = new Point(111, 47);
            editarVeiculoMarca_tb.Name = "editarVeiculoMarca_tb";
            editarVeiculoMarca_tb.Size = new Size(245, 22);
            editarVeiculoMarca_tb.TabIndex = 55;
            // 
            // servicoVeiculoMarca_label
            // 
            servicoVeiculoMarca_label.AutoSize = true;
            servicoVeiculoMarca_label.Location = new Point(39, 49);
            servicoVeiculoMarca_label.Name = "servicoVeiculoMarca_label";
            servicoVeiculoMarca_label.Size = new Size(49, 14);
            servicoVeiculoMarca_label.TabIndex = 54;
            servicoVeiculoMarca_label.Text = "Marca:";
            // 
            // EditarVeiculoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 358);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(414, 397);
            MinimumSize = new Size(414, 397);
            Name = "EditarVeiculoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veiculos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox editarVeiculoAno_tb;
        private MaskedTextBox editarVeiculoPlaca_tb;
        private Label label5;
        private Label label4;
        private TextBox editarVeiculoCor_tb;
        private Label label2;
        private TextBox editarVeiculoModelo_tb;
        private Label label1;
        private TextBox editarVeiculoMarca_tb;
        private Label servicoVeiculoMarca_label;
        private Button ConfirmarEditVeiculo_btn;
        private TextBox editarVeiculoId_tb;
    }
}