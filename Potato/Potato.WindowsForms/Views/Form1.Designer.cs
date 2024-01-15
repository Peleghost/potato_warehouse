namespace Potato.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            getPecasButton = new Button();
            mainTabControl = new TabControl();
            pecaTabPage = new TabPage();
            labelTotalRecords = new Label();
            deleteButton = new Button();
            editButton = new Button();
            venderButton = new Button();
            gb_pecasControl = new GroupBox();
            gb_pecas = new GroupBox();
            allPecas_dgv = new DataGridView();
            novaPecaButton = new Button();
            searchPecaButton = new Button();
            searchTextBox = new TextBox();
            searchComboBox = new ComboBox();
            clienteTabPage = new TabPage();
            deleteClienteButton = new Button();
            editClienteButton = new Button();
            clienteServicoButton = new Button();
            totalClientesLabel = new Label();
            listarClienteButton = new Button();
            searchClienteButton = new Button();
            novoClienteButton = new Button();
            searchCliente_tb = new TextBox();
            cliente_gb = new GroupBox();
            allClientes_dgv = new DataGridView();
            servicoTabPage = new TabPage();
            servico_gb = new GroupBox();
            allServicos_dgv = new DataGridView();
            tabPage3 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPecas_dgv).BeginInit();
            clienteTabPage.SuspendLayout();
            cliente_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientes_dgv).BeginInit();
            servicoTabPage.SuspendLayout();
            servico_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allServicos_dgv).BeginInit();
            SuspendLayout();
            // 
            // getPecasButton
            // 
            getPecasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            getPecasButton.BackColor = Color.DimGray;
            getPecasButton.FlatStyle = FlatStyle.Flat;
            getPecasButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            getPecasButton.ForeColor = Color.White;
            getPecasButton.Location = new Point(1113, 6);
            getPecasButton.MaximumSize = new Size(144, 43);
            getPecasButton.Name = "getPecasButton";
            getPecasButton.Size = new Size(144, 29);
            getPecasButton.TabIndex = 0;
            getPecasButton.Text = "Listar Todas Pecas";
            getPecasButton.UseVisualStyleBackColor = false;
            getPecasButton.Click += getPecasButton_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(pecaTabPage);
            mainTabControl.Controls.Add(clienteTabPage);
            mainTabControl.Controls.Add(servicoTabPage);
            mainTabControl.Controls.Add(tabPage3);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainTabControl.HotTrack = true;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1268, 761);
            mainTabControl.TabIndex = 18;
            mainTabControl.Selected += mainTabControl_Selected;
            // 
            // pecaTabPage
            // 
            pecaTabPage.Controls.Add(labelTotalRecords);
            pecaTabPage.Controls.Add(deleteButton);
            pecaTabPage.Controls.Add(editButton);
            pecaTabPage.Controls.Add(getPecasButton);
            pecaTabPage.Controls.Add(venderButton);
            pecaTabPage.Controls.Add(gb_pecasControl);
            pecaTabPage.Controls.Add(gb_pecas);
            pecaTabPage.Controls.Add(novaPecaButton);
            pecaTabPage.Controls.Add(searchPecaButton);
            pecaTabPage.Controls.Add(searchTextBox);
            pecaTabPage.Controls.Add(searchComboBox);
            pecaTabPage.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pecaTabPage.Location = new Point(4, 23);
            pecaTabPage.Name = "pecaTabPage";
            pecaTabPage.Padding = new Padding(3);
            pecaTabPage.Size = new Size(1260, 734);
            pecaTabPage.TabIndex = 0;
            pecaTabPage.Text = "Pecas";
            pecaTabPage.UseVisualStyleBackColor = true;
            // 
            // labelTotalRecords
            // 
            labelTotalRecords.AutoSize = true;
            labelTotalRecords.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalRecords.Location = new Point(8, 15);
            labelTotalRecords.Name = "labelTotalRecords";
            labelTotalRecords.Size = new Size(96, 14);
            labelTotalRecords.TabIndex = 2;
            labelTotalRecords.Text = "Total Records:";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(949, 679);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(305, 49);
            deleteButton.TabIndex = 62;
            deleteButton.Text = "DELETAR";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.BackColor = Color.SandyBrown;
            editButton.Enabled = false;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(638, 679);
            editButton.Name = "editButton";
            editButton.Size = new Size(305, 49);
            editButton.TabIndex = 66;
            editButton.Text = "Editar Peca";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // venderButton
            // 
            venderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            venderButton.BackColor = Color.LightSeaGreen;
            venderButton.Enabled = false;
            venderButton.FlatStyle = FlatStyle.Flat;
            venderButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            venderButton.ForeColor = Color.White;
            venderButton.Location = new Point(317, 679);
            venderButton.Name = "venderButton";
            venderButton.Size = new Size(305, 49);
            venderButton.TabIndex = 65;
            venderButton.Text = "Vender";
            venderButton.UseVisualStyleBackColor = false;
            venderButton.Click += venderButton_Click;
            // 
            // gb_pecasControl
            // 
            gb_pecasControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gb_pecasControl.AutoSize = true;
            gb_pecasControl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecasControl.Location = new Point(841, 41);
            gb_pecasControl.Name = "gb_pecasControl";
            gb_pecasControl.Size = new Size(416, 632);
            gb_pecasControl.TabIndex = 64;
            gb_pecasControl.TabStop = false;
            gb_pecasControl.Text = "Pecas";
            // 
            // gb_pecas
            // 
            gb_pecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_pecas.AutoSize = true;
            gb_pecas.Controls.Add(allPecas_dgv);
            gb_pecas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecas.Location = new Point(3, 41);
            gb_pecas.Name = "gb_pecas";
            gb_pecas.Size = new Size(833, 632);
            gb_pecas.TabIndex = 66;
            gb_pecas.TabStop = false;
            gb_pecas.Text = "Pecas";
            // 
            // allPecas_dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            allPecas_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            allPecas_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allPecas_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allPecas_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            allPecas_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            allPecas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPecas_dgv.Dock = DockStyle.Fill;
            allPecas_dgv.EnableHeadersVisualStyles = false;
            allPecas_dgv.Location = new Point(3, 18);
            allPecas_dgv.Name = "allPecas_dgv";
            allPecas_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            allPecas_dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            allPecas_dgv.RowTemplate.Height = 25;
            allPecas_dgv.Size = new Size(827, 611);
            allPecas_dgv.TabIndex = 1;
            allPecas_dgv.DataBindingComplete += allPecasDgv_DataBindingComplete;
            allPecas_dgv.RowHeaderMouseDoubleClick += allPecasDGV_RowHeaderMouseDoubleClick;
            // 
            // novaPecaButton
            // 
            novaPecaButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            novaPecaButton.BackColor = Color.SeaGreen;
            novaPecaButton.FlatStyle = FlatStyle.Flat;
            novaPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            novaPecaButton.ForeColor = Color.White;
            novaPecaButton.Location = new Point(6, 679);
            novaPecaButton.Name = "novaPecaButton";
            novaPecaButton.Size = new Size(305, 49);
            novaPecaButton.TabIndex = 48;
            novaPecaButton.Text = "Nova Peca";
            novaPecaButton.UseVisualStyleBackColor = false;
            novaPecaButton.Click += novaPecaButton_Click;
            // 
            // searchPecaButton
            // 
            searchPecaButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPecaButton.BackColor = Color.DimGray;
            searchPecaButton.FlatStyle = FlatStyle.Flat;
            searchPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchPecaButton.ForeColor = Color.White;
            searchPecaButton.Location = new Point(963, 7);
            searchPecaButton.Name = "searchPecaButton";
            searchPecaButton.Size = new Size(144, 27);
            searchPecaButton.TabIndex = 3;
            searchPecaButton.Text = "Buscar";
            searchPecaButton.UseVisualStyleBackColor = false;
            searchPecaButton.Click += searchPecaButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(687, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 22);
            searchTextBox.TabIndex = 2;
            // 
            // searchComboBox
            // 
            searchComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            searchComboBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "ID", "Nome", "Categoria" });
            searchComboBox.Location = new Point(560, 9);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(121, 22);
            searchComboBox.TabIndex = 4;
            searchComboBox.Text = "Buscar Por...";
            // 
            // clienteTabPage
            // 
            clienteTabPage.Controls.Add(deleteClienteButton);
            clienteTabPage.Controls.Add(editClienteButton);
            clienteTabPage.Controls.Add(clienteServicoButton);
            clienteTabPage.Controls.Add(totalClientesLabel);
            clienteTabPage.Controls.Add(listarClienteButton);
            clienteTabPage.Controls.Add(searchClienteButton);
            clienteTabPage.Controls.Add(novoClienteButton);
            clienteTabPage.Controls.Add(searchCliente_tb);
            clienteTabPage.Controls.Add(cliente_gb);
            clienteTabPage.Location = new Point(4, 23);
            clienteTabPage.Name = "clienteTabPage";
            clienteTabPage.Padding = new Padding(3);
            clienteTabPage.Size = new Size(1260, 734);
            clienteTabPage.TabIndex = 1;
            clienteTabPage.Text = "Clientes";
            clienteTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteClienteButton
            // 
            deleteClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteClienteButton.BackColor = Color.IndianRed;
            deleteClienteButton.Enabled = false;
            deleteClienteButton.FlatStyle = FlatStyle.Flat;
            deleteClienteButton.ForeColor = Color.White;
            deleteClienteButton.Location = new Point(949, 679);
            deleteClienteButton.Name = "deleteClienteButton";
            deleteClienteButton.Size = new Size(305, 49);
            deleteClienteButton.TabIndex = 67;
            deleteClienteButton.Text = "DELETAR";
            deleteClienteButton.UseVisualStyleBackColor = false;
            deleteClienteButton.Click += deleteClienteButton_Click;
            // 
            // editClienteButton
            // 
            editClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editClienteButton.BackColor = Color.SandyBrown;
            editClienteButton.Enabled = false;
            editClienteButton.FlatStyle = FlatStyle.Flat;
            editClienteButton.ForeColor = Color.White;
            editClienteButton.Location = new Point(638, 679);
            editClienteButton.Name = "editClienteButton";
            editClienteButton.Size = new Size(305, 49);
            editClienteButton.TabIndex = 68;
            editClienteButton.Text = "Editar";
            editClienteButton.UseVisualStyleBackColor = false;
            editClienteButton.Click += editClienteButton_Click;
            // 
            // clienteServicoButton
            // 
            clienteServicoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clienteServicoButton.BackColor = Color.LightSeaGreen;
            clienteServicoButton.Enabled = false;
            clienteServicoButton.FlatStyle = FlatStyle.Flat;
            clienteServicoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clienteServicoButton.ForeColor = Color.White;
            clienteServicoButton.Location = new Point(317, 679);
            clienteServicoButton.Name = "clienteServicoButton";
            clienteServicoButton.Size = new Size(305, 49);
            clienteServicoButton.TabIndex = 69;
            clienteServicoButton.Text = "Criar Servico";
            clienteServicoButton.UseVisualStyleBackColor = false;
            clienteServicoButton.Click += clienteServicoButton_Click;
            // 
            // totalClientesLabel
            // 
            totalClientesLabel.AutoSize = true;
            totalClientesLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalClientesLabel.Location = new Point(8, 15);
            totalClientesLabel.Name = "totalClientesLabel";
            totalClientesLabel.Size = new Size(96, 14);
            totalClientesLabel.TabIndex = 5;
            totalClientesLabel.Text = "Total Records:";
            // 
            // listarClienteButton
            // 
            listarClienteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarClienteButton.BackColor = Color.DimGray;
            listarClienteButton.FlatStyle = FlatStyle.Flat;
            listarClienteButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarClienteButton.ForeColor = Color.White;
            listarClienteButton.Location = new Point(1113, 6);
            listarClienteButton.MaximumSize = new Size(144, 43);
            listarClienteButton.Name = "listarClienteButton";
            listarClienteButton.Size = new Size(144, 29);
            listarClienteButton.TabIndex = 4;
            listarClienteButton.Text = "Listar Clientes";
            listarClienteButton.UseVisualStyleBackColor = false;
            listarClienteButton.Click += listarClienteButton_Click;
            // 
            // searchClienteButton
            // 
            searchClienteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchClienteButton.BackColor = Color.DimGray;
            searchClienteButton.FlatStyle = FlatStyle.Flat;
            searchClienteButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchClienteButton.ForeColor = Color.White;
            searchClienteButton.Location = new Point(963, 7);
            searchClienteButton.Name = "searchClienteButton";
            searchClienteButton.Size = new Size(144, 27);
            searchClienteButton.TabIndex = 7;
            searchClienteButton.Text = "Buscar";
            searchClienteButton.UseVisualStyleBackColor = false;
            searchClienteButton.Click += buscarClienteButton_Click;
            // 
            // novoClienteButton
            // 
            novoClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            novoClienteButton.BackColor = Color.SeaGreen;
            novoClienteButton.FlatStyle = FlatStyle.Flat;
            novoClienteButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            novoClienteButton.ForeColor = Color.White;
            novoClienteButton.Location = new Point(6, 679);
            novoClienteButton.Name = "novoClienteButton";
            novoClienteButton.Size = new Size(305, 49);
            novoClienteButton.TabIndex = 49;
            novoClienteButton.Text = "Novo Cliente";
            novoClienteButton.UseVisualStyleBackColor = false;
            novoClienteButton.Click += novoClienteButton_Click;
            // 
            // searchCliente_tb
            // 
            searchCliente_tb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchCliente_tb.Location = new Point(687, 9);
            searchCliente_tb.Name = "searchCliente_tb";
            searchCliente_tb.Size = new Size(270, 22);
            searchCliente_tb.TabIndex = 6;
            // 
            // cliente_gb
            // 
            cliente_gb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cliente_gb.Controls.Add(allClientes_dgv);
            cliente_gb.Location = new Point(3, 41);
            cliente_gb.Name = "cliente_gb";
            cliente_gb.Size = new Size(1254, 632);
            cliente_gb.TabIndex = 0;
            cliente_gb.TabStop = false;
            cliente_gb.Text = "Clientes";
            // 
            // allClientes_dgv
            // 
            allClientes_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allClientes_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allClientes_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            allClientes_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            allClientes_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allClientes_dgv.Dock = DockStyle.Fill;
            allClientes_dgv.EnableHeadersVisualStyles = false;
            allClientes_dgv.Location = new Point(3, 18);
            allClientes_dgv.Name = "allClientes_dgv";
            allClientes_dgv.ReadOnly = true;
            dataGridViewCellStyle5.Padding = new Padding(3);
            allClientes_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            allClientes_dgv.RowTemplate.Height = 25;
            allClientes_dgv.Size = new Size(1248, 611);
            allClientes_dgv.TabIndex = 0;
            allClientes_dgv.DataBindingComplete += allClientes_dgv_DataBindingComplete;
            allClientes_dgv.RowHeaderMouseDoubleClick += allClientesDgv_RowHeaderMouseDoubleClick;
            // 
            // servicoTabPage
            // 
            servicoTabPage.Controls.Add(servico_gb);
            servicoTabPage.Location = new Point(4, 23);
            servicoTabPage.Name = "servicoTabPage";
            servicoTabPage.Padding = new Padding(3);
            servicoTabPage.Size = new Size(1260, 734);
            servicoTabPage.TabIndex = 2;
            servicoTabPage.Text = "Servicos";
            servicoTabPage.UseVisualStyleBackColor = true;
            // 
            // servico_gb
            // 
            servico_gb.Controls.Add(allServicos_dgv);
            servico_gb.Location = new Point(3, 41);
            servico_gb.Name = "servico_gb";
            servico_gb.Size = new Size(704, 467);
            servico_gb.TabIndex = 0;
            servico_gb.TabStop = false;
            servico_gb.Text = "Servicos";
            // 
            // allServicos_dgv
            // 
            allServicos_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allServicos_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allServicos_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            allServicos_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            allServicos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allServicos_dgv.Dock = DockStyle.Fill;
            allServicos_dgv.EnableHeadersVisualStyles = false;
            allServicos_dgv.Location = new Point(3, 18);
            allServicos_dgv.Name = "allServicos_dgv";
            allServicos_dgv.ReadOnly = true;
            dataGridViewCellStyle7.Padding = new Padding(3);
            allServicos_dgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            allServicos_dgv.RowTemplate.Height = 25;
            allServicos_dgv.Size = new Size(698, 446);
            allServicos_dgv.TabIndex = 1;
            allServicos_dgv.DataBindingComplete += allServicos_dgv_DataBindingComplete;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 23);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1260, 734);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1268, 761);
            Controls.Add(mainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batata Motos - Main";
            Load += Form1_Load;
            mainTabControl.ResumeLayout(false);
            pecaTabPage.ResumeLayout(false);
            pecaTabPage.PerformLayout();
            gb_pecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allPecas_dgv).EndInit();
            clienteTabPage.ResumeLayout(false);
            clienteTabPage.PerformLayout();
            cliente_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientes_dgv).EndInit();
            servicoTabPage.ResumeLayout(false);
            servico_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allServicos_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button getPecasButton;
        private TabControl mainTabControl;
        private TabPage pecaTabPage;
        private TabPage clienteTabPage;
        private TextBox searchTextBox;
        private Button searchPecaButton;
        private ComboBox searchComboBox;
        private GroupBox gb_pecasControl;
        private Button deleteButton;
        private Button novaPecaButton;
        private DataGridView allPecas_dgv;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private TabPage servicoTabPage;
        private TabPage tabPage3;
        private GroupBox cliente_gb;
        private DataGridView allClientes_dgv;
        private Button venderButton;
        private Button editButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button novoClienteButton;
        private Label totalClientesLabel;
        private Button listarClienteButton;
        private Button searchClienteButton;
        private TextBox searchCliente_tb;
        private Button editClienteButton;
        private Button deleteClienteButton;
        private Button clienteServicoButton;
        private GroupBox servico_gb;
        private DataGridView allServicos_dgv;
    }
}