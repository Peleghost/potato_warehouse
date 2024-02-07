namespace Potato.WindowsForms.Forms.PecaForms
{
    partial class VenderPecaForm
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
            venderPecaId_tb = new TextBox();
            venderPecaQtdEstoque_numeric = new NumericUpDown();
            venderPecaButton = new Button();
            quantidadeLabel = new Label();
            nomeLabel = new Label();
            precoLabel = new Label();
            categoriaLabel = new Label();
            venderPecaQuantidade_numeric = new NumericUpDown();
            venderPecaPreco_tb = new TextBox();
            venderPecaCategoria_tb = new TextBox();
            venderPecaNome_tb = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)venderPecaQtdEstoque_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)venderPecaQuantidade_numeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(venderPecaId_tb);
            groupBox1.Controls.Add(venderPecaQtdEstoque_numeric);
            groupBox1.Controls.Add(venderPecaButton);
            groupBox1.Controls.Add(quantidadeLabel);
            groupBox1.Controls.Add(nomeLabel);
            groupBox1.Controls.Add(precoLabel);
            groupBox1.Controls.Add(categoriaLabel);
            groupBox1.Controls.Add(venderPecaQuantidade_numeric);
            groupBox1.Controls.Add(venderPecaPreco_tb);
            groupBox1.Controls.Add(venderPecaCategoria_tb);
            groupBox1.Controls.Add(venderPecaNome_tb);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vender Peca";
            // 
            // venderPecaId_tb
            // 
            venderPecaId_tb.Enabled = false;
            venderPecaId_tb.Location = new Point(117, 170);
            venderPecaId_tb.Name = "venderPecaId_tb";
            venderPecaId_tb.Size = new Size(121, 22);
            venderPecaId_tb.TabIndex = 90;
            venderPecaId_tb.Visible = false;
            // 
            // venderPecaQtdEstoque_numeric
            // 
            venderPecaQtdEstoque_numeric.Enabled = false;
            venderPecaQtdEstoque_numeric.Location = new Point(118, 142);
            venderPecaQtdEstoque_numeric.Name = "venderPecaQtdEstoque_numeric";
            venderPecaQtdEstoque_numeric.Size = new Size(120, 22);
            venderPecaQtdEstoque_numeric.TabIndex = 89;
            venderPecaQtdEstoque_numeric.Visible = false;
            // 
            // venderPecaButton
            // 
            venderPecaButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            venderPecaButton.BackColor = Color.LightSeaGreen;
            venderPecaButton.FlatStyle = FlatStyle.Flat;
            venderPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            venderPecaButton.ForeColor = Color.White;
            venderPecaButton.Location = new Point(6, 209);
            venderPecaButton.Name = "venderPecaButton";
            venderPecaButton.Size = new Size(322, 49);
            venderPecaButton.TabIndex = 88;
            venderPecaButton.Text = "Vender";
            venderPecaButton.UseVisualStyleBackColor = false;
            venderPecaButton.Click += venderPecaButton_Click;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(12, 116);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(86, 14);
            quantidadeLabel.TabIndex = 87;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(12, 34);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(48, 14);
            nomeLabel.TabIndex = 84;
            nomeLabel.Text = "Nome:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new Point(12, 63);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new Size(47, 14);
            precoLabel.TabIndex = 85;
            precoLabel.Text = "Preco:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(12, 90);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(74, 14);
            categoriaLabel.TabIndex = 86;
            categoriaLabel.Text = "Categoria:";
            // 
            // venderPecaQuantidade_numeric
            // 
            venderPecaQuantidade_numeric.Location = new Point(118, 114);
            venderPecaQuantidade_numeric.Name = "venderPecaQuantidade_numeric";
            venderPecaQuantidade_numeric.Size = new Size(210, 22);
            venderPecaQuantidade_numeric.TabIndex = 3;
            // 
            // venderPecaPreco_tb
            // 
            venderPecaPreco_tb.Location = new Point(118, 87);
            venderPecaPreco_tb.Name = "venderPecaPreco_tb";
            venderPecaPreco_tb.ReadOnly = true;
            venderPecaPreco_tb.Size = new Size(210, 22);
            venderPecaPreco_tb.TabIndex = 2;
            // 
            // venderPecaCategoria_tb
            // 
            venderPecaCategoria_tb.Location = new Point(118, 60);
            venderPecaCategoria_tb.Name = "venderPecaCategoria_tb";
            venderPecaCategoria_tb.ReadOnly = true;
            venderPecaCategoria_tb.Size = new Size(210, 22);
            venderPecaCategoria_tb.TabIndex = 1;
            // 
            // venderPecaNome_tb
            // 
            venderPecaNome_tb.Location = new Point(118, 31);
            venderPecaNome_tb.Name = "venderPecaNome_tb";
            venderPecaNome_tb.ReadOnly = true;
            venderPecaNome_tb.Size = new Size(210, 22);
            venderPecaNome_tb.TabIndex = 0;
            // 
            // VenderPecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 270);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(356, 309);
            MinimumSize = new Size(356, 309);
            Name = "VenderPecaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pecas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)venderPecaQtdEstoque_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)venderPecaQuantidade_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown venderPecaQuantidade_numeric;
        private TextBox venderPecaPreco_tb;
        private TextBox venderPecaCategoria_tb;
        private TextBox venderPecaNome_tb;
        private Label quantidadeLabel;
        private Label nomeLabel;
        private Label precoLabel;
        private Label categoriaLabel;
        private Button venderPecaButton;
        private NumericUpDown venderPecaQtdEstoque_numeric;
        private TextBox venderPecaId_tb;
    }
}