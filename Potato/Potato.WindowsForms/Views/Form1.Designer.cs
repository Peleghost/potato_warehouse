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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            getPecasButton = new Button();
            mainTabControl = new TabControl();
            pecaTabPage = new TabPage();
            labelTotalRecords = new Label();
            gb_pecasControl = new GroupBox();
            editPreco_masktb = new MaskedTextBox();
            preco_masktb = new MaskedTextBox();
            label1 = new Label();
            editQuantidadeLabel = new Label();
            editQuantidadeNumeric = new NumericUpDown();
            editCategoria_tb = new TextBox();
            editNome_tb = new TextBox();
            editNomeLabel = new Label();
            editPrecoLabel = new Label();
            editCategoriaLabel = new Label();
            editButton = new Button();
            venderButton = new Button();
            quantidadeLabel = new Label();
            pecaEstoqueNumeric = new NumericUpDown();
            selectedDataGridView = new DataGridView();
            deleteButton = new Button();
            categoria_tb = new TextBox();
            addPecaButton = new Button();
            nome_tb = new TextBox();
            nomeLabel = new Label();
            precoLabel = new Label();
            categoriaLabel = new Label();
            gb_pecas = new GroupBox();
            allPecasDgv = new DataGridView();
            searchPecaButton = new Button();
            searchTextBox = new TextBox();
            searchComboBox = new ComboBox();
            clienteTabPage = new TabPage();
            totalClientesLabel = new Label();
            listarClienteButton = new Button();
            searchClienteButton = new Button();
            searchCliente_tb = new TextBox();
            cadastroCliente_gb = new GroupBox();
            clienteServicoButton = new Button();
            editClienteButton = new Button();
            deleteClienteButton = new Button();
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
            clienteTelefone_masktb = new MaskedTextBox();
            clienteCpf_masktb = new MaskedTextBox();
            cadastrarClienteButton = new Button();
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
            cliente_gb = new GroupBox();
            allClientesDgv = new DataGridView();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecasControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editQuantidadeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedDataGridView).BeginInit();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPecasDgv).BeginInit();
            clienteTabPage.SuspendLayout();
            cadastroCliente_gb.SuspendLayout();
            cliente_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientesDgv).BeginInit();
            SuspendLayout();
            // 
            // getPecasButton
            // 
            getPecasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            getPecasButton.BackColor = Color.DimGray;
            getPecasButton.FlatStyle = FlatStyle.Flat;
            getPecasButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            getPecasButton.ForeColor = Color.White;
            getPecasButton.Location = new Point(687, 9);
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
            mainTabControl.Controls.Add(tabPage1);
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
            pecaTabPage.Controls.Add(getPecasButton);
            pecaTabPage.Controls.Add(gb_pecasControl);
            pecaTabPage.Controls.Add(gb_pecas);
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
            // gb_pecasControl
            // 
            gb_pecasControl.AutoSize = true;
            gb_pecasControl.Controls.Add(editPreco_masktb);
            gb_pecasControl.Controls.Add(preco_masktb);
            gb_pecasControl.Controls.Add(label1);
            gb_pecasControl.Controls.Add(editQuantidadeLabel);
            gb_pecasControl.Controls.Add(editQuantidadeNumeric);
            gb_pecasControl.Controls.Add(editCategoria_tb);
            gb_pecasControl.Controls.Add(editNome_tb);
            gb_pecasControl.Controls.Add(editNomeLabel);
            gb_pecasControl.Controls.Add(editPrecoLabel);
            gb_pecasControl.Controls.Add(editCategoriaLabel);
            gb_pecasControl.Controls.Add(editButton);
            gb_pecasControl.Controls.Add(venderButton);
            gb_pecasControl.Controls.Add(quantidadeLabel);
            gb_pecasControl.Controls.Add(pecaEstoqueNumeric);
            gb_pecasControl.Controls.Add(selectedDataGridView);
            gb_pecasControl.Controls.Add(deleteButton);
            gb_pecasControl.Controls.Add(categoria_tb);
            gb_pecasControl.Controls.Add(addPecaButton);
            gb_pecasControl.Controls.Add(nome_tb);
            gb_pecasControl.Controls.Add(nomeLabel);
            gb_pecasControl.Controls.Add(precoLabel);
            gb_pecasControl.Controls.Add(categoriaLabel);
            gb_pecasControl.Dock = DockStyle.Right;
            gb_pecasControl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecasControl.Location = new Point(841, 3);
            gb_pecasControl.Name = "gb_pecasControl";
            gb_pecasControl.Size = new Size(416, 728);
            gb_pecasControl.TabIndex = 64;
            gb_pecasControl.TabStop = false;
            gb_pecasControl.Text = "Pecas";
            // 
            // editPreco_masktb
            // 
            editPreco_masktb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPreco_masktb.Enabled = false;
            editPreco_masktb.Location = new Point(98, 490);
            editPreco_masktb.Mask = "0000.00";
            editPreco_masktb.Name = "editPreco_masktb";
            editPreco_masktb.Size = new Size(310, 22);
            editPreco_masktb.TabIndex = 77;
            // 
            // preco_masktb
            // 
            preco_masktb.Location = new Point(99, 62);
            preco_masktb.Mask = "0000.00";
            preco_masktb.Name = "preco_masktb";
            preco_masktb.Size = new Size(309, 22);
            preco_masktb.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 276);
            label1.Name = "label1";
            label1.Size = new Size(51, 14);
            label1.TabIndex = 75;
            label1.Text = "EDITAR";
            // 
            // editQuantidadeLabel
            // 
            editQuantidadeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editQuantidadeLabel.AutoSize = true;
            editQuantidadeLabel.Location = new Point(6, 550);
            editQuantidadeLabel.Name = "editQuantidadeLabel";
            editQuantidadeLabel.Size = new Size(86, 14);
            editQuantidadeLabel.TabIndex = 74;
            editQuantidadeLabel.Text = "Quantidade:";
            // 
            // editQuantidadeNumeric
            // 
            editQuantidadeNumeric.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editQuantidadeNumeric.Enabled = false;
            editQuantidadeNumeric.Location = new Point(98, 548);
            editQuantidadeNumeric.Name = "editQuantidadeNumeric";
            editQuantidadeNumeric.Size = new Size(311, 22);
            editQuantidadeNumeric.TabIndex = 73;
            // 
            // editCategoria_tb
            // 
            editCategoria_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoria_tb.Enabled = false;
            editCategoria_tb.Location = new Point(98, 519);
            editCategoria_tb.Name = "editCategoria_tb";
            editCategoria_tb.Size = new Size(310, 22);
            editCategoria_tb.TabIndex = 72;
            // 
            // editNome_tb
            // 
            editNome_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editNome_tb.Enabled = false;
            editNome_tb.Location = new Point(98, 461);
            editNome_tb.Name = "editNome_tb";
            editNome_tb.Size = new Size(310, 22);
            editNome_tb.TabIndex = 70;
            // 
            // editNomeLabel
            // 
            editNomeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editNomeLabel.AutoSize = true;
            editNomeLabel.Location = new Point(8, 464);
            editNomeLabel.Name = "editNomeLabel";
            editNomeLabel.Size = new Size(48, 14);
            editNomeLabel.TabIndex = 67;
            editNomeLabel.Text = "Nome:";
            // 
            // editPrecoLabel
            // 
            editPrecoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPrecoLabel.AutoSize = true;
            editPrecoLabel.Location = new Point(6, 493);
            editPrecoLabel.Name = "editPrecoLabel";
            editPrecoLabel.Size = new Size(47, 14);
            editPrecoLabel.TabIndex = 68;
            editPrecoLabel.Text = "Preco:";
            // 
            // editCategoriaLabel
            // 
            editCategoriaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoriaLabel.AutoSize = true;
            editCategoriaLabel.Location = new Point(6, 522);
            editCategoriaLabel.Name = "editCategoriaLabel";
            editCategoriaLabel.Size = new Size(74, 14);
            editCategoriaLabel.TabIndex = 69;
            editCategoriaLabel.Text = "Categoria:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.BackColor = Color.SandyBrown;
            editButton.Enabled = false;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(9, 576);
            editButton.Name = "editButton";
            editButton.Size = new Size(399, 49);
            editButton.TabIndex = 66;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // venderButton
            // 
            venderButton.BackColor = Color.LightSeaGreen;
            venderButton.Enabled = false;
            venderButton.FlatStyle = FlatStyle.Flat;
            venderButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            venderButton.ForeColor = Color.White;
            venderButton.Location = new Point(10, 204);
            venderButton.Name = "venderButton";
            venderButton.Size = new Size(399, 49);
            venderButton.TabIndex = 65;
            venderButton.Text = "Vender";
            venderButton.UseVisualStyleBackColor = false;
            venderButton.Click += venderButton_Click;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(7, 122);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(86, 14);
            quantidadeLabel.TabIndex = 64;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // pecaEstoqueNumeric
            // 
            pecaEstoqueNumeric.Location = new Point(99, 120);
            pecaEstoqueNumeric.Name = "pecaEstoqueNumeric";
            pecaEstoqueNumeric.Size = new Size(311, 22);
            pecaEstoqueNumeric.TabIndex = 63;
            // 
            // selectedDataGridView
            // 
            selectedDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedDataGridView.Location = new Point(4, 293);
            selectedDataGridView.Name = "selectedDataGridView";
            selectedDataGridView.RowTemplate.Height = 25;
            selectedDataGridView.Size = new Size(404, 162);
            selectedDataGridView.TabIndex = 61;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(9, 673);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(399, 49);
            deleteButton.TabIndex = 62;
            deleteButton.Text = "DELETAR";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // categoria_tb
            // 
            categoria_tb.Location = new Point(99, 91);
            categoria_tb.Name = "categoria_tb";
            categoria_tb.Size = new Size(310, 22);
            categoria_tb.TabIndex = 56;
            // 
            // addPecaButton
            // 
            addPecaButton.BackColor = Color.SeaGreen;
            addPecaButton.FlatStyle = FlatStyle.Flat;
            addPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addPecaButton.ForeColor = Color.White;
            addPecaButton.Location = new Point(10, 149);
            addPecaButton.Name = "addPecaButton";
            addPecaButton.Size = new Size(399, 49);
            addPecaButton.TabIndex = 48;
            addPecaButton.Text = "Adicionar ao Banco de Dados";
            addPecaButton.UseVisualStyleBackColor = false;
            addPecaButton.Click += addPecaButton_Click;
            // 
            // nome_tb
            // 
            nome_tb.Location = new Point(99, 33);
            nome_tb.Name = "nome_tb";
            nome_tb.Size = new Size(310, 22);
            nome_tb.TabIndex = 54;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(9, 36);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(48, 14);
            nomeLabel.TabIndex = 50;
            nomeLabel.Text = "Nome:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new Point(7, 65);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new Size(47, 14);
            precoLabel.TabIndex = 51;
            precoLabel.Text = "Preco:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(7, 94);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(74, 14);
            categoriaLabel.TabIndex = 52;
            categoriaLabel.Text = "Categoria:";
            // 
            // gb_pecas
            // 
            gb_pecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_pecas.AutoSize = true;
            gb_pecas.Controls.Add(allPecasDgv);
            gb_pecas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecas.Location = new Point(5, 41);
            gb_pecas.Name = "gb_pecas";
            gb_pecas.Size = new Size(831, 690);
            gb_pecas.TabIndex = 66;
            gb_pecas.TabStop = false;
            gb_pecas.Text = "Pecas";
            // 
            // allPecasDgv
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            allPecasDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            allPecasDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allPecasDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allPecasDgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            allPecasDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            allPecasDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPecasDgv.Dock = DockStyle.Fill;
            allPecasDgv.EnableHeadersVisualStyles = false;
            allPecasDgv.Location = new Point(3, 18);
            allPecasDgv.Name = "allPecasDgv";
            allPecasDgv.ReadOnly = true;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            allPecasDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            allPecasDgv.RowTemplate.Height = 25;
            allPecasDgv.Size = new Size(825, 669);
            allPecasDgv.TabIndex = 1;
            allPecasDgv.DataBindingComplete += allPecasDgv_DataBindingComplete;
            allPecasDgv.RowHeaderMouseDoubleClick += allPecasDGV_RowHeaderMouseDoubleClick;
            // 
            // searchPecaButton
            // 
            searchPecaButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPecaButton.BackColor = Color.DimGray;
            searchPecaButton.FlatStyle = FlatStyle.Flat;
            searchPecaButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchPecaButton.ForeColor = Color.White;
            searchPecaButton.Location = new Point(537, 10);
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
            searchTextBox.Location = new Point(261, 12);
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
            searchComboBox.Location = new Point(134, 12);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(121, 22);
            searchComboBox.TabIndex = 4;
            searchComboBox.Text = "Buscar Por...";
            // 
            // clienteTabPage
            // 
            clienteTabPage.Controls.Add(totalClientesLabel);
            clienteTabPage.Controls.Add(listarClienteButton);
            clienteTabPage.Controls.Add(searchClienteButton);
            clienteTabPage.Controls.Add(searchCliente_tb);
            clienteTabPage.Controls.Add(cadastroCliente_gb);
            clienteTabPage.Controls.Add(cliente_gb);
            clienteTabPage.Location = new Point(4, 23);
            clienteTabPage.Name = "clienteTabPage";
            clienteTabPage.Padding = new Padding(3);
            clienteTabPage.Size = new Size(1260, 734);
            clienteTabPage.TabIndex = 1;
            clienteTabPage.Text = "Clientes";
            clienteTabPage.UseVisualStyleBackColor = true;
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
            listarClienteButton.Location = new Point(687, 9);
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
            searchClienteButton.Location = new Point(537, 10);
            searchClienteButton.Name = "searchClienteButton";
            searchClienteButton.Size = new Size(144, 27);
            searchClienteButton.TabIndex = 7;
            searchClienteButton.Text = "Buscar";
            searchClienteButton.UseVisualStyleBackColor = false;
            searchClienteButton.Click += buscarClienteButton_Click;
            // 
            // searchCliente_tb
            // 
            searchCliente_tb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchCliente_tb.Location = new Point(261, 12);
            searchCliente_tb.Name = "searchCliente_tb";
            searchCliente_tb.Size = new Size(270, 22);
            searchCliente_tb.TabIndex = 6;
            // 
            // cadastroCliente_gb
            // 
            cadastroCliente_gb.Controls.Add(clienteServicoButton);
            cadastroCliente_gb.Controls.Add(editClienteButton);
            cadastroCliente_gb.Controls.Add(deleteClienteButton);
            cadastroCliente_gb.Controls.Add(editClienteTelefone_tb);
            cadastroCliente_gb.Controls.Add(editClienteCpf_tb);
            cadastroCliente_gb.Controls.Add(label3);
            cadastroCliente_gb.Controls.Add(label4);
            cadastroCliente_gb.Controls.Add(editClienteEmail_tb);
            cadastroCliente_gb.Controls.Add(label5);
            cadastroCliente_gb.Controls.Add(editClienteEndereco_tb);
            cadastroCliente_gb.Controls.Add(label6);
            cadastroCliente_gb.Controls.Add(label7);
            cadastroCliente_gb.Controls.Add(editClienteSobrenome_tb);
            cadastroCliente_gb.Controls.Add(label8);
            cadastroCliente_gb.Controls.Add(editClienteNome_tb);
            cadastroCliente_gb.Controls.Add(clienteTelefone_masktb);
            cadastroCliente_gb.Controls.Add(clienteCpf_masktb);
            cadastroCliente_gb.Controls.Add(cadastrarClienteButton);
            cadastroCliente_gb.Controls.Add(clienteTelefone_label);
            cadastroCliente_gb.Controls.Add(label2);
            cadastroCliente_gb.Controls.Add(clienteEmail_tb);
            cadastroCliente_gb.Controls.Add(clienteEndereco_label);
            cadastroCliente_gb.Controls.Add(clienteEndereco_tb);
            cadastroCliente_gb.Controls.Add(cpf_label);
            cadastroCliente_gb.Controls.Add(clienteSobrenome_label);
            cadastroCliente_gb.Controls.Add(clienteSobrenome_tb);
            cadastroCliente_gb.Controls.Add(clienteNome_label);
            cadastroCliente_gb.Controls.Add(clienteNome_tb);
            cadastroCliente_gb.Dock = DockStyle.Right;
            cadastroCliente_gb.Location = new Point(841, 3);
            cadastroCliente_gb.Name = "cadastroCliente_gb";
            cadastroCliente_gb.Size = new Size(416, 728);
            cadastroCliente_gb.TabIndex = 1;
            cadastroCliente_gb.TabStop = false;
            cadastroCliente_gb.Text = "Cadastro";
            // 
            // clienteServicoButton
            // 
            clienteServicoButton.BackColor = Color.LightSeaGreen;
            clienteServicoButton.Enabled = false;
            clienteServicoButton.FlatStyle = FlatStyle.Flat;
            clienteServicoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clienteServicoButton.ForeColor = Color.White;
            clienteServicoButton.Location = new Point(9, 256);
            clienteServicoButton.Name = "clienteServicoButton";
            clienteServicoButton.Size = new Size(401, 49);
            clienteServicoButton.TabIndex = 69;
            clienteServicoButton.Text = "Criar Servico";
            clienteServicoButton.UseVisualStyleBackColor = false;
            // 
            // editClienteButton
            // 
            editClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editClienteButton.BackColor = Color.SandyBrown;
            editClienteButton.Enabled = false;
            editClienteButton.FlatStyle = FlatStyle.Flat;
            editClienteButton.ForeColor = Color.White;
            editClienteButton.Location = new Point(9, 576);
            editClienteButton.Name = "editClienteButton";
            editClienteButton.Size = new Size(401, 49);
            editClienteButton.TabIndex = 68;
            editClienteButton.Text = "Editar";
            editClienteButton.UseVisualStyleBackColor = false;
            editClienteButton.Click += editClienteButton_Click;
            // 
            // deleteClienteButton
            // 
            deleteClienteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteClienteButton.BackColor = Color.IndianRed;
            deleteClienteButton.Enabled = false;
            deleteClienteButton.FlatStyle = FlatStyle.Flat;
            deleteClienteButton.ForeColor = Color.White;
            deleteClienteButton.Location = new Point(9, 673);
            deleteClienteButton.Name = "deleteClienteButton";
            deleteClienteButton.Size = new Size(401, 49);
            deleteClienteButton.TabIndex = 67;
            deleteClienteButton.Text = "DELETAR";
            deleteClienteButton.UseVisualStyleBackColor = false;
            deleteClienteButton.Click += deleteClienteButton_Click;
            // 
            // editClienteTelefone_tb
            // 
            editClienteTelefone_tb.Enabled = false;
            editClienteTelefone_tb.Location = new Point(99, 548);
            editClienteTelefone_tb.Mask = "(00) 00000-0000";
            editClienteTelefone_tb.Name = "editClienteTelefone_tb";
            editClienteTelefone_tb.Size = new Size(311, 22);
            editClienteTelefone_tb.TabIndex = 63;
            // 
            // editClienteCpf_tb
            // 
            editClienteCpf_tb.Enabled = false;
            editClienteCpf_tb.Location = new Point(99, 464);
            editClienteCpf_tb.Mask = "000.000.000-00";
            editClienteCpf_tb.Name = "editClienteCpf_tb";
            editClienteCpf_tb.Size = new Size(311, 22);
            editClienteCpf_tb.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 551);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 61;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 523);
            label4.Name = "label4";
            label4.Size = new Size(45, 14);
            label4.TabIndex = 60;
            label4.Text = "Email:";
            // 
            // editClienteEmail_tb
            // 
            editClienteEmail_tb.Enabled = false;
            editClienteEmail_tb.Location = new Point(99, 520);
            editClienteEmail_tb.Name = "editClienteEmail_tb";
            editClienteEmail_tb.Size = new Size(311, 22);
            editClienteEmail_tb.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 495);
            label5.Name = "label5";
            label5.Size = new Size(71, 14);
            label5.TabIndex = 58;
            label5.Text = "Endereco:";
            // 
            // editClienteEndereco_tb
            // 
            editClienteEndereco_tb.Enabled = false;
            editClienteEndereco_tb.Location = new Point(99, 492);
            editClienteEndereco_tb.Name = "editClienteEndereco_tb";
            editClienteEndereco_tb.Size = new Size(311, 22);
            editClienteEndereco_tb.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 467);
            label6.Name = "label6";
            label6.Size = new Size(36, 14);
            label6.TabIndex = 56;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 439);
            label7.Name = "label7";
            label7.Size = new Size(84, 14);
            label7.TabIndex = 55;
            label7.Text = "Sobrenome:";
            // 
            // editClienteSobrenome_tb
            // 
            editClienteSobrenome_tb.Enabled = false;
            editClienteSobrenome_tb.Location = new Point(99, 436);
            editClienteSobrenome_tb.Name = "editClienteSobrenome_tb";
            editClienteSobrenome_tb.Size = new Size(311, 22);
            editClienteSobrenome_tb.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 411);
            label8.Name = "label8";
            label8.Size = new Size(48, 14);
            label8.TabIndex = 53;
            label8.Text = "Nome:";
            // 
            // editClienteNome_tb
            // 
            editClienteNome_tb.Enabled = false;
            editClienteNome_tb.Location = new Point(99, 408);
            editClienteNome_tb.Name = "editClienteNome_tb";
            editClienteNome_tb.Size = new Size(311, 22);
            editClienteNome_tb.TabIndex = 52;
            // 
            // clienteTelefone_masktb
            // 
            clienteTelefone_masktb.Location = new Point(99, 173);
            clienteTelefone_masktb.Mask = "(00) 00000-0000";
            clienteTelefone_masktb.Name = "clienteTelefone_masktb";
            clienteTelefone_masktb.Size = new Size(311, 22);
            clienteTelefone_masktb.TabIndex = 51;
            // 
            // clienteCpf_masktb
            // 
            clienteCpf_masktb.Location = new Point(99, 89);
            clienteCpf_masktb.Mask = "000.000.000-00";
            clienteCpf_masktb.Name = "clienteCpf_masktb";
            clienteCpf_masktb.Size = new Size(311, 22);
            clienteCpf_masktb.TabIndex = 50;
            // 
            // cadastrarClienteButton
            // 
            cadastrarClienteButton.BackColor = Color.SeaGreen;
            cadastrarClienteButton.FlatStyle = FlatStyle.Flat;
            cadastrarClienteButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarClienteButton.ForeColor = Color.White;
            cadastrarClienteButton.Location = new Point(9, 201);
            cadastrarClienteButton.Name = "cadastrarClienteButton";
            cadastrarClienteButton.Size = new Size(401, 49);
            cadastrarClienteButton.TabIndex = 49;
            cadastrarClienteButton.Text = "Cadastrar";
            cadastrarClienteButton.UseVisualStyleBackColor = false;
            cadastrarClienteButton.Click += cadastrarClienteButton_Click;
            // 
            // clienteTelefone_label
            // 
            clienteTelefone_label.AutoSize = true;
            clienteTelefone_label.Location = new Point(9, 176);
            clienteTelefone_label.Name = "clienteTelefone_label";
            clienteTelefone_label.Size = new Size(65, 14);
            clienteTelefone_label.TabIndex = 11;
            clienteTelefone_label.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 148);
            label2.Name = "label2";
            label2.Size = new Size(45, 14);
            label2.TabIndex = 9;
            label2.Text = "Email:";
            // 
            // clienteEmail_tb
            // 
            clienteEmail_tb.Location = new Point(99, 145);
            clienteEmail_tb.Name = "clienteEmail_tb";
            clienteEmail_tb.Size = new Size(311, 22);
            clienteEmail_tb.TabIndex = 8;
            // 
            // clienteEndereco_label
            // 
            clienteEndereco_label.AutoSize = true;
            clienteEndereco_label.Location = new Point(9, 120);
            clienteEndereco_label.Name = "clienteEndereco_label";
            clienteEndereco_label.Size = new Size(71, 14);
            clienteEndereco_label.TabIndex = 7;
            clienteEndereco_label.Text = "Endereco:";
            // 
            // clienteEndereco_tb
            // 
            clienteEndereco_tb.Location = new Point(99, 117);
            clienteEndereco_tb.Name = "clienteEndereco_tb";
            clienteEndereco_tb.Size = new Size(311, 22);
            clienteEndereco_tb.TabIndex = 6;
            // 
            // cpf_label
            // 
            cpf_label.AutoSize = true;
            cpf_label.Location = new Point(9, 92);
            cpf_label.Name = "cpf_label";
            cpf_label.Size = new Size(36, 14);
            cpf_label.TabIndex = 5;
            cpf_label.Text = "CPF:";
            // 
            // clienteSobrenome_label
            // 
            clienteSobrenome_label.AutoSize = true;
            clienteSobrenome_label.Location = new Point(9, 64);
            clienteSobrenome_label.Name = "clienteSobrenome_label";
            clienteSobrenome_label.Size = new Size(84, 14);
            clienteSobrenome_label.TabIndex = 3;
            clienteSobrenome_label.Text = "Sobrenome:";
            // 
            // clienteSobrenome_tb
            // 
            clienteSobrenome_tb.Location = new Point(99, 61);
            clienteSobrenome_tb.Name = "clienteSobrenome_tb";
            clienteSobrenome_tb.Size = new Size(311, 22);
            clienteSobrenome_tb.TabIndex = 2;
            // 
            // clienteNome_label
            // 
            clienteNome_label.AutoSize = true;
            clienteNome_label.Location = new Point(9, 36);
            clienteNome_label.Name = "clienteNome_label";
            clienteNome_label.Size = new Size(48, 14);
            clienteNome_label.TabIndex = 1;
            clienteNome_label.Text = "Nome:";
            // 
            // clienteNome_tb
            // 
            clienteNome_tb.Location = new Point(99, 33);
            clienteNome_tb.Name = "clienteNome_tb";
            clienteNome_tb.Size = new Size(311, 22);
            clienteNome_tb.TabIndex = 0;
            // 
            // cliente_gb
            // 
            cliente_gb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cliente_gb.Controls.Add(allClientesDgv);
            cliente_gb.Location = new Point(3, 41);
            cliente_gb.Name = "cliente_gb";
            cliente_gb.Size = new Size(832, 690);
            cliente_gb.TabIndex = 0;
            cliente_gb.TabStop = false;
            cliente_gb.Text = "Clientes";
            // 
            // allClientesDgv
            // 
            allClientesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allClientesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allClientesDgv.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            allClientesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            allClientesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allClientesDgv.Dock = DockStyle.Fill;
            allClientesDgv.EnableHeadersVisualStyles = false;
            allClientesDgv.Location = new Point(3, 18);
            allClientesDgv.Name = "allClientesDgv";
            allClientesDgv.ReadOnly = true;
            dataGridViewCellStyle5.Padding = new Padding(3);
            allClientesDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            allClientesDgv.RowTemplate.Height = 25;
            allClientesDgv.Size = new Size(826, 669);
            allClientesDgv.TabIndex = 0;
            allClientesDgv.DataBindingComplete += allClientes_dgv_DataBindingComplete;
            allClientesDgv.RowHeaderMouseDoubleClick += allClientesDgv_RowHeaderMouseDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1260, 734);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
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
            gb_pecasControl.ResumeLayout(false);
            gb_pecasControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editQuantidadeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedDataGridView).EndInit();
            gb_pecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allPecasDgv).EndInit();
            clienteTabPage.ResumeLayout(false);
            clienteTabPage.PerformLayout();
            cadastroCliente_gb.ResumeLayout(false);
            cadastroCliente_gb.PerformLayout();
            cliente_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientesDgv).EndInit();
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
        private DataGridView selectedDataGridView;
        private Button deleteButton;
        private TextBox categoria_tb;
        private Button addPecaButton;
        private TextBox nome_tb;
        private Label nomeLabel;
        private Label precoLabel;
        private Label categoriaLabel;
        private DataGridView allPecasDgv;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private Label quantidadeLabel;
        private NumericUpDown pecaEstoqueNumeric;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private GroupBox cliente_gb;
        private DataGridView allClientesDgv;
        private Button venderButton;
        private Button editButton;
        private Label editQuantidadeLabel;
        private NumericUpDown editQuantidadeNumeric;
        private TextBox editCategoria_tb;
        private TextBox editNome_tb;
        private Label editNomeLabel;
        private Label editPrecoLabel;
        private Label editCategoriaLabel;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox cadastroCliente_gb;
        private Label clienteSobrenome_label;
        private TextBox clienteSobrenome_tb;
        private Label clienteNome_label;
        private TextBox clienteNome_tb;
        private Label cpf_label;
        private Label clienteEndereco_label;
        private TextBox clienteEndereco_tb;
        private Button cadastrarClienteButton;
        private Label clienteTelefone_label;
        private Label label2;
        private TextBox clienteEmail_tb;
        private MaskedTextBox clienteCpf_masktb;
        private MaskedTextBox clienteTelefone_masktb;
        private MaskedTextBox preco_masktb;
        private MaskedTextBox editPreco_masktb;
        private Label totalClientesLabel;
        private Button listarClienteButton;
        private Button searchClienteButton;
        private TextBox searchCliente_tb;
        private Button editClienteButton;
        private Button deleteClienteButton;
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
        private Button clienteServicoButton;
    }
}