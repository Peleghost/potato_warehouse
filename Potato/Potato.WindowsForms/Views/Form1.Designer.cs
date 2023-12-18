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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            getPecasButton = new Button();
            mainTabControl = new TabControl();
            pecaTabPage = new TabPage();
            labelTotalRecords = new Label();
            gb_pecasControl = new GroupBox();
            label1 = new Label();
            editQuantidadeLabel = new Label();
            editQuantidadeNumeric = new NumericUpDown();
            editPrecoTB = new TextBox();
            editCategoriaTB = new TextBox();
            editNomeTB = new TextBox();
            editNomeLabel = new Label();
            editPrecoLabel = new Label();
            editCategoriaLabel = new Label();
            editButton = new Button();
            venderButton = new Button();
            quantidadeLabel = new Label();
            pecaEstoqueNumeric = new NumericUpDown();
            selectedDataGridView = new DataGridView();
            deleteButton = new Button();
            precoTextBox = new TextBox();
            categoriaTextBox = new TextBox();
            addPecaButton = new Button();
            nomeTextBox = new TextBox();
            nomeLabel = new Label();
            precoLabel = new Label();
            categoriaLabel = new Label();
            gb_pecas = new GroupBox();
            allPecasDGV = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            searchComboBox = new ComboBox();
            clienteTabPage = new TabPage();
            cadastroCliente_gb = new GroupBox();
            cpf_label = new Label();
            clienteCpf_tb = new TextBox();
            clienteSobrenome_label = new Label();
            clienteSobrenome_tb = new TextBox();
            clienteNome_label = new Label();
            clienteNome_tb = new TextBox();
            cliente_gb = new GroupBox();
            allClientes_dgv = new DataGridView();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            clienteEndereco_label = new Label();
            clienteEndereco_tb = new TextBox();
            label2 = new Label();
            clienteEmail_tb = new TextBox();
            clienteTelefone_label = new Label();
            clienteTelefone_tb = new TextBox();
            cadastrarClienteButton = new Button();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecasControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editQuantidadeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedDataGridView).BeginInit();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPecasDGV).BeginInit();
            clienteTabPage.SuspendLayout();
            cadastroCliente_gb.SuspendLayout();
            cliente_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientes_dgv).BeginInit();
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
            // 
            // pecaTabPage
            // 
            pecaTabPage.Controls.Add(labelTotalRecords);
            pecaTabPage.Controls.Add(getPecasButton);
            pecaTabPage.Controls.Add(gb_pecasControl);
            pecaTabPage.Controls.Add(gb_pecas);
            pecaTabPage.Controls.Add(searchButton);
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
            gb_pecasControl.Controls.Add(label1);
            gb_pecasControl.Controls.Add(editQuantidadeLabel);
            gb_pecasControl.Controls.Add(editQuantidadeNumeric);
            gb_pecasControl.Controls.Add(editPrecoTB);
            gb_pecasControl.Controls.Add(editCategoriaTB);
            gb_pecasControl.Controls.Add(editNomeTB);
            gb_pecasControl.Controls.Add(editNomeLabel);
            gb_pecasControl.Controls.Add(editPrecoLabel);
            gb_pecasControl.Controls.Add(editCategoriaLabel);
            gb_pecasControl.Controls.Add(editButton);
            gb_pecasControl.Controls.Add(venderButton);
            gb_pecasControl.Controls.Add(quantidadeLabel);
            gb_pecasControl.Controls.Add(pecaEstoqueNumeric);
            gb_pecasControl.Controls.Add(selectedDataGridView);
            gb_pecasControl.Controls.Add(deleteButton);
            gb_pecasControl.Controls.Add(precoTextBox);
            gb_pecasControl.Controls.Add(categoriaTextBox);
            gb_pecasControl.Controls.Add(addPecaButton);
            gb_pecasControl.Controls.Add(nomeTextBox);
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
            editQuantidadeLabel.Location = new Point(7, 550);
            editQuantidadeLabel.Name = "editQuantidadeLabel";
            editQuantidadeLabel.Size = new Size(86, 14);
            editQuantidadeLabel.TabIndex = 74;
            editQuantidadeLabel.Text = "Quantidade:";
            // 
            // editQuantidadeNumeric
            // 
            editQuantidadeNumeric.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editQuantidadeNumeric.Enabled = false;
            editQuantidadeNumeric.Location = new Point(99, 548);
            editQuantidadeNumeric.Name = "editQuantidadeNumeric";
            editQuantidadeNumeric.Size = new Size(311, 22);
            editQuantidadeNumeric.TabIndex = 73;
            // 
            // editPrecoTB
            // 
            editPrecoTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPrecoTB.Enabled = false;
            editPrecoTB.Location = new Point(99, 490);
            editPrecoTB.Name = "editPrecoTB";
            editPrecoTB.Size = new Size(310, 22);
            editPrecoTB.TabIndex = 71;
            // 
            // editCategoriaTB
            // 
            editCategoriaTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoriaTB.Enabled = false;
            editCategoriaTB.Location = new Point(99, 519);
            editCategoriaTB.Name = "editCategoriaTB";
            editCategoriaTB.Size = new Size(310, 22);
            editCategoriaTB.TabIndex = 72;
            // 
            // editNomeTB
            // 
            editNomeTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editNomeTB.Enabled = false;
            editNomeTB.Location = new Point(99, 461);
            editNomeTB.Name = "editNomeTB";
            editNomeTB.Size = new Size(310, 22);
            editNomeTB.TabIndex = 70;
            // 
            // editNomeLabel
            // 
            editNomeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editNomeLabel.AutoSize = true;
            editNomeLabel.Location = new Point(9, 464);
            editNomeLabel.Name = "editNomeLabel";
            editNomeLabel.Size = new Size(48, 14);
            editNomeLabel.TabIndex = 67;
            editNomeLabel.Text = "Nome:";
            // 
            // editPrecoLabel
            // 
            editPrecoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editPrecoLabel.AutoSize = true;
            editPrecoLabel.Location = new Point(7, 493);
            editPrecoLabel.Name = "editPrecoLabel";
            editPrecoLabel.Size = new Size(47, 14);
            editPrecoLabel.TabIndex = 68;
            editPrecoLabel.Text = "Preco:";
            // 
            // editCategoriaLabel
            // 
            editCategoriaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoriaLabel.AutoSize = true;
            editCategoriaLabel.Location = new Point(7, 522);
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
            editButton.Location = new Point(10, 576);
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
            selectedDataGridView.Size = new Size(405, 162);
            selectedDataGridView.TabIndex = 61;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(10, 673);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(399, 49);
            deleteButton.TabIndex = 62;
            deleteButton.Text = "DELETAR";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // precoTextBox
            // 
            precoTextBox.Location = new Point(99, 62);
            precoTextBox.Name = "precoTextBox";
            precoTextBox.Size = new Size(310, 22);
            precoTextBox.TabIndex = 55;
            // 
            // categoriaTextBox
            // 
            categoriaTextBox.Location = new Point(99, 91);
            categoriaTextBox.Name = "categoriaTextBox";
            categoriaTextBox.Size = new Size(310, 22);
            categoriaTextBox.TabIndex = 56;
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
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(99, 33);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(310, 22);
            nomeTextBox.TabIndex = 54;
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
            gb_pecas.Controls.Add(allPecasDGV);
            gb_pecas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecas.Location = new Point(5, 41);
            gb_pecas.Name = "gb_pecas";
            gb_pecas.Size = new Size(831, 690);
            gb_pecas.TabIndex = 66;
            gb_pecas.TabStop = false;
            gb_pecas.Text = "Pecas";
            // 
            // allPecasDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            allPecasDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            allPecasDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allPecasDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allPecasDGV.BorderStyle = BorderStyle.Fixed3D;
            allPecasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPecasDGV.Dock = DockStyle.Fill;
            allPecasDGV.Location = new Point(3, 18);
            allPecasDGV.Name = "allPecasDGV";
            allPecasDGV.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            allPecasDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            allPecasDGV.RowTemplate.Height = 25;
            allPecasDGV.Size = new Size(825, 669);
            allPecasDGV.TabIndex = 1;
            allPecasDGV.DataBindingComplete += allDataGridView_DataBindingComplete;
            allPecasDGV.RowHeaderMouseDoubleClick += allPecasDGV_RowHeaderMouseDoubleClick;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.DimGray;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(537, 10);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(144, 27);
            searchButton.TabIndex = 3;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
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
            // cadastroCliente_gb
            // 
            cadastroCliente_gb.Controls.Add(cadastrarClienteButton);
            cadastroCliente_gb.Controls.Add(clienteTelefone_label);
            cadastroCliente_gb.Controls.Add(clienteTelefone_tb);
            cadastroCliente_gb.Controls.Add(label2);
            cadastroCliente_gb.Controls.Add(clienteEmail_tb);
            cadastroCliente_gb.Controls.Add(clienteEndereco_label);
            cadastroCliente_gb.Controls.Add(clienteEndereco_tb);
            cadastroCliente_gb.Controls.Add(cpf_label);
            cadastroCliente_gb.Controls.Add(clienteCpf_tb);
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
            // cpf_label
            // 
            cpf_label.AutoSize = true;
            cpf_label.Location = new Point(9, 92);
            cpf_label.Name = "cpf_label";
            cpf_label.Size = new Size(36, 14);
            cpf_label.TabIndex = 5;
            cpf_label.Text = "CPF:";
            // 
            // clienteCpf_tb
            // 
            clienteCpf_tb.Location = new Point(99, 89);
            clienteCpf_tb.Name = "clienteCpf_tb";
            clienteCpf_tb.Size = new Size(311, 22);
            clienteCpf_tb.TabIndex = 4;
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
            cliente_gb.Controls.Add(allClientes_dgv);
            cliente_gb.Location = new Point(3, 41);
            cliente_gb.Name = "cliente_gb";
            cliente_gb.Size = new Size(832, 690);
            cliente_gb.TabIndex = 0;
            cliente_gb.TabStop = false;
            cliente_gb.Text = "Clientes";
            // 
            // allClientes_dgv
            // 
            allClientes_dgv.BorderStyle = BorderStyle.Fixed3D;
            allClientes_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allClientes_dgv.Dock = DockStyle.Fill;
            allClientes_dgv.Location = new Point(3, 18);
            allClientes_dgv.Name = "allClientes_dgv";
            allClientes_dgv.RowTemplate.Height = 25;
            allClientes_dgv.Size = new Size(826, 669);
            allClientes_dgv.TabIndex = 0;
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
            // clienteTelefone_label
            // 
            clienteTelefone_label.AutoSize = true;
            clienteTelefone_label.Location = new Point(9, 176);
            clienteTelefone_label.Name = "clienteTelefone_label";
            clienteTelefone_label.Size = new Size(65, 14);
            clienteTelefone_label.TabIndex = 11;
            clienteTelefone_label.Text = "Telefone:";
            // 
            // clienteTelefone_tb
            // 
            clienteTelefone_tb.Location = new Point(99, 173);
            clienteTelefone_tb.Name = "clienteTelefone_tb";
            clienteTelefone_tb.Size = new Size(311, 22);
            clienteTelefone_tb.TabIndex = 10;
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
            ((System.ComponentModel.ISupportInitialize)allPecasDGV).EndInit();
            clienteTabPage.ResumeLayout(false);
            cadastroCliente_gb.ResumeLayout(false);
            cadastroCliente_gb.PerformLayout();
            cliente_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientes_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button getPecasButton;
        private TabControl mainTabControl;
        private TabPage pecaTabPage;
        private TabPage clienteTabPage;
        private TextBox searchTextBox;
        private Button searchButton;
        private ComboBox searchComboBox;
        private GroupBox gb_pecasControl;
        private DataGridView selectedDataGridView;
        private Button deleteButton;
        private TextBox precoTextBox;
        private TextBox categoriaTextBox;
        private Button addPecaButton;
        private TextBox nomeTextBox;
        private Label nomeLabel;
        private Label precoLabel;
        private Label categoriaLabel;
        private DataGridView allPecasDGV;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private Label quantidadeLabel;
        private NumericUpDown pecaEstoqueNumeric;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private GroupBox cliente_gb;
        private DataGridView allClientes_dgv;
        private Button venderButton;
        private Button editButton;
        private Label editQuantidadeLabel;
        private NumericUpDown editQuantidadeNumeric;
        private TextBox editPrecoTB;
        private TextBox editCategoriaTB;
        private TextBox editNomeTB;
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
        private TextBox clienteCpf_tb;
        private Label clienteEndereco_label;
        private TextBox clienteEndereco_tb;
        private Button cadastrarClienteButton;
        private Label clienteTelefone_label;
        private TextBox clienteTelefone_tb;
        private Label label2;
        private TextBox clienteEmail_tb;
    }
}