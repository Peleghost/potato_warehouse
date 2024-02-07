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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listarPecas_btn = new Button();
            mainTabControl = new TabControl();
            pecaTabPage = new TabPage();
            labelTotalRecords = new Label();
            deletePeca_btn = new Button();
            editPeca_btn = new Button();
            venderPeca_btn = new Button();
            gb_pecasControl = new GroupBox();
            gb_pecas = new GroupBox();
            allPecas_dgv = new DataGridView();
            novaPeca_btn = new Button();
            searchPeca_btn = new Button();
            searchTextBox = new TextBox();
            searchPeca_combo = new ComboBox();
            clienteTabPage = new TabPage();
            deleteCliente_btn = new Button();
            editCliente_btn = new Button();
            clienteServico_btn = new Button();
            totalClientesLabel = new Label();
            listarCliente_btn = new Button();
            searchCliente_btn = new Button();
            novoCliente_btn = new Button();
            searchCliente_tb = new TextBox();
            cliente_gb = new GroupBox();
            allClientes_dgv = new DataGridView();
            servicoTabPage = new TabPage();
            label3 = new Label();
            label2 = new Label();
            dateStart_picker = new DateTimePicker();
            dateEnd_picker = new DateTimePicker();
            searchServico_combo = new ComboBox();
            servico2_gb = new GroupBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            servicoValor_tb = new TextBox();
            label6 = new Label();
            servicoPecaValor_tb = new TextBox();
            label5 = new Label();
            servicoValorTotal_tb = new TextBox();
            label4 = new Label();
            adicionarPecas_btn = new Button();
            servicoPeca_gb = new GroupBox();
            servicoPecas_dgv = new DataGridView();
            label1 = new Label();
            servicoDescricao_tb = new RichTextBox();
            listarServico_btn = new Button();
            searchServico_btn = new Button();
            searchServico_tb = new TextBox();
            deleteServico_btn = new Button();
            editarServico_btn = new Button();
            finalServico_btn = new Button();
            servicoSemCadastroButton = new Button();
            servico_gb = new GroupBox();
            allServicos_dgv = new DataGridView();
            veiculoTabPage = new TabPage();
            searchVeiculo_combo = new ComboBox();
            deleteVeiculo_btn = new Button();
            editVeiculo_btn = new Button();
            button3 = new Button();
            criarVeiculoButton = new Button();
            groupBox3 = new GroupBox();
            listarVeiculo_btn = new Button();
            searchVeiculo_btn = new Button();
            searchVeiculo_tb = new TextBox();
            groupBox2 = new GroupBox();
            allVeiculos_dgv = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPecas_dgv).BeginInit();
            clienteTabPage.SuspendLayout();
            cliente_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientes_dgv).BeginInit();
            servicoTabPage.SuspendLayout();
            servico2_gb.SuspendLayout();
            groupBox1.SuspendLayout();
            servicoPeca_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoPecas_dgv).BeginInit();
            servico_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allServicos_dgv).BeginInit();
            veiculoTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allVeiculos_dgv).BeginInit();
            SuspendLayout();
            // 
            // listarPecas_btn
            // 
            listarPecas_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarPecas_btn.BackColor = Color.DimGray;
            listarPecas_btn.FlatStyle = FlatStyle.Flat;
            listarPecas_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarPecas_btn.ForeColor = Color.White;
            listarPecas_btn.Location = new Point(1113, 6);
            listarPecas_btn.MaximumSize = new Size(144, 43);
            listarPecas_btn.Name = "listarPecas_btn";
            listarPecas_btn.Size = new Size(144, 29);
            listarPecas_btn.TabIndex = 0;
            listarPecas_btn.Text = "Listar Todas Pecas";
            listarPecas_btn.UseVisualStyleBackColor = false;
            listarPecas_btn.Click += listarPecas_btn_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(pecaTabPage);
            mainTabControl.Controls.Add(clienteTabPage);
            mainTabControl.Controls.Add(servicoTabPage);
            mainTabControl.Controls.Add(veiculoTabPage);
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
            pecaTabPage.Controls.Add(deletePeca_btn);
            pecaTabPage.Controls.Add(editPeca_btn);
            pecaTabPage.Controls.Add(listarPecas_btn);
            pecaTabPage.Controls.Add(venderPeca_btn);
            pecaTabPage.Controls.Add(gb_pecasControl);
            pecaTabPage.Controls.Add(gb_pecas);
            pecaTabPage.Controls.Add(novaPeca_btn);
            pecaTabPage.Controls.Add(searchPeca_btn);
            pecaTabPage.Controls.Add(searchTextBox);
            pecaTabPage.Controls.Add(searchPeca_combo);
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
            // deletePeca_btn
            // 
            deletePeca_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deletePeca_btn.BackColor = Color.IndianRed;
            deletePeca_btn.Enabled = false;
            deletePeca_btn.FlatStyle = FlatStyle.Flat;
            deletePeca_btn.ForeColor = Color.White;
            deletePeca_btn.Location = new Point(949, 679);
            deletePeca_btn.Name = "deletePeca_btn";
            deletePeca_btn.Size = new Size(305, 49);
            deletePeca_btn.TabIndex = 62;
            deletePeca_btn.Text = "DELETAR";
            deletePeca_btn.UseVisualStyleBackColor = false;
            deletePeca_btn.Click += deletePeca_btn_Click;
            // 
            // editPeca_btn
            // 
            editPeca_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPeca_btn.BackColor = Color.SandyBrown;
            editPeca_btn.Enabled = false;
            editPeca_btn.FlatStyle = FlatStyle.Flat;
            editPeca_btn.ForeColor = Color.White;
            editPeca_btn.Location = new Point(638, 679);
            editPeca_btn.Name = "editPeca_btn";
            editPeca_btn.Size = new Size(305, 49);
            editPeca_btn.TabIndex = 66;
            editPeca_btn.Text = "Editar Peca";
            editPeca_btn.UseVisualStyleBackColor = false;
            editPeca_btn.Click += editPeca_btn_Click;
            // 
            // venderPeca_btn
            // 
            venderPeca_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            venderPeca_btn.BackColor = Color.LightSeaGreen;
            venderPeca_btn.Enabled = false;
            venderPeca_btn.FlatStyle = FlatStyle.Flat;
            venderPeca_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            venderPeca_btn.ForeColor = Color.White;
            venderPeca_btn.Location = new Point(317, 679);
            venderPeca_btn.Name = "venderPeca_btn";
            venderPeca_btn.Size = new Size(305, 49);
            venderPeca_btn.TabIndex = 65;
            venderPeca_btn.Text = "Vender";
            venderPeca_btn.UseVisualStyleBackColor = false;
            venderPeca_btn.Click += venderPeca_btn_Click;
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
            // novaPeca_btn
            // 
            novaPeca_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            novaPeca_btn.BackColor = Color.SeaGreen;
            novaPeca_btn.FlatStyle = FlatStyle.Flat;
            novaPeca_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            novaPeca_btn.ForeColor = Color.White;
            novaPeca_btn.Location = new Point(6, 679);
            novaPeca_btn.Name = "novaPeca_btn";
            novaPeca_btn.Size = new Size(305, 49);
            novaPeca_btn.TabIndex = 48;
            novaPeca_btn.Text = "Nova Peca";
            novaPeca_btn.UseVisualStyleBackColor = false;
            novaPeca_btn.Click += novaPeca_btn_Click;
            // 
            // searchPeca_btn
            // 
            searchPeca_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPeca_btn.BackColor = Color.DimGray;
            searchPeca_btn.FlatStyle = FlatStyle.Flat;
            searchPeca_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchPeca_btn.ForeColor = Color.White;
            searchPeca_btn.Location = new Point(963, 7);
            searchPeca_btn.Name = "searchPeca_btn";
            searchPeca_btn.Size = new Size(144, 27);
            searchPeca_btn.TabIndex = 3;
            searchPeca_btn.Text = "Buscar";
            searchPeca_btn.UseVisualStyleBackColor = false;
            searchPeca_btn.Click += searchPeca_btn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(687, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 22);
            searchTextBox.TabIndex = 2;
            // 
            // searchPeca_combo
            // 
            searchPeca_combo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPeca_combo.AutoCompleteMode = AutoCompleteMode.Append;
            searchPeca_combo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchPeca_combo.FormattingEnabled = true;
            searchPeca_combo.Items.AddRange(new object[] { "ID", "Nome", "Categoria" });
            searchPeca_combo.Location = new Point(560, 9);
            searchPeca_combo.Name = "searchPeca_combo";
            searchPeca_combo.Size = new Size(121, 22);
            searchPeca_combo.TabIndex = 4;
            searchPeca_combo.Text = "Buscar Por...";
            // 
            // clienteTabPage
            // 
            clienteTabPage.Controls.Add(deleteCliente_btn);
            clienteTabPage.Controls.Add(editCliente_btn);
            clienteTabPage.Controls.Add(clienteServico_btn);
            clienteTabPage.Controls.Add(totalClientesLabel);
            clienteTabPage.Controls.Add(listarCliente_btn);
            clienteTabPage.Controls.Add(searchCliente_btn);
            clienteTabPage.Controls.Add(novoCliente_btn);
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
            // deleteCliente_btn
            // 
            deleteCliente_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteCliente_btn.BackColor = Color.IndianRed;
            deleteCliente_btn.Enabled = false;
            deleteCliente_btn.FlatStyle = FlatStyle.Flat;
            deleteCliente_btn.ForeColor = Color.White;
            deleteCliente_btn.Location = new Point(949, 679);
            deleteCliente_btn.Name = "deleteCliente_btn";
            deleteCliente_btn.Size = new Size(305, 49);
            deleteCliente_btn.TabIndex = 67;
            deleteCliente_btn.Text = "DELETAR";
            deleteCliente_btn.UseVisualStyleBackColor = false;
            deleteCliente_btn.Click += deleteCliente_btn_Click;
            // 
            // editCliente_btn
            // 
            editCliente_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCliente_btn.BackColor = Color.SandyBrown;
            editCliente_btn.Enabled = false;
            editCliente_btn.FlatStyle = FlatStyle.Flat;
            editCliente_btn.ForeColor = Color.White;
            editCliente_btn.Location = new Point(638, 679);
            editCliente_btn.Name = "editCliente_btn";
            editCliente_btn.Size = new Size(305, 49);
            editCliente_btn.TabIndex = 68;
            editCliente_btn.Text = "Editar";
            editCliente_btn.UseVisualStyleBackColor = false;
            editCliente_btn.Click += editCliente_btn_Click;
            // 
            // clienteServico_btn
            // 
            clienteServico_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clienteServico_btn.BackColor = Color.LightSeaGreen;
            clienteServico_btn.Enabled = false;
            clienteServico_btn.FlatStyle = FlatStyle.Flat;
            clienteServico_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clienteServico_btn.ForeColor = Color.White;
            clienteServico_btn.Location = new Point(317, 679);
            clienteServico_btn.Name = "clienteServico_btn";
            clienteServico_btn.Size = new Size(305, 49);
            clienteServico_btn.TabIndex = 69;
            clienteServico_btn.Text = "Criar Servico";
            clienteServico_btn.UseVisualStyleBackColor = false;
            clienteServico_btn.Click += clienteServico_btn_Click;
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
            // listarCliente_btn
            // 
            listarCliente_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarCliente_btn.BackColor = Color.DimGray;
            listarCliente_btn.FlatStyle = FlatStyle.Flat;
            listarCliente_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarCliente_btn.ForeColor = Color.White;
            listarCliente_btn.Location = new Point(1113, 6);
            listarCliente_btn.MaximumSize = new Size(144, 43);
            listarCliente_btn.Name = "listarCliente_btn";
            listarCliente_btn.Size = new Size(144, 29);
            listarCliente_btn.TabIndex = 4;
            listarCliente_btn.Text = "Listar Clientes";
            listarCliente_btn.UseVisualStyleBackColor = false;
            listarCliente_btn.Click += listarCliente_btn_Click;
            // 
            // searchCliente_btn
            // 
            searchCliente_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchCliente_btn.BackColor = Color.DimGray;
            searchCliente_btn.FlatStyle = FlatStyle.Flat;
            searchCliente_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCliente_btn.ForeColor = Color.White;
            searchCliente_btn.Location = new Point(963, 7);
            searchCliente_btn.Name = "searchCliente_btn";
            searchCliente_btn.Size = new Size(144, 27);
            searchCliente_btn.TabIndex = 7;
            searchCliente_btn.Text = "Buscar";
            searchCliente_btn.UseVisualStyleBackColor = false;
            searchCliente_btn.Click += buscarCliente_btn_Click;
            // 
            // novoCliente_btn
            // 
            novoCliente_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            novoCliente_btn.BackColor = Color.SeaGreen;
            novoCliente_btn.FlatStyle = FlatStyle.Flat;
            novoCliente_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            novoCliente_btn.ForeColor = Color.White;
            novoCliente_btn.Location = new Point(6, 679);
            novoCliente_btn.Name = "novoCliente_btn";
            novoCliente_btn.Size = new Size(305, 49);
            novoCliente_btn.TabIndex = 49;
            novoCliente_btn.Text = "Novo Cliente";
            novoCliente_btn.UseVisualStyleBackColor = false;
            novoCliente_btn.Click += novoCliente_btn_Click;
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
            servicoTabPage.Controls.Add(label3);
            servicoTabPage.Controls.Add(label2);
            servicoTabPage.Controls.Add(dateStart_picker);
            servicoTabPage.Controls.Add(dateEnd_picker);
            servicoTabPage.Controls.Add(searchServico_combo);
            servicoTabPage.Controls.Add(servico2_gb);
            servicoTabPage.Controls.Add(listarServico_btn);
            servicoTabPage.Controls.Add(searchServico_btn);
            servicoTabPage.Controls.Add(searchServico_tb);
            servicoTabPage.Controls.Add(deleteServico_btn);
            servicoTabPage.Controls.Add(editarServico_btn);
            servicoTabPage.Controls.Add(finalServico_btn);
            servicoTabPage.Controls.Add(servicoSemCadastroButton);
            servicoTabPage.Controls.Add(servico_gb);
            servicoTabPage.Location = new Point(4, 23);
            servicoTabPage.Name = "servicoTabPage";
            servicoTabPage.Padding = new Padding(3);
            servicoTabPage.Size = new Size(1260, 734);
            servicoTabPage.TabIndex = 2;
            servicoTabPage.Text = "Servicos";
            servicoTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 12);
            label3.Name = "label3";
            label3.Size = new Size(29, 14);
            label3.TabIndex = 82;
            label3.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 13);
            label2.Name = "label2";
            label2.Size = new Size(33, 14);
            label2.TabIndex = 81;
            label2.Text = "Até:";
            // 
            // dateStart_picker
            // 
            dateStart_picker.Format = DateTimePickerFormat.Short;
            dateStart_picker.Location = new Point(277, 9);
            dateStart_picker.Name = "dateStart_picker";
            dateStart_picker.Size = new Size(116, 22);
            dateStart_picker.TabIndex = 80;
            // 
            // dateEnd_picker
            // 
            dateEnd_picker.Format = DateTimePickerFormat.Short;
            dateEnd_picker.Location = new Point(438, 9);
            dateEnd_picker.Name = "dateEnd_picker";
            dateEnd_picker.Size = new Size(116, 22);
            dateEnd_picker.TabIndex = 79;
            // 
            // searchServico_combo
            // 
            searchServico_combo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchServico_combo.AutoCompleteMode = AutoCompleteMode.Append;
            searchServico_combo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchServico_combo.FormattingEnabled = true;
            searchServico_combo.Items.AddRange(new object[] { "Cliente_Nome", "Veiculo_Placa", "Data" });
            searchServico_combo.Location = new Point(560, 9);
            searchServico_combo.Name = "searchServico_combo";
            searchServico_combo.Size = new Size(121, 22);
            searchServico_combo.TabIndex = 78;
            searchServico_combo.Text = "Buscar Por...";
            // 
            // servico2_gb
            // 
            servico2_gb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            servico2_gb.AutoSize = true;
            servico2_gb.Controls.Add(groupBox1);
            servico2_gb.Controls.Add(adicionarPecas_btn);
            servico2_gb.Controls.Add(servicoPeca_gb);
            servico2_gb.Controls.Add(label1);
            servico2_gb.Controls.Add(servicoDescricao_tb);
            servico2_gb.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servico2_gb.Location = new Point(826, 41);
            servico2_gb.MaximumSize = new Size(431, 632);
            servico2_gb.MinimumSize = new Size(431, 632);
            servico2_gb.Name = "servico2_gb";
            servico2_gb.Size = new Size(431, 632);
            servico2_gb.TabIndex = 77;
            servico2_gb.TabStop = false;
            servico2_gb.Text = "Detalhes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(servicoValor_tb);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(servicoPecaValor_tb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(servicoValorTotal_tb);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(6, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 185);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "$$$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 109);
            label8.Name = "label8";
            label8.Size = new Size(17, 14);
            label8.TabIndex = 11;
            label8.Text = "||";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 52);
            label7.Name = "label7";
            label7.Size = new Size(16, 14);
            label7.TabIndex = 10;
            label7.Text = "+";
            // 
            // servicoValor_tb
            // 
            servicoValor_tb.Location = new Point(69, 21);
            servicoValor_tb.Name = "servicoValor_tb";
            servicoValor_tb.ReadOnly = true;
            servicoValor_tb.Size = new Size(344, 22);
            servicoValor_tb.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 80);
            label6.Name = "label6";
            label6.Size = new Size(49, 14);
            label6.TabIndex = 9;
            label6.Text = "Pecas:";
            // 
            // servicoPecaValor_tb
            // 
            servicoPecaValor_tb.Location = new Point(69, 77);
            servicoPecaValor_tb.Name = "servicoPecaValor_tb";
            servicoPecaValor_tb.ReadOnly = true;
            servicoPecaValor_tb.Size = new Size(344, 22);
            servicoPecaValor_tb.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 136);
            label5.Name = "label5";
            label5.Size = new Size(42, 14);
            label5.TabIndex = 8;
            label5.Text = "Total:";
            // 
            // servicoValorTotal_tb
            // 
            servicoValorTotal_tb.BackColor = SystemColors.Control;
            servicoValorTotal_tb.Location = new Point(69, 133);
            servicoValorTotal_tb.Name = "servicoValorTotal_tb";
            servicoValorTotal_tb.ReadOnly = true;
            servicoValorTotal_tb.Size = new Size(344, 22);
            servicoValorTotal_tb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(57, 14);
            label4.TabIndex = 7;
            label4.Text = "Servico:";
            // 
            // adicionarPecas_btn
            // 
            adicionarPecas_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adicionarPecas_btn.BackColor = Color.SandyBrown;
            adicionarPecas_btn.Enabled = false;
            adicionarPecas_btn.FlatStyle = FlatStyle.Flat;
            adicionarPecas_btn.ForeColor = Color.White;
            adicionarPecas_btn.Location = new Point(8, 356);
            adicionarPecas_btn.Name = "adicionarPecas_btn";
            adicionarPecas_btn.Size = new Size(417, 49);
            adicionarPecas_btn.TabIndex = 3;
            adicionarPecas_btn.Text = "Adicionar Pecas";
            adicionarPecas_btn.UseVisualStyleBackColor = false;
            adicionarPecas_btn.Click += adicionarPecas_btn_Click;
            // 
            // servicoPeca_gb
            // 
            servicoPeca_gb.Controls.Add(servicoPecas_dgv);
            servicoPeca_gb.Location = new Point(5, 172);
            servicoPeca_gb.Name = "servicoPeca_gb";
            servicoPeca_gb.Size = new Size(423, 181);
            servicoPeca_gb.TabIndex = 2;
            servicoPeca_gb.TabStop = false;
            servicoPeca_gb.Text = "Pecas em Servico";
            // 
            // servicoPecas_dgv
            // 
            servicoPecas_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicoPecas_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicoPecas_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            servicoPecas_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            servicoPecas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoPecas_dgv.Dock = DockStyle.Fill;
            servicoPecas_dgv.EnableHeadersVisualStyles = false;
            servicoPecas_dgv.Location = new Point(3, 18);
            servicoPecas_dgv.Name = "servicoPecas_dgv";
            servicoPecas_dgv.ReadOnly = true;
            dataGridViewCellStyle7.Padding = new Padding(3);
            servicoPecas_dgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            servicoPecas_dgv.RowTemplate.Height = 25;
            servicoPecas_dgv.Size = new Size(417, 160);
            servicoPecas_dgv.TabIndex = 2;
            servicoPecas_dgv.DataBindingComplete += servicoPecas_dgv_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 14);
            label1.TabIndex = 1;
            label1.Text = "Descricao:";
            // 
            // servicoDescricao_tb
            // 
            servicoDescricao_tb.Location = new Point(5, 48);
            servicoDescricao_tb.Name = "servicoDescricao_tb";
            servicoDescricao_tb.Size = new Size(423, 118);
            servicoDescricao_tb.TabIndex = 0;
            servicoDescricao_tb.Text = "";
            // 
            // listarServico_btn
            // 
            listarServico_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarServico_btn.BackColor = Color.DimGray;
            listarServico_btn.FlatStyle = FlatStyle.Flat;
            listarServico_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarServico_btn.ForeColor = Color.White;
            listarServico_btn.Location = new Point(1113, 6);
            listarServico_btn.MaximumSize = new Size(144, 43);
            listarServico_btn.Name = "listarServico_btn";
            listarServico_btn.Size = new Size(144, 29);
            listarServico_btn.TabIndex = 74;
            listarServico_btn.Text = "Listar Servicos";
            listarServico_btn.UseVisualStyleBackColor = false;
            listarServico_btn.Click += listarServico_btn_Click;
            // 
            // searchServico_btn
            // 
            searchServico_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchServico_btn.BackColor = Color.DimGray;
            searchServico_btn.FlatStyle = FlatStyle.Flat;
            searchServico_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchServico_btn.ForeColor = Color.White;
            searchServico_btn.Location = new Point(963, 7);
            searchServico_btn.Name = "searchServico_btn";
            searchServico_btn.Size = new Size(144, 27);
            searchServico_btn.TabIndex = 76;
            searchServico_btn.Text = "Buscar";
            searchServico_btn.UseVisualStyleBackColor = false;
            searchServico_btn.Click += searchServico_btn_Click;
            // 
            // searchServico_tb
            // 
            searchServico_tb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchServico_tb.Location = new Point(687, 9);
            searchServico_tb.Name = "searchServico_tb";
            searchServico_tb.Size = new Size(270, 22);
            searchServico_tb.TabIndex = 75;
            // 
            // deleteServico_btn
            // 
            deleteServico_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteServico_btn.BackColor = Color.IndianRed;
            deleteServico_btn.Enabled = false;
            deleteServico_btn.FlatStyle = FlatStyle.Flat;
            deleteServico_btn.ForeColor = Color.White;
            deleteServico_btn.Location = new Point(949, 679);
            deleteServico_btn.Name = "deleteServico_btn";
            deleteServico_btn.Size = new Size(305, 49);
            deleteServico_btn.TabIndex = 71;
            deleteServico_btn.Text = "DELETAR";
            deleteServico_btn.UseVisualStyleBackColor = false;
            deleteServico_btn.Click += deleteServico_btn_Click;
            // 
            // editarServico_btn
            // 
            editarServico_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editarServico_btn.BackColor = Color.SandyBrown;
            editarServico_btn.Enabled = false;
            editarServico_btn.FlatStyle = FlatStyle.Flat;
            editarServico_btn.ForeColor = Color.White;
            editarServico_btn.Location = new Point(638, 679);
            editarServico_btn.Name = "editarServico_btn";
            editarServico_btn.Size = new Size(305, 49);
            editarServico_btn.TabIndex = 72;
            editarServico_btn.Text = "Editar";
            editarServico_btn.UseVisualStyleBackColor = false;
            editarServico_btn.Click += editarServico_btn_Click;
            // 
            // finalServico_btn
            // 
            finalServico_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            finalServico_btn.BackColor = Color.LightSeaGreen;
            finalServico_btn.Enabled = false;
            finalServico_btn.FlatStyle = FlatStyle.Flat;
            finalServico_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            finalServico_btn.ForeColor = Color.White;
            finalServico_btn.Location = new Point(317, 679);
            finalServico_btn.Name = "finalServico_btn";
            finalServico_btn.Size = new Size(305, 49);
            finalServico_btn.TabIndex = 73;
            finalServico_btn.Text = "Finalizar Servico";
            finalServico_btn.UseVisualStyleBackColor = false;
            finalServico_btn.Click += finalServico_btn_Click;
            // 
            // servicoSemCadastroButton
            // 
            servicoSemCadastroButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            servicoSemCadastroButton.BackColor = Color.SeaGreen;
            servicoSemCadastroButton.Enabled = false;
            servicoSemCadastroButton.FlatStyle = FlatStyle.Flat;
            servicoSemCadastroButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servicoSemCadastroButton.ForeColor = Color.White;
            servicoSemCadastroButton.Location = new Point(6, 679);
            servicoSemCadastroButton.Name = "servicoSemCadastroButton";
            servicoSemCadastroButton.Size = new Size(305, 49);
            servicoSemCadastroButton.TabIndex = 70;
            servicoSemCadastroButton.Text = "------------";
            servicoSemCadastroButton.UseVisualStyleBackColor = false;
            // 
            // servico_gb
            // 
            servico_gb.Controls.Add(allServicos_dgv);
            servico_gb.Location = new Point(3, 41);
            servico_gb.Name = "servico_gb";
            servico_gb.Size = new Size(820, 632);
            servico_gb.TabIndex = 0;
            servico_gb.TabStop = false;
            servico_gb.Text = "Servicos";
            // 
            // allServicos_dgv
            // 
            allServicos_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allServicos_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allServicos_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            allServicos_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            allServicos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allServicos_dgv.Dock = DockStyle.Fill;
            allServicos_dgv.EnableHeadersVisualStyles = false;
            allServicos_dgv.Location = new Point(3, 18);
            allServicos_dgv.Name = "allServicos_dgv";
            allServicos_dgv.ReadOnly = true;
            dataGridViewCellStyle9.Padding = new Padding(3);
            allServicos_dgv.RowsDefaultCellStyle = dataGridViewCellStyle9;
            allServicos_dgv.RowTemplate.Height = 25;
            allServicos_dgv.Size = new Size(814, 611);
            allServicos_dgv.TabIndex = 1;
            allServicos_dgv.DataBindingComplete += allServicos_dgv_DataBindingComplete;
            allServicos_dgv.RowHeaderMouseDoubleClick += allServicos_dgv_RowHeaderMouseDoubleClick;
            // 
            // veiculoTabPage
            // 
            veiculoTabPage.Controls.Add(searchVeiculo_combo);
            veiculoTabPage.Controls.Add(deleteVeiculo_btn);
            veiculoTabPage.Controls.Add(editVeiculo_btn);
            veiculoTabPage.Controls.Add(button3);
            veiculoTabPage.Controls.Add(criarVeiculoButton);
            veiculoTabPage.Controls.Add(groupBox3);
            veiculoTabPage.Controls.Add(listarVeiculo_btn);
            veiculoTabPage.Controls.Add(searchVeiculo_btn);
            veiculoTabPage.Controls.Add(searchVeiculo_tb);
            veiculoTabPage.Controls.Add(groupBox2);
            veiculoTabPage.Location = new Point(4, 23);
            veiculoTabPage.Name = "veiculoTabPage";
            veiculoTabPage.Padding = new Padding(3);
            veiculoTabPage.Size = new Size(1260, 734);
            veiculoTabPage.TabIndex = 3;
            veiculoTabPage.Text = "Veiculos";
            veiculoTabPage.UseVisualStyleBackColor = true;
            // 
            // searchVeiculo_combo
            // 
            searchVeiculo_combo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchVeiculo_combo.AutoCompleteMode = AutoCompleteMode.Append;
            searchVeiculo_combo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchVeiculo_combo.FormattingEnabled = true;
            searchVeiculo_combo.Items.AddRange(new object[] { "Cliente", "Marca", "Modelo", "Placa" });
            searchVeiculo_combo.Location = new Point(560, 9);
            searchVeiculo_combo.Name = "searchVeiculo_combo";
            searchVeiculo_combo.Size = new Size(121, 22);
            searchVeiculo_combo.TabIndex = 85;
            searchVeiculo_combo.Text = "Buscar Por...";
            // 
            // deleteVeiculo_btn
            // 
            deleteVeiculo_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteVeiculo_btn.BackColor = Color.IndianRed;
            deleteVeiculo_btn.Enabled = false;
            deleteVeiculo_btn.FlatStyle = FlatStyle.Flat;
            deleteVeiculo_btn.ForeColor = Color.White;
            deleteVeiculo_btn.Location = new Point(949, 679);
            deleteVeiculo_btn.Name = "deleteVeiculo_btn";
            deleteVeiculo_btn.Size = new Size(305, 49);
            deleteVeiculo_btn.TabIndex = 82;
            deleteVeiculo_btn.Text = "DELETAR";
            deleteVeiculo_btn.UseVisualStyleBackColor = false;
            deleteVeiculo_btn.Click += deleteVeiculo_btn_Click;
            // 
            // editVeiculo_btn
            // 
            editVeiculo_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editVeiculo_btn.BackColor = Color.SandyBrown;
            editVeiculo_btn.Enabled = false;
            editVeiculo_btn.FlatStyle = FlatStyle.Flat;
            editVeiculo_btn.ForeColor = Color.White;
            editVeiculo_btn.Location = new Point(638, 679);
            editVeiculo_btn.Name = "editVeiculo_btn";
            editVeiculo_btn.Size = new Size(305, 49);
            editVeiculo_btn.TabIndex = 83;
            editVeiculo_btn.Text = "Editar";
            editVeiculo_btn.UseVisualStyleBackColor = false;
            editVeiculo_btn.Click += editVeiculo_btn_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.LightSeaGreen;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(317, 679);
            button3.Name = "button3";
            button3.Size = new Size(305, 49);
            button3.TabIndex = 84;
            button3.Text = "------------";
            button3.UseVisualStyleBackColor = false;
            // 
            // criarVeiculoButton
            // 
            criarVeiculoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            criarVeiculoButton.BackColor = Color.SeaGreen;
            criarVeiculoButton.FlatStyle = FlatStyle.Flat;
            criarVeiculoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            criarVeiculoButton.ForeColor = Color.White;
            criarVeiculoButton.Location = new Point(6, 679);
            criarVeiculoButton.Name = "criarVeiculoButton";
            criarVeiculoButton.Size = new Size(305, 49);
            criarVeiculoButton.TabIndex = 81;
            criarVeiculoButton.Text = "Cadastrar Veiculo";
            criarVeiculoButton.UseVisualStyleBackColor = false;
            criarVeiculoButton.Click += criarVeiculoButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.AutoSize = true;
            groupBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(826, 41);
            groupBox3.MaximumSize = new Size(431, 632);
            groupBox3.MinimumSize = new Size(431, 632);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(431, 632);
            groupBox3.TabIndex = 80;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalhes";
            // 
            // listarVeiculo_btn
            // 
            listarVeiculo_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listarVeiculo_btn.BackColor = Color.DimGray;
            listarVeiculo_btn.FlatStyle = FlatStyle.Flat;
            listarVeiculo_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listarVeiculo_btn.ForeColor = Color.White;
            listarVeiculo_btn.Location = new Point(1113, 6);
            listarVeiculo_btn.MaximumSize = new Size(144, 43);
            listarVeiculo_btn.Name = "listarVeiculo_btn";
            listarVeiculo_btn.Size = new Size(144, 29);
            listarVeiculo_btn.TabIndex = 77;
            listarVeiculo_btn.Text = "Listar Servicos";
            listarVeiculo_btn.UseVisualStyleBackColor = false;
            // 
            // searchVeiculo_btn
            // 
            searchVeiculo_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchVeiculo_btn.BackColor = Color.DimGray;
            searchVeiculo_btn.FlatStyle = FlatStyle.Flat;
            searchVeiculo_btn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchVeiculo_btn.ForeColor = Color.White;
            searchVeiculo_btn.Location = new Point(963, 7);
            searchVeiculo_btn.Name = "searchVeiculo_btn";
            searchVeiculo_btn.Size = new Size(144, 27);
            searchVeiculo_btn.TabIndex = 79;
            searchVeiculo_btn.Text = "Buscar";
            searchVeiculo_btn.UseVisualStyleBackColor = false;
            // 
            // searchVeiculo_tb
            // 
            searchVeiculo_tb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchVeiculo_tb.Location = new Point(687, 9);
            searchVeiculo_tb.Name = "searchVeiculo_tb";
            searchVeiculo_tb.Size = new Size(270, 22);
            searchVeiculo_tb.TabIndex = 78;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(allVeiculos_dgv);
            groupBox2.Location = new Point(3, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 632);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veiculos";
            // 
            // allVeiculos_dgv
            // 
            allVeiculos_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allVeiculos_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allVeiculos_dgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            allVeiculos_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            allVeiculos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allVeiculos_dgv.Dock = DockStyle.Fill;
            allVeiculos_dgv.EnableHeadersVisualStyles = false;
            allVeiculos_dgv.Location = new Point(3, 18);
            allVeiculos_dgv.Name = "allVeiculos_dgv";
            allVeiculos_dgv.ReadOnly = true;
            dataGridViewCellStyle11.Padding = new Padding(3);
            allVeiculos_dgv.RowsDefaultCellStyle = dataGridViewCellStyle11;
            allVeiculos_dgv.RowTemplate.Height = 25;
            allVeiculos_dgv.Size = new Size(814, 611);
            allVeiculos_dgv.TabIndex = 1;
            allVeiculos_dgv.DataBindingComplete += allVeiculos_dgv_DataBindingComplete;
            allVeiculos_dgv.RowHeaderMouseDoubleClick += allVeiculos_dgv_RowHeaderMouseDoubleClick;
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
            servicoTabPage.PerformLayout();
            servico2_gb.ResumeLayout(false);
            servico2_gb.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            servicoPeca_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicoPecas_dgv).EndInit();
            servico_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allServicos_dgv).EndInit();
            veiculoTabPage.ResumeLayout(false);
            veiculoTabPage.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allVeiculos_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button listarPecas_btn;
        private TabControl mainTabControl;
        private TabPage pecaTabPage;
        private TabPage clienteTabPage;
        private TextBox searchTextBox;
        private Button searchPeca_btn;
        private ComboBox searchPeca_combo;
        private GroupBox gb_pecasControl;
        private Button deletePeca_btn;
        private Button novaPeca_btn;
        private DataGridView allPecas_dgv;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private TabPage servicoTabPage;
        private TabPage veiculoTabPage;
        private GroupBox cliente_gb;
        private DataGridView allClientes_dgv;
        private Button venderPeca_btn;
        private Button editPeca_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button novoCliente_btn;
        private Label totalClientesLabel;
        private Button listarCliente_btn;
        private Button searchCliente_btn;
        private TextBox searchCliente_tb;
        private Button editCliente_btn;
        private Button deleteCliente_btn;
        private Button clienteServico_btn;
        private GroupBox servico_gb;
        private DataGridView allServicos_dgv;
        private Button listarServico_btn;
        private Button searchServico_btn;
        private TextBox searchServico_tb;
        private Button deleteServico_btn;
        private Button editarServico_btn;
        private Button finalServico_btn;
        private Button servicoSemCadastroButton;
        private GroupBox servico2_gb;
        private Label label1;
        private RichTextBox servicoDescricao_tb;
        private ComboBox searchServico_combo;
        private GroupBox servicoPeca_gb;
        private Button adicionarPecas_btn;
        private DateTimePicker dateEnd_picker;
        private Label label3;
        private Label label2;
        private DateTimePicker dateStart_picker;
        private DataGridView servicoPecas_dgv;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox servicoValorTotal_tb;
        private TextBox servicoPecaValor_tb;
        private TextBox servicoValor_tb;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Button listarVeiculo_btn;
        private Button searchVeiculo_btn;
        private TextBox searchVeiculo_tb;
        private GroupBox groupBox2;
        private DataGridView allVeiculos_dgv;
        private GroupBox groupBox3;
        private Button deleteVeiculo_btn;
        private Button editVeiculo_btn;
        private Button button3;
        private Button criarVeiculoButton;
        private ComboBox searchVeiculo_combo;
    }
}