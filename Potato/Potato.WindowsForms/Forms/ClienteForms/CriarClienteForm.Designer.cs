namespace Potato.WindowsForms.Forms.ClienteForms
{
    partial class CriarClienteForm
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
            criarCliente_gb = new GroupBox();
            cadastrarClienteButton = new Button();
            clienteTelefone_masktb = new MaskedTextBox();
            clienteCpf_masktb = new MaskedTextBox();
            clienteTelefone_label = new Label();
            label2 = new Label();
            clienteEmail_tb = new TextBox();
            clienteEndereco_label = new Label();
            clienteEndereco_tb = new TextBox();
            cpf_label = new Label();
            clienteSobrenome_label = new Label();
            clienteSobrenome_tb = new TextBox();
            clienteNome_label = new Label();
            clienteNome_tb = new TextBox();
            criarCliente_gb.SuspendLayout();
            SuspendLayout();
            // 
            // criarCliente_gb
            // 
            criarCliente_gb.Controls.Add(cadastrarClienteButton);
            criarCliente_gb.Controls.Add(clienteTelefone_masktb);
            criarCliente_gb.Controls.Add(clienteCpf_masktb);
            criarCliente_gb.Controls.Add(clienteTelefone_label);
            criarCliente_gb.Controls.Add(label2);
            criarCliente_gb.Controls.Add(clienteEmail_tb);
            criarCliente_gb.Controls.Add(clienteEndereco_label);
            criarCliente_gb.Controls.Add(clienteEndereco_tb);
            criarCliente_gb.Controls.Add(cpf_label);
            criarCliente_gb.Controls.Add(clienteSobrenome_label);
            criarCliente_gb.Controls.Add(clienteSobrenome_tb);
            criarCliente_gb.Controls.Add(clienteNome_label);
            criarCliente_gb.Controls.Add(clienteNome_tb);
            criarCliente_gb.Dock = DockStyle.Fill;
            criarCliente_gb.Location = new Point(0, 0);
            criarCliente_gb.Name = "criarCliente_gb";
            criarCliente_gb.Size = new Size(519, 448);
            criarCliente_gb.TabIndex = 0;
            criarCliente_gb.TabStop = false;
            criarCliente_gb.Text = "Cadastrar Cliente";
            // 
            // cadastrarClienteButton
            // 
            cadastrarClienteButton.BackColor = Color.SeaGreen;
            cadastrarClienteButton.FlatStyle = FlatStyle.Flat;
            cadastrarClienteButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarClienteButton.ForeColor = Color.White;
            cadastrarClienteButton.Location = new Point(12, 369);
            cadastrarClienteButton.Name = "cadastrarClienteButton";
            cadastrarClienteButton.Size = new Size(495, 67);
            cadastrarClienteButton.TabIndex = 6;
            cadastrarClienteButton.Text = "Cadastrar";
            cadastrarClienteButton.UseVisualStyleBackColor = false;
            cadastrarClienteButton.Click += cadastrarClienteButton_Click;
            // 
            // clienteTelefone_masktb
            // 
            clienteTelefone_masktb.Location = new Point(102, 105);
            clienteTelefone_masktb.Mask = "(00)00000-0000";
            clienteTelefone_masktb.Name = "clienteTelefone_masktb";
            clienteTelefone_masktb.Size = new Size(405, 22);
            clienteTelefone_masktb.TabIndex = 2;
            // 
            // clienteCpf_masktb
            // 
            clienteCpf_masktb.Location = new Point(102, 133);
            clienteCpf_masktb.Mask = "000.000.000-00";
            clienteCpf_masktb.Name = "clienteCpf_masktb";
            clienteCpf_masktb.Size = new Size(405, 22);
            clienteCpf_masktb.TabIndex = 3;
            // 
            // clienteTelefone_label
            // 
            clienteTelefone_label.AutoSize = true;
            clienteTelefone_label.Location = new Point(12, 108);
            clienteTelefone_label.Name = "clienteTelefone_label";
            clienteTelefone_label.Size = new Size(65, 14);
            clienteTelefone_label.TabIndex = 61;
            clienteTelefone_label.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(45, 14);
            label2.TabIndex = 60;
            label2.Text = "Email:";
            // 
            // clienteEmail_tb
            // 
            clienteEmail_tb.Location = new Point(102, 189);
            clienteEmail_tb.Name = "clienteEmail_tb";
            clienteEmail_tb.Size = new Size(405, 22);
            clienteEmail_tb.TabIndex = 5;
            // 
            // clienteEndereco_label
            // 
            clienteEndereco_label.AutoSize = true;
            clienteEndereco_label.Location = new Point(12, 164);
            clienteEndereco_label.Name = "clienteEndereco_label";
            clienteEndereco_label.Size = new Size(71, 14);
            clienteEndereco_label.TabIndex = 58;
            clienteEndereco_label.Text = "Endereco:";
            // 
            // clienteEndereco_tb
            // 
            clienteEndereco_tb.Location = new Point(102, 161);
            clienteEndereco_tb.Name = "clienteEndereco_tb";
            clienteEndereco_tb.Size = new Size(405, 22);
            clienteEndereco_tb.TabIndex = 4;
            // 
            // cpf_label
            // 
            cpf_label.AutoSize = true;
            cpf_label.Location = new Point(12, 136);
            cpf_label.Name = "cpf_label";
            cpf_label.Size = new Size(36, 14);
            cpf_label.TabIndex = 56;
            cpf_label.Text = "CPF:";
            // 
            // clienteSobrenome_label
            // 
            clienteSobrenome_label.AutoSize = true;
            clienteSobrenome_label.Location = new Point(12, 80);
            clienteSobrenome_label.Name = "clienteSobrenome_label";
            clienteSobrenome_label.Size = new Size(84, 14);
            clienteSobrenome_label.TabIndex = 55;
            clienteSobrenome_label.Text = "Sobrenome:";
            // 
            // clienteSobrenome_tb
            // 
            clienteSobrenome_tb.Location = new Point(102, 77);
            clienteSobrenome_tb.Name = "clienteSobrenome_tb";
            clienteSobrenome_tb.Size = new Size(405, 22);
            clienteSobrenome_tb.TabIndex = 1;
            // 
            // clienteNome_label
            // 
            clienteNome_label.AutoSize = true;
            clienteNome_label.Location = new Point(12, 52);
            clienteNome_label.Name = "clienteNome_label";
            clienteNome_label.Size = new Size(48, 14);
            clienteNome_label.TabIndex = 53;
            clienteNome_label.Text = "Nome:";
            // 
            // clienteNome_tb
            // 
            clienteNome_tb.Location = new Point(102, 49);
            clienteNome_tb.Name = "clienteNome_tb";
            clienteNome_tb.Size = new Size(405, 22);
            clienteNome_tb.TabIndex = 0;
            // 
            // CriarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 448);
            Controls.Add(criarCliente_gb);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(535, 487);
            MinimumSize = new Size(535, 487);
            Name = "CriarClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            criarCliente_gb.ResumeLayout(false);
            criarCliente_gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox criarCliente_gb;
        private MaskedTextBox clienteTelefone_masktb;
        private MaskedTextBox clienteCpf_masktb;
        private Label clienteTelefone_label;
        private Label label2;
        private TextBox clienteEmail_tb;
        private Label clienteEndereco_label;
        private TextBox clienteEndereco_tb;
        private Label cpf_label;
        private Label clienteSobrenome_label;
        private TextBox clienteSobrenome_tb;
        private Label clienteNome_label;
        private TextBox clienteNome_tb;
        private Button cadastrarClienteButton;
    }
}