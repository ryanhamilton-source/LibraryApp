namespace FinalVer_Assignment_2
{
    partial class AddNewBookForm
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
            panel1 = new Panel();
            cmbGenre = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            txtBookAuthor = new TextBox();
            txtBookTitle = new TextBox();
            lblPassword = new Label();
            btnID = new Button();
            btnAddBook = new Button();
            label4 = new Label();
            label2 = new Label();
            lblFName = new Label();
            lblLName = new Label();
            lblPass = new Label();
            lblID = new Label();
            btnBack = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbGenre);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBookAuthor);
            panel1.Controls.Add(txtBookTitle);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(btnID);
            panel1.Controls.Add(btnAddBook);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblFName);
            panel1.Controls.Add(lblLName);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblID);
            panel1.Location = new Point(155, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 341);
            panel1.TabIndex = 38;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Mystery", "Science Fiction", "Romance", "Fantasy", "Thriller", "Adventure" });
            cmbGenre.Location = new Point(175, 154);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(290, 23);
            cmbGenre.TabIndex = 37;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(175, 193);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(290, 23);
            numericUpDown1.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(37, 193);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 35;
            label5.Text = "Number of Copies";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(175, 108);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(290, 23);
            txtBookAuthor.TabIndex = 34;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(175, 63);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(290, 23);
            txtBookTitle.TabIndex = 32;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.Location = new Point(175, 61);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 21);
            lblPassword.TabIndex = 31;
            // 
            // btnID
            // 
            btnID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnID.Location = new Point(336, 20);
            btnID.Name = "btnID";
            btnID.Size = new Size(95, 24);
            btnID.TabIndex = 30;
            btnID.Text = "Generate ID";
            btnID.UseVisualStyleBackColor = true;
            btnID.Click += btnID_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.Location = new Point(175, 262);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(175, 44);
            btnAddBook.TabIndex = 29;
            btnAddBook.Text = "Add New Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(79, 106);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 27;
            label4.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(87, 20);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 22;
            label2.Text = "BookID";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFName.Location = new Point(69, 65);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(83, 21);
            lblFName.TabIndex = 14;
            lblFName.Text = "Book Title";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLName.Location = new Point(83, 152);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(52, 21);
            lblLName.TabIndex = 16;
            lblLName.Text = "Genre";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPass.Location = new Point(79, 61);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(0, 21);
            lblPass.TabIndex = 20;
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
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 133);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 32);
            btnBack.TabIndex = 37;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(155, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 113);
            panel2.TabIndex = 36;
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
            label3.Location = new Point(166, 68);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 7;
            label3.Text = "Add New Book";
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 551);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Name = "AddNewBookForm";
            Text = "AddNewBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPassword;
        private Button btnID;
        private Button btnAddBook;
        private Label label4;
        private Label label2;
        private Label lblFName;
        private Label lblLName;
        private Label lblPass;
        private Label lblID;
        private Button btnBack;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox txtBookAuthor;
        private TextBox txtBookTitle;
        private ComboBox cmbGenre;
    }
}