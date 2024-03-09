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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label1 = new Label();
            vendaTotal_tb = new TextBox();
            venderPeca_dgv = new DataGridView();
            venderPecaButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)venderPeca_dgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(vendaTotal_tb);
            groupBox1.Controls.Add(venderPeca_dgv);
            groupBox1.Controls.Add(venderPecaButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vender Peca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(42, 14);
            label1.TabIndex = 5;
            label1.Text = "Total:";
            // 
            // vendaTotal_tb
            // 
            vendaTotal_tb.BackColor = Color.PaleGreen;
            vendaTotal_tb.Location = new Point(60, 243);
            vendaTotal_tb.Name = "vendaTotal_tb";
            vendaTotal_tb.ReadOnly = true;
            vendaTotal_tb.Size = new Size(163, 22);
            vendaTotal_tb.TabIndex = 4;
            // 
            // venderPeca_dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            venderPeca_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            venderPeca_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            venderPeca_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            venderPeca_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            venderPeca_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            venderPeca_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            venderPeca_dgv.Dock = DockStyle.Top;
            venderPeca_dgv.EnableHeadersVisualStyles = false;
            venderPeca_dgv.Location = new Point(3, 18);
            venderPeca_dgv.Name = "venderPeca_dgv";
            venderPeca_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            venderPeca_dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            venderPeca_dgv.RowTemplate.Height = 25;
            venderPeca_dgv.Size = new Size(394, 212);
            venderPeca_dgv.TabIndex = 3;
            venderPeca_dgv.DataBindingComplete += venderPeca_dgv_DataBindingComplete;
            // 
            // venderPecaButton
            // 
            venderPecaButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            venderPecaButton.BackColor = Color.LightSeaGreen;
            venderPecaButton.FlatStyle = FlatStyle.Flat;
            venderPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            venderPecaButton.ForeColor = Color.White;
            venderPecaButton.Location = new Point(12, 277);
            venderPecaButton.Name = "venderPecaButton";
            venderPecaButton.Size = new Size(376, 49);
            venderPecaButton.TabIndex = 1;
            venderPecaButton.Text = "Vender";
            venderPecaButton.UseVisualStyleBackColor = false;
            venderPecaButton.Click += venderPecaButton_Click;
            // 
            // VenderPecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 338);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(416, 377);
            MinimumSize = new Size(416, 377);
            Name = "VenderPecaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pecas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)venderPeca_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button venderPecaButton;
        private DataGridView venderPeca_dgv;
        private Label label1;
        private TextBox vendaTotal_tb;
    }
}