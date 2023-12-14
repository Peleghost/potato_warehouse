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
            getPecasButton = new Button();
            mainTabControl = new TabControl();
            pecaTabPage = new TabPage();
            labelTotalRecords = new Label();
            gb_pecasControl = new GroupBox();
            quantidadeLabel = new Label();
            pecaEstoqueNumeric = new NumericUpDown();
            selectedDataGridView = new DataGridView();
            deleteButton = new Button();
            precoTextBox = new TextBox();
            categoriaTextBox = new TextBox();
            selectedItem = new Label();
            addPeca = new Button();
            nomeTextBox = new TextBox();
            nomeLabel = new Label();
            precoLabel = new Label();
            categoriaLabel = new Label();
            gb_pecas = new GroupBox();
            allDataGridView = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            searchComboBox = new ComboBox();
            tabPage2 = new TabPage();
            mainTabControl.SuspendLayout();
            pecaTabPage.SuspendLayout();
            gb_pecasControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedDataGridView).BeginInit();
            gb_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allDataGridView).BeginInit();
            SuspendLayout();
            // 
            // getPecasButton
            // 
            getPecasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            getPecasButton.Location = new Point(687, 8);
            getPecasButton.MaximumSize = new Size(144, 43);
            getPecasButton.Name = "getPecasButton";
            getPecasButton.Size = new Size(144, 29);
            getPecasButton.TabIndex = 0;
            getPecasButton.Text = "Listar Todas Pecas";
            getPecasButton.UseVisualStyleBackColor = true;
            getPecasButton.Click += getPecasButton_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(pecaTabPage);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Dock = DockStyle.Fill;
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
            pecaTabPage.Location = new Point(4, 24);
            pecaTabPage.Name = "pecaTabPage";
            pecaTabPage.Padding = new Padding(3);
            pecaTabPage.Size = new Size(1260, 733);
            pecaTabPage.TabIndex = 0;
            pecaTabPage.Text = "Pecas";
            pecaTabPage.UseVisualStyleBackColor = true;
            // 
            // labelTotalRecords
            // 
            labelTotalRecords.AutoSize = true;
            labelTotalRecords.Location = new Point(8, 15);
            labelTotalRecords.Name = "labelTotalRecords";
            labelTotalRecords.Size = new Size(80, 15);
            labelTotalRecords.TabIndex = 2;
            labelTotalRecords.Text = "Total Records:";
            // 
            // gb_pecasControl
            // 
            gb_pecasControl.AutoSize = true;
            gb_pecasControl.Controls.Add(quantidadeLabel);
            gb_pecasControl.Controls.Add(pecaEstoqueNumeric);
            gb_pecasControl.Controls.Add(selectedDataGridView);
            gb_pecasControl.Controls.Add(deleteButton);
            gb_pecasControl.Controls.Add(precoTextBox);
            gb_pecasControl.Controls.Add(categoriaTextBox);
            gb_pecasControl.Controls.Add(selectedItem);
            gb_pecasControl.Controls.Add(addPeca);
            gb_pecasControl.Controls.Add(nomeTextBox);
            gb_pecasControl.Controls.Add(nomeLabel);
            gb_pecasControl.Controls.Add(precoLabel);
            gb_pecasControl.Controls.Add(categoriaLabel);
            gb_pecasControl.Dock = DockStyle.Right;
            gb_pecasControl.Location = new Point(841, 3);
            gb_pecasControl.Name = "gb_pecasControl";
            gb_pecasControl.Size = new Size(416, 727);
            gb_pecasControl.TabIndex = 64;
            gb_pecasControl.TabStop = false;
            gb_pecasControl.Text = "Pecas";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(7, 122);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(72, 15);
            quantidadeLabel.TabIndex = 64;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // pecaEstoqueNumeric
            // 
            pecaEstoqueNumeric.Location = new Point(89, 120);
            pecaEstoqueNumeric.Name = "pecaEstoqueNumeric";
            pecaEstoqueNumeric.Size = new Size(321, 23);
            pecaEstoqueNumeric.TabIndex = 63;
            // 
            // selectedDataGridView
            // 
            selectedDataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedDataGridView.Location = new Point(7, 562);
            selectedDataGridView.Name = "selectedDataGridView";
            selectedDataGridView.RowTemplate.Height = 25;
            selectedDataGridView.Size = new Size(403, 162);
            selectedDataGridView.TabIndex = 61;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(157, 507);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(252, 49);
            deleteButton.TabIndex = 62;
            deleteButton.Text = "Deletar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // precoTextBox
            // 
            precoTextBox.Location = new Point(89, 62);
            precoTextBox.Name = "precoTextBox";
            precoTextBox.Size = new Size(320, 23);
            precoTextBox.TabIndex = 55;
            // 
            // categoriaTextBox
            // 
            categoriaTextBox.Location = new Point(89, 91);
            categoriaTextBox.Name = "categoriaTextBox";
            categoriaTextBox.Size = new Size(320, 23);
            categoriaTextBox.TabIndex = 56;
            // 
            // selectedItem
            // 
            selectedItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectedItem.Location = new Point(7, 544);
            selectedItem.Name = "selectedItem";
            selectedItem.Size = new Size(76, 15);
            selectedItem.TabIndex = 60;
            selectedItem.Text = "Selecionado:";
            // 
            // addPeca
            // 
            addPeca.Location = new Point(9, 149);
            addPeca.Name = "addPeca";
            addPeca.Size = new Size(400, 49);
            addPeca.TabIndex = 48;
            addPeca.Text = "Adicionar ao Banco de Dados";
            addPeca.UseVisualStyleBackColor = true;
            addPeca.Click += addPecasButton_Click;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(89, 33);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(320, 23);
            nomeTextBox.TabIndex = 54;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(9, 36);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(43, 15);
            nomeLabel.TabIndex = 50;
            nomeLabel.Text = "Nome:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new Point(7, 65);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new Size(40, 15);
            precoLabel.TabIndex = 51;
            precoLabel.Text = "Preco:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(7, 94);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(61, 15);
            categoriaLabel.TabIndex = 52;
            categoriaLabel.Text = "Categoria:";
            // 
            // gb_pecas
            // 
            gb_pecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_pecas.AutoSize = true;
            gb_pecas.Controls.Add(allDataGridView);
            gb_pecas.Location = new Point(5, 41);
            gb_pecas.Name = "gb_pecas";
            gb_pecas.Size = new Size(831, 689);
            gb_pecas.TabIndex = 66;
            gb_pecas.TabStop = false;
            gb_pecas.Text = "Pecas";
            // 
            // allDataGridView
            // 
            allDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allDataGridView.Dock = DockStyle.Fill;
            allDataGridView.Location = new Point(3, 19);
            allDataGridView.Name = "allDataGridView";
            allDataGridView.ReadOnly = true;
            allDataGridView.RowTemplate.Height = 25;
            allDataGridView.Size = new Size(825, 667);
            allDataGridView.TabIndex = 1;
            allDataGridView.DataBindingComplete += allDataGridView_DataBindingComplete;
            allDataGridView.RowHeaderMouseDoubleClick += allDataGridView_RowHeaderMouseDoubleClick;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.Location = new Point(537, 8);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(144, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(261, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 23);
            searchTextBox.TabIndex = 2;
            // 
            // searchComboBox
            // 
            searchComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "ID", "Nome", "Categoria" });
            searchComboBox.Location = new Point(134, 12);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(121, 23);
            searchComboBox.TabIndex = 4;
            searchComboBox.Text = "Buscar Por...";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1260, 733);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1268, 761);
            Controls.Add(mainTabControl);
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
            ((System.ComponentModel.ISupportInitialize)pecaEstoqueNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedDataGridView).EndInit();
            gb_pecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button getPecasButton;
        private TabControl mainTabControl;
        private TabPage pecaTabPage;
        private TabPage tabPage2;
        private TextBox searchTextBox;
        private Button searchButton;
        private ComboBox searchComboBox;
        private GroupBox gb_pecasControl;
        private DataGridView selectedDataGridView;
        private Button deleteButton;
        private TextBox precoTextBox;
        private TextBox categoriaTextBox;
        private Label selectedItem;
        private Button addPeca;
        private TextBox nomeTextBox;
        private Label nomeLabel;
        private Label precoLabel;
        private Label categoriaLabel;
        private DataGridView allDataGridView;
        private GroupBox gb_pecas;
        private Label labelTotalRecords;
        private Label quantidadeLabel;
        private NumericUpDown pecaEstoqueNumeric;
    }
}