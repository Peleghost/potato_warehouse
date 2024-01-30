namespace Potato.WindowsForms.Forms.ClienteForms
{
    partial class EditarClienteForm
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
            editarCliente_gb = new GroupBox();
            editClienteId_tb = new TextBox();
            editClienteButton = new Button();
            editClienteTelefone_tb = new MaskedTextBox();
            editClienteCpf_tb = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            editClienteEmail_tb = new TextBox();
            label5 = new Label();
            editClienteEndereco_tb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            editClienteSobrenome_tb = new TextBox();
            label8 = new Label();
            editClienteNome_tb = new TextBox();
            editarCliente_gb.SuspendLayout();
            SuspendLayout();
            // 
            // editarCliente_gb
            // 
            editarCliente_gb.Controls.Add(editClienteId_tb);
            editarCliente_gb.Controls.Add(editClienteButton);
            editarCliente_gb.Controls.Add(editClienteTelefone_tb);
            editarCliente_gb.Controls.Add(editClienteCpf_tb);
            editarCliente_gb.Controls.Add(label3);
            editarCliente_gb.Controls.Add(label4);
            editarCliente_gb.Controls.Add(editClienteEmail_tb);
            editarCliente_gb.Controls.Add(label5);
            editarCliente_gb.Controls.Add(editClienteEndereco_tb);
            editarCliente_gb.Controls.Add(label6);
            editarCliente_gb.Controls.Add(label7);
            editarCliente_gb.Controls.Add(editClienteSobrenome_tb);
            editarCliente_gb.Controls.Add(label8);
            editarCliente_gb.Controls.Add(editClienteNome_tb);
            editarCliente_gb.Dock = DockStyle.Fill;
            editarCliente_gb.Location = new Point(0, 0);
            editarCliente_gb.Name = "editarCliente_gb";
            editarCliente_gb.Size = new Size(519, 448);
            editarCliente_gb.TabIndex = 0;
            editarCliente_gb.TabStop = false;
            editarCliente_gb.Text = "Editar Cliente";
            // 
            // editClienteId_tb
            // 
            editClienteId_tb.Enabled = false;
            editClienteId_tb.Location = new Point(102, 12);
            editClienteId_tb.Name = "editClienteId_tb";
            editClienteId_tb.Size = new Size(405, 22);
            editClienteId_tb.TabIndex = 77;
            editClienteId_tb.UseSystemPasswordChar = true;
            editClienteId_tb.Visible = false;
            // 
            // editClienteButton
            // 
            editClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editClienteButton.BackColor = Color.SandyBrown;
            editClienteButton.FlatStyle = FlatStyle.Flat;
            editClienteButton.ForeColor = Color.White;
            editClienteButton.Location = new Point(12, 369);
            editClienteButton.Name = "editClienteButton";
            editClienteButton.Size = new Size(495, 67);
            editClienteButton.TabIndex = 76;
            editClienteButton.Text = "Editar";
            editClienteButton.UseVisualStyleBackColor = false;
            editClienteButton.Click += editClienteButton_Click;
            // 
            // editClienteTelefone_tb
            // 
            editClienteTelefone_tb.Location = new Point(102, 189);
            editClienteTelefone_tb.Mask = "(00) 00000-0000";
            editClienteTelefone_tb.Name = "editClienteTelefone_tb";
            editClienteTelefone_tb.Size = new Size(405, 22);
            editClienteTelefone_tb.TabIndex = 75;
            // 
            // editClienteCpf_tb
            // 
            editClienteCpf_tb.Location = new Point(102, 105);
            editClienteCpf_tb.Mask = "000.000.000-00";
            editClienteCpf_tb.Name = "editClienteCpf_tb";
            editClienteCpf_tb.Size = new Size(405, 22);
            editClienteCpf_tb.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 73;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(45, 14);
            label4.TabIndex = 72;
            label4.Text = "Email:";
            // 
            // editClienteEmail_tb
            // 
            editClienteEmail_tb.Location = new Point(102, 161);
            editClienteEmail_tb.Name = "editClienteEmail_tb";
            editClienteEmail_tb.Size = new Size(405, 22);
            editClienteEmail_tb.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(71, 14);
            label5.TabIndex = 70;
            label5.Text = "Endereco:";
            // 
            // editClienteEndereco_tb
            // 
            editClienteEndereco_tb.Location = new Point(102, 133);
            editClienteEndereco_tb.Name = "editClienteEndereco_tb";
            editClienteEndereco_tb.Size = new Size(405, 22);
            editClienteEndereco_tb.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 108);
            label6.Name = "label6";
            label6.Size = new Size(36, 14);
            label6.TabIndex = 68;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 80);
            label7.Name = "label7";
            label7.Size = new Size(84, 14);
            label7.TabIndex = 67;
            label7.Text = "Sobrenome:";
            // 
            // editClienteSobrenome_tb
            // 
            editClienteSobrenome_tb.Location = new Point(102, 77);
            editClienteSobrenome_tb.Name = "editClienteSobrenome_tb";
            editClienteSobrenome_tb.Size = new Size(405, 22);
            editClienteSobrenome_tb.TabIndex = 66;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 52);
            label8.Name = "label8";
            label8.Size = new Size(48, 14);
            label8.TabIndex = 65;
            label8.Text = "Nome:";
            // 
            // editClienteNome_tb
            // 
            editClienteNome_tb.Location = new Point(102, 49);
            editClienteNome_tb.Name = "editClienteNome_tb";
            editClienteNome_tb.Size = new Size(405, 22);
            editClienteNome_tb.TabIndex = 64;
            // 
            // EditarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 448);
            Controls.Add(editarCliente_gb);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(535, 487);
            MinimumSize = new Size(535, 487);
            Name = "EditarClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            editarCliente_gb.ResumeLayout(false);
            editarCliente_gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox editarCliente_gb;
        private MaskedTextBox editClienteTelefone_tb;
        private MaskedTextBox editClienteCpf_tb;
        private Label label3;
        private Label label4;
        private TextBox editClienteEmail_tb;
        private Label label5;
        private TextBox editClienteEndereco_tb;
        private Label label6;
        private Label label7;
        private TextBox editClienteSobrenome_tb;
        private Label label8;
        private TextBox editClienteNome_tb;
        private Button editClienteButton;
        private TextBox editClienteId_tb;
    }
}