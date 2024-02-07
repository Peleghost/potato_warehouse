namespace Potato.WindowsForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            closeButton = new Button();
            label5 = new Label();
            loginButton = new Button();
            panel4 = new Panel();
            passwordTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            usernameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 491);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 157);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 469);
            label4.Name = "label4";
            label4.Size = new Size(159, 13);
            label4.TabIndex = 0;
            label4.Text = "Fellipe Teles, Murilo S. Gomes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 452);
            label3.Name = "label3";
            label3.Size = new Size(95, 13);
            label3.TabIndex = 0;
            label3.Text = "Desenvolvimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 278);
            label2.Name = "label2";
            label2.Size = new Size(140, 18);
            label2.TabIndex = 0;
            label2.Text = "Sistema Interno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 246);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Batata Motos";
            // 
            // panel2
            // 
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(283, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 491);
            panel2.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.DimGray;
            closeButton.Location = new Point(419, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(32, 34);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            closeButton.MouseHover += closeButton_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(6, 144);
            label5.Name = "label5";
            label5.Size = new Size(220, 29);
            label5.TabIndex = 3;
            label5.Text = "Acesse sua conta";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DimGray;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(6, 293);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(433, 58);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(passwordTextBox);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(3, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 48);
            panel4.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(61, 12);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(375, 27);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 38);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameTextBox);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 48);
            panel3.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(61, 12);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(375, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(734, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batata Motos - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private PictureBox pictureBox3;
        private Button loginButton;
        private Label label5;
        private Button closeButton;
    }
}