namespace Potato.WindowsForms.PecaForms
{
    partial class EditarPecaForm
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
            editPecaId_tb = new TextBox();
            editPecaButton = new Button();
            editPecaPreco_tb = new MaskedTextBox();
            editQuantidadeLabel = new Label();
            editPecaQtdNumeric = new NumericUpDown();
            editPecaCategoria_tb = new TextBox();
            editPecaNome_tb = new TextBox();
            editNomeLabel = new Label();
            editPrecoLabel = new Label();
            editCategoriaLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editPecaQtdNumeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(editPecaId_tb);
            groupBox1.Controls.Add(editPecaButton);
            groupBox1.Controls.Add(editPecaPreco_tb);
            groupBox1.Controls.Add(editQuantidadeLabel);
            groupBox1.Controls.Add(editPecaQtdNumeric);
            groupBox1.Controls.Add(editPecaCategoria_tb);
            groupBox1.Controls.Add(editPecaNome_tb);
            groupBox1.Controls.Add(editNomeLabel);
            groupBox1.Controls.Add(editPrecoLabel);
            groupBox1.Controls.Add(editCategoriaLabel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Peca";
            // 
            // editPecaId_tb
            // 
            editPecaId_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaId_tb.Enabled = false;
            editPecaId_tb.Location = new Point(102, 12);
            editPecaId_tb.Name = "editPecaId_tb";
            editPecaId_tb.Size = new Size(405, 22);
            editPecaId_tb.TabIndex = 0;
            editPecaId_tb.UseSystemPasswordChar = true;
            editPecaId_tb.Visible = false;
            // 
            // editPecaButton
            // 
            editPecaButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaButton.BackColor = Color.SandyBrown;
            editPecaButton.FlatStyle = FlatStyle.Flat;
            editPecaButton.ForeColor = Color.White;
            editPecaButton.Location = new Point(12, 380);
            editPecaButton.Name = "editPecaButton";
            editPecaButton.Size = new Size(495, 56);
            editPecaButton.TabIndex = 5;
            editPecaButton.Text = "Editar";
            editPecaButton.UseVisualStyleBackColor = false;
            editPecaButton.Click += editPecaButton_Click;
            // 
            // editPecaPreco_tb
            // 
            editPecaPreco_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaPreco_tb.Location = new Point(102, 77);
            editPecaPreco_tb.Mask = "0000.00";
            editPecaPreco_tb.Name = "editPecaPreco_tb";
            editPecaPreco_tb.Size = new Size(405, 22);
            editPecaPreco_tb.TabIndex = 2;
            // 
            // editQuantidadeLabel
            // 
            editQuantidadeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editQuantidadeLabel.AutoSize = true;
            editQuantidadeLabel.Location = new Point(10, 137);
            editQuantidadeLabel.Name = "editQuantidadeLabel";
            editQuantidadeLabel.Size = new Size(86, 14);
            editQuantidadeLabel.TabIndex = 84;
            editQuantidadeLabel.Text = "Quantidade:";
            // 
            // editPecaQtdNumeric
            // 
            editPecaQtdNumeric.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaQtdNumeric.Location = new Point(102, 135);
            editPecaQtdNumeric.Name = "editPecaQtdNumeric";
            editPecaQtdNumeric.Size = new Size(405, 22);
            editPecaQtdNumeric.TabIndex = 4;
            // 
            // editPecaCategoria_tb
            // 
            editPecaCategoria_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaCategoria_tb.Location = new Point(102, 106);
            editPecaCategoria_tb.Name = "editPecaCategoria_tb";
            editPecaCategoria_tb.Size = new Size(405, 22);
            editPecaCategoria_tb.TabIndex = 3;
            // 
            // editPecaNome_tb
            // 
            editPecaNome_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPecaNome_tb.Location = new Point(102, 49);
            editPecaNome_tb.Name = "editPecaNome_tb";
            editPecaNome_tb.Size = new Size(405, 22);
            editPecaNome_tb.TabIndex = 1;
            // 
            // editNomeLabel
            // 
            editNomeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editNomeLabel.AutoSize = true;
            editNomeLabel.Location = new Point(12, 52);
            editNomeLabel.Name = "editNomeLabel";
            editNomeLabel.Size = new Size(48, 14);
            editNomeLabel.TabIndex = 78;
            editNomeLabel.Text = "Nome:";
            // 
            // editPrecoLabel
            // 
            editPrecoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPrecoLabel.AutoSize = true;
            editPrecoLabel.Location = new Point(12, 80);
            editPrecoLabel.Name = "editPrecoLabel";
            editPrecoLabel.Size = new Size(47, 14);
            editPrecoLabel.TabIndex = 79;
            editPrecoLabel.Text = "Preco:";
            // 
            // editCategoriaLabel
            // 
            editCategoriaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoriaLabel.AutoSize = true;
            editCategoriaLabel.Location = new Point(12, 109);
            editCategoriaLabel.Name = "editCategoriaLabel";
            editCategoriaLabel.Size = new Size(74, 14);
            editCategoriaLabel.TabIndex = 80;
            editCategoriaLabel.Text = "Categoria:";
            // 
            // EditarPecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 448);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(535, 487);
            MinimumSize = new Size(535, 487);
            Name = "EditarPecaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pecas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editPecaQtdNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox editPecaPreco_tb;
        private Label editQuantidadeLabel;
        private NumericUpDown editPecaQtdNumeric;
        private TextBox editPecaCategoria_tb;
        private TextBox editPecaNome_tb;
        private Label editNomeLabel;
        private Label editPrecoLabel;
        private Label editCategoriaLabel;
        private Button editPecaButton;
        private TextBox editPecaId_tb;
    }
}