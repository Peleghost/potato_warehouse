namespace Potato.WindowsForms.PecaForms
{
    partial class CriarPecaForm
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
            pecaPreco_tb = new MaskedTextBox();
            criarPecaButton = new Button();
            quantidadeLabel = new Label();
            pecaEstoqueNumeric = new NumericUpDown();
            pecaCategoria_tb = new TextBox();
            pecaNome_tb = new TextBox();
            nomeLabel = new Label();
            precoLabel = new Label();
            categoriaLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pecaPreco_tb);
            groupBox1.Controls.Add(criarPecaButton);
            groupBox1.Controls.Add(quantidadeLabel);
            groupBox1.Controls.Add(pecaEstoqueNumeric);
            groupBox1.Controls.Add(pecaCategoria_tb);
            groupBox1.Controls.Add(pecaNome_tb);
            groupBox1.Controls.Add(nomeLabel);
            groupBox1.Controls.Add(precoLabel);
            groupBox1.Controls.Add(categoriaLabel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar Peca";
            // 
            // pecaPreco_tb
            // 
            pecaPreco_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pecaPreco_tb.Location = new Point(99, 78);
            pecaPreco_tb.Mask = "0000.00";
            pecaPreco_tb.Name = "pecaPreco_tb";
            pecaPreco_tb.Size = new Size(408, 22);
            pecaPreco_tb.TabIndex = 86;
            // 
            // criarPecaButton
            // 
            criarPecaButton.BackColor = Color.SeaGreen;
            criarPecaButton.FlatStyle = FlatStyle.Flat;
            criarPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            criarPecaButton.ForeColor = Color.White;
            criarPecaButton.Location = new Point(12, 380);
            criarPecaButton.Name = "criarPecaButton";
            criarPecaButton.Size = new Size(495, 56);
            criarPecaButton.TabIndex = 85;
            criarPecaButton.Text = "Criar";
            criarPecaButton.UseVisualStyleBackColor = false;
            criarPecaButton.Click += CriarButton_Click;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(7, 134);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(86, 14);
            quantidadeLabel.TabIndex = 83;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // pecaEstoqueNumeric
            // 
            pecaEstoqueNumeric.Location = new Point(99, 132);
            pecaEstoqueNumeric.Name = "pecaEstoqueNumeric";
            pecaEstoqueNumeric.Size = new Size(408, 22);
            pecaEstoqueNumeric.TabIndex = 82;
            // 
            // pecaCategoria_tb
            // 
            pecaCategoria_tb.Location = new Point(99, 105);
            pecaCategoria_tb.Name = "pecaCategoria_tb";
            pecaCategoria_tb.Size = new Size(408, 22);
            pecaCategoria_tb.TabIndex = 81;
            // 
            // pecaNome_tb
            // 
            pecaNome_tb.Location = new Point(99, 49);
            pecaNome_tb.Name = "pecaNome_tb";
            pecaNome_tb.Size = new Size(408, 22);
            pecaNome_tb.TabIndex = 80;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(7, 52);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(48, 14);
            nomeLabel.TabIndex = 77;
            nomeLabel.Text = "Nome:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new Point(7, 81);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new Size(47, 14);
            precoLabel.TabIndex = 78;
            precoLabel.Text = "Preco:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(7, 108);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(74, 14);
            categoriaLabel.TabIndex = 79;
            categoriaLabel.Text = "Categoria:";
            // 
            // CriarPecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 448);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(535, 487);
            MinimumSize = new Size(535, 487);
            Name = "CriarPecaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriarPecaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label quantidadeLabel;
        private NumericUpDown pecaEstoqueNumeric;
        private TextBox pecaCategoria_tb;
        private TextBox pecaNome_tb;
        private Label nomeLabel;
        private Label precoLabel;
        private Label categoriaLabel;
        private Button criarPecaButton;
        private MaskedTextBox pecaPreco_tb;
    }
}