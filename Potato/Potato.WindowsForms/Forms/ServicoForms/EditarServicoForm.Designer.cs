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
            editarServico_gb = new GroupBox();
            label5 = new Label();
            editServicoVeiculoPlaca_tb = new TextBox();
            editClienteButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            editServicoDescricao_tb = new RichTextBox();
            editServicoPreco_tb = new TextBox();
            editServicoVeiculo_tb = new TextBox();
            editServicoClienteNome_tb = new TextBox();
            editServicoId_tb = new TextBox();
            editarServico_gb.SuspendLayout();
            SuspendLayout();
            // 
            // editarServico_gb
            // 
            editarServico_gb.Controls.Add(label5);
            editarServico_gb.Controls.Add(editServicoVeiculoPlaca_tb);
            editarServico_gb.Controls.Add(editClienteButton);
            editarServico_gb.Controls.Add(label4);
            editarServico_gb.Controls.Add(label3);
            editarServico_gb.Controls.Add(label2);
            editarServico_gb.Controls.Add(label1);
            editarServico_gb.Controls.Add(editServicoDescricao_tb);
            editarServico_gb.Controls.Add(editServicoPreco_tb);
            editarServico_gb.Controls.Add(editServicoVeiculo_tb);
            editarServico_gb.Controls.Add(editServicoClienteNome_tb);
            editarServico_gb.Controls.Add(editServicoId_tb);
            editarServico_gb.Dock = DockStyle.Fill;
            editarServico_gb.Location = new Point(0, 0);
            editarServico_gb.Name = "editarServico_gb";
            editarServico_gb.Size = new Size(443, 420);
            editarServico_gb.TabIndex = 0;
            editarServico_gb.TabStop = false;
            editarServico_gb.Text = "Editar Servico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 118);
            label5.Name = "label5";
            label5.Size = new Size(45, 14);
            label5.TabIndex = 79;
            label5.Text = "Placa:";
            // 
            // editServicoVeiculoPlaca_tb
            // 
            editServicoVeiculoPlaca_tb.Enabled = false;
            editServicoVeiculoPlaca_tb.Location = new Point(117, 115);
            editServicoVeiculoPlaca_tb.Name = "editServicoVeiculoPlaca_tb";
            editServicoVeiculoPlaca_tb.Size = new Size(314, 22);
            editServicoVeiculoPlaca_tb.TabIndex = 78;
            // 
            // editClienteButton
            // 
            editClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editClienteButton.BackColor = Color.SandyBrown;
            editClienteButton.FlatStyle = FlatStyle.Flat;
            editClienteButton.ForeColor = Color.White;
            editClienteButton.Location = new Point(25, 345);
            editClienteButton.Name = "editClienteButton";
            editClienteButton.Size = new Size(406, 63);
            editClienteButton.TabIndex = 77;
            editClienteButton.Text = "Editar";
            editClienteButton.UseVisualStyleBackColor = false;
            editClienteButton.Click += editClienteButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 173);
            label4.Name = "label4";
            label4.Size = new Size(72, 14);
            label4.TabIndex = 8;
            label4.Text = "Descricao:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 14);
            label3.TabIndex = 7;
            label3.Text = "Preco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 14);
            label2.TabIndex = 6;
            label2.Text = "Veiculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 63);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 5;
            label1.Text = "Cliente:";
            // 
            // editServicoDescricao_tb
            // 
            editServicoDescricao_tb.Location = new Point(117, 170);
            editServicoDescricao_tb.Name = "editServicoDescricao_tb";
            editServicoDescricao_tb.Size = new Size(314, 80);
            editServicoDescricao_tb.TabIndex = 4;
            editServicoDescricao_tb.Text = "";
            // 
            // editServicoPreco_tb
            // 
            editServicoPreco_tb.Location = new Point(117, 143);
            editServicoPreco_tb.Name = "editServicoPreco_tb";
            editServicoPreco_tb.Size = new Size(314, 22);
            editServicoPreco_tb.TabIndex = 3;
            // 
            // editServicoVeiculo_tb
            // 
            editServicoVeiculo_tb.Enabled = false;
            editServicoVeiculo_tb.Location = new Point(117, 87);
            editServicoVeiculo_tb.Name = "editServicoVeiculo_tb";
            editServicoVeiculo_tb.Size = new Size(314, 22);
            editServicoVeiculo_tb.TabIndex = 2;
            // 
            // editServicoClienteNome_tb
            // 
            editServicoClienteNome_tb.Enabled = false;
            editServicoClienteNome_tb.Location = new Point(117, 60);
            editServicoClienteNome_tb.Name = "editServicoClienteNome_tb";
            editServicoClienteNome_tb.Size = new Size(314, 22);
            editServicoClienteNome_tb.TabIndex = 1;
            // 
            // editServicoId_tb
            // 
            editServicoId_tb.Enabled = false;
            editServicoId_tb.Location = new Point(117, 33);
            editServicoId_tb.Name = "editServicoId_tb";
            editServicoId_tb.Size = new Size(314, 22);
            editServicoId_tb.TabIndex = 0;
            editServicoId_tb.Visible = false;
            // 
            // EditarServicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 420);
            Controls.Add(editarServico_gb);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(459, 459);
            MinimumSize = new Size(459, 459);
            Name = "EditarServicoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicos";
            editarServico_gb.ResumeLayout(false);
            editarServico_gb.PerformLayout();
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
        private Button editClienteButton;
        private Label label5;
        private TextBox editServicoVeiculoPlaca_tb;
    }
}