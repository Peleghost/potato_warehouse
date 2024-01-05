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
            deleteButton = new Button();
            editButton = new Button();
            venderButton = new Button();
            gb_pecasControl = new GroupBox();
            labelTotalRecords = new Label();
            gb_pecas = new GroupBox();
            allPecasDgv = new DataGridView();
            novaPecaButton = new Button();
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
            servicoTabPage = new TabPage();
            cadastroServico_gb = new GroupBox();
            criarServicoButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label13 = new Label();
            descricaoInput_tb = new RichTextBox();
            label12 = new Label();
            veiculoSemCadastro_tb = new TextBox();
            label11 = new Label();
            label10 = new Label();
            servicoVeiculoDGV = new DataGridView();
            servicoClienteDGV = new DataGridView();
            label9 = new Label();
            descricao_gb = new GroupBox();
            descricaoDisplay_tb = new RichTextBox();
            servico_gb = new GroupBox();
            allServicosDGV = new DataGridView();
            tabPage3 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecasControl.SuspendLayout();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPecasDgv).BeginInit();
            clienteTabPage.SuspendLayout();
            cadastroCliente_gb.SuspendLayout();
            cliente_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientesDgv).BeginInit();
            servicoTabPage.SuspendLayout();
            cadastroServico_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicoVeiculoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicoClienteDGV).BeginInit();
            descricao_gb.SuspendLayout();
            servico_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allServicosDGV).BeginInit();
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
            gb_pecasControl.Controls.Add(labelTotalRecords);
            gb_pecasControl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecasControl.Location = new Point(841, 6);
            gb_pecasControl.Name = "gb_pecasControl";
            gb_pecasControl.Size = new Size(416, 667);
            gb_pecasControl.TabIndex = 64;
            gb_pecasControl.TabStop = false;
            gb_pecasControl.Text = "Pecas";
            // 
            // labelTotalRecords
            // 
            labelTotalRecords.AutoSize = true;
            labelTotalRecords.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalRecords.Location = new Point(6, 53);
            labelTotalRecords.Name = "labelTotalRecords";
            labelTotalRecords.Size = new Size(96, 14);
            labelTotalRecords.TabIndex = 2;
            labelTotalRecords.Text = "Total Records:";
            // 
            // gb_pecas
            // 
            gb_pecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_pecas.AutoSize = true;
            gb_pecas.Controls.Add(allPecasDgv);
            gb_pecas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_pecas.Location = new Point(3, 41);
            gb_pecas.Name = "gb_pecas";
            gb_pecas.Size = new Size(833, 632);
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
            allPecasDgv.Size = new Size(827, 611);
            allPecasDgv.TabIndex = 1;
            allPecasDgv.DataBindingComplete += allPecasDgv_DataBindingComplete;
            allPecasDgv.RowHeaderMouseDoubleClick += allPecasDGV_RowHeaderMouseDoubleClick;
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
            dataGridViewCellStyle4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            // servicoTabPage
            // 
            servicoTabPage.Controls.Add(cadastroServico_gb);
            servicoTabPage.Controls.Add(descricao_gb);
            servicoTabPage.Controls.Add(servico_gb);
            servicoTabPage.Location = new Point(4, 23);
            servicoTabPage.Name = "servicoTabPage";
            servicoTabPage.Padding = new Padding(3);
            servicoTabPage.Size = new Size(1260, 734);
            servicoTabPage.TabIndex = 2;
            servicoTabPage.Text = "Servicos";
            servicoTabPage.UseVisualStyleBackColor = true;
            // 
            // cadastroServico_gb
            // 
            cadastroServico_gb.Controls.Add(criarServicoButton);
            cadastroServico_gb.Controls.Add(maskedTextBox1);
            cadastroServico_gb.Controls.Add(label13);
            cadastroServico_gb.Controls.Add(descricaoInput_tb);
            cadastroServico_gb.Controls.Add(label12);
            cadastroServico_gb.Controls.Add(veiculoSemCadastro_tb);
            cadastroServico_gb.Controls.Add(label11);
            cadastroServico_gb.Controls.Add(label10);
            cadastroServico_gb.Controls.Add(servicoVeiculoDGV);
            cadastroServico_gb.Controls.Add(servicoClienteDGV);
            cadastroServico_gb.Controls.Add(label9);
            cadastroServico_gb.Location = new Point(841, 3);
            cadastroServico_gb.Name = "cadastroServico_gb";
            cadastroServico_gb.Size = new Size(416, 728);
            cadastroServico_gb.TabIndex = 2;
            cadastroServico_gb.TabStop = false;
            cadastroServico_gb.Text = "Cadastrar Servico/Veiculo";
            // 
            // criarServicoButton
            // 
            criarServicoButton.BackColor = Color.SeaGreen;
            criarServicoButton.FlatStyle = FlatStyle.Flat;
            criarServicoButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            criarServicoButton.ForeColor = Color.White;
            criarServicoButton.Location = new Point(6, 545);
            criarServicoButton.Name = "criarServicoButton";
            criarServicoButton.Size = new Size(404, 49);
            criarServicoButton.TabIndex = 78;
            criarServicoButton.Text = "Criar Servico";
            criarServicoButton.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(84, 508);
            maskedTextBox1.Mask = "0000.00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(326, 22);
            maskedTextBox1.TabIndex = 77;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(6, 511);
            label13.Name = "label13";
            label13.Size = new Size(47, 14);
            label13.TabIndex = 8;
            label13.Text = "Preco:";
            // 
            // descricaoInput_tb
            // 
            descricaoInput_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            descricaoInput_tb.Location = new Point(84, 420);
            descricaoInput_tb.Name = "descricaoInput_tb";
            descricaoInput_tb.Size = new Size(326, 82);
            descricaoInput_tb.TabIndex = 7;
            descricaoInput_tb.Text = "";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(6, 423);
            label12.Name = "label12";
            label12.Size = new Size(72, 14);
            label12.TabIndex = 6;
            label12.Text = "Descricao:";
            // 
            // veiculoSemCadastro_tb
            // 
            veiculoSemCadastro_tb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            veiculoSemCadastro_tb.Location = new Point(160, 392);
            veiculoSemCadastro_tb.Name = "veiculoSemCadastro_tb";
            veiculoSemCadastro_tb.Size = new Size(250, 22);
            veiculoSemCadastro_tb.TabIndex = 5;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(6, 395);
            label11.Name = "label11";
            label11.Size = new Size(148, 14);
            label11.TabIndex = 4;
            label11.Text = "Veiculo Sem Cadastro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 163);
            label10.Name = "label10";
            label10.Size = new Size(55, 14);
            label10.TabIndex = 3;
            label10.Text = "Veiculo:";
            // 
            // servicoVeiculoDGV
            // 
            servicoVeiculoDGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoVeiculoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoVeiculoDGV.Location = new Point(6, 180);
            servicoVeiculoDGV.Name = "servicoVeiculoDGV";
            servicoVeiculoDGV.RowTemplate.Height = 25;
            servicoVeiculoDGV.Size = new Size(404, 86);
            servicoVeiculoDGV.TabIndex = 2;
            // 
            // servicoClienteDGV
            // 
            servicoClienteDGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            servicoClienteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicoClienteDGV.Location = new Point(6, 64);
            servicoClienteDGV.Name = "servicoClienteDGV";
            servicoClienteDGV.RowTemplate.Height = 25;
            servicoClienteDGV.Size = new Size(404, 84);
            servicoClienteDGV.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 47);
            label9.Name = "label9";
            label9.Size = new Size(56, 14);
            label9.TabIndex = 0;
            label9.Text = "Cliente:";
            // 
            // descricao_gb
            // 
            descricao_gb.Controls.Add(descricaoDisplay_tb);
            descricao_gb.Location = new Point(6, 513);
            descricao_gb.Name = "descricao_gb";
            descricao_gb.Size = new Size(829, 215);
            descricao_gb.TabIndex = 1;
            descricao_gb.TabStop = false;
            descricao_gb.Text = "Descricao";
            // 
            // descricaoDisplay_tb
            // 
            descricaoDisplay_tb.Dock = DockStyle.Fill;
            descricaoDisplay_tb.Location = new Point(3, 18);
            descricaoDisplay_tb.Name = "descricaoDisplay_tb";
            descricaoDisplay_tb.ReadOnly = true;
            descricaoDisplay_tb.Size = new Size(823, 194);
            descricaoDisplay_tb.TabIndex = 0;
            descricaoDisplay_tb.Text = "";
            // 
            // servico_gb
            // 
            servico_gb.Controls.Add(allServicosDGV);
            servico_gb.Location = new Point(3, 41);
            servico_gb.Name = "servico_gb";
            servico_gb.Size = new Size(832, 467);
            servico_gb.TabIndex = 0;
            servico_gb.TabStop = false;
            servico_gb.Text = "Servicos";
            // 
            // allServicosDGV
            // 
            allServicosDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allServicosDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allServicosDGV.BorderStyle = BorderStyle.Fixed3D;
            allServicosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allServicosDGV.Dock = DockStyle.Fill;
            allServicosDGV.Location = new Point(3, 18);
            allServicosDGV.Name = "allServicosDGV";
            allServicosDGV.RowTemplate.Height = 25;
            allServicosDGV.Size = new Size(826, 446);
            allServicosDGV.TabIndex = 0;
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
            gb_pecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allPecasDgv).EndInit();
            clienteTabPage.ResumeLayout(false);
            clienteTabPage.PerformLayout();
            cadastroCliente_gb.ResumeLayout(false);
            cadastroCliente_gb.PerformLayout();
            cliente_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientesDgv).EndInit();
            servicoTabPage.ResumeLayout(false);
            cadastroServico_gb.ResumeLayout(false);
            cadastroServico_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicoVeiculoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicoClienteDGV).EndInit();
            descricao_gb.ResumeLayout(false);
            servico_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allServicosDGV).EndInit();
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
        private DataGridView allPecasDgv;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private TabPage servicoTabPage;
        private TabPage tabPage3;
        private GroupBox cliente_gb;
        private DataGridView allClientesDgv;
        private Button venderButton;
        private Button editButton;
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
        private GroupBox servico_gb;
        private DataGridView allServicosDGV;
        private GroupBox descricao_gb;
        private RichTextBox descricaoDisplay_tb;
        private GroupBox cadastroServico_gb;
        private Label label9;
        private DataGridView servicoClienteDGV;
        private Label label10;
        private DataGridView servicoVeiculoDGV;
        private TextBox veiculoSemCadastro_tb;
        private Label label11;
        private Label label12;
        private RichTextBox descricaoInput_tb;
        private MaskedTextBox maskedTextBox1;
        private Label label13;
        private Button criarServicoButton;
    }
}