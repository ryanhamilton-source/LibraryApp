namespace dotnet_Assignment_2
{
    partial class AddBooks
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
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblFName = new Label();
            txtFName = new TextBox();
            lblLName = new Label();
            txtLName = new TextBox();
            lblEmail = new Label();
            lblPass = new Label();
            txtPass = new TextBox();
            lblID = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            textBox1 = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(161, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 113);
            panel2.TabIndex = 29;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 70);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 7;
            label3.Text = "Add New Books";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblFName);
            panel1.Controls.Add(txtFName);
            panel1.Controls.Add(lblLName);
            panel1.Controls.Add(txtLName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(lblID);
            panel1.Location = new Point(161, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 383);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(79, 20);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 22;
            label2.Text = "Book ID";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFName.Location = new Point(83, 104);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(60, 21);
            lblFName.TabIndex = 14;
            lblFName.Text = "Author";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(175, 104);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(290, 23);
            txtFName.TabIndex = 15;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLName.Location = new Point(37, 196);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(132, 21);
            lblLName.TabIndex = 16;
            lblLName.Text = "Publication Date";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(175, 194);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(290, 23);
            txtLName.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEmail.Location = new Point(34, 247);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(135, 21);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Number of copies";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPass.Location = new Point(91, 58);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(43, 21);
            lblPass.TabIndex = 20;
            lblPass.Text = "Title";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(175, 56);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(290, 23);
            txtPass.TabIndex = 21;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblID.Location = new Point(175, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(155, 21);
            lblID.TabIndex = 23;
            lblID.Text = "id //auto generated ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(175, 247);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(290, 23);
            numericUpDown1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(83, 152);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 27;
            label4.Text = "Genre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 28;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(175, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 44);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Add Book";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 123);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 40);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 594);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddBooks";
            Text = "AddBook";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label lblFName;
        private TextBox txtFName;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblEmail;
        private Label lblPass;
        private TextBox txtPass;
        private Label lblID;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private TextBox textBox1;
        private Button btnLogin;
        private Button btnBack;
    }
}