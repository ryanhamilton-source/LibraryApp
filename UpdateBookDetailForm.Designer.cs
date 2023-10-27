namespace FinalVer_Assignment_2
{
    partial class UpdateBookDetailForm
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            cmbGenre = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            txtBookAuthor = new TextBox();
            txtBookTitle = new TextBox();
            lblPassword = new Label();
            btnUpdateBookDetails = new Button();
            label4 = new Label();
            label6 = new Label();
            lblFName = new Label();
            lblLName = new Label();
            lblPass = new Label();
            lblID = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(128, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 113);
            panel2.TabIndex = 37;
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
            label3.Location = new Point(149, 68);
            label3.Name = "label3";
            label3.Size = new Size(246, 32);
            label3.TabIndex = 7;
            label3.Text = "Update Book Details";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(502, 141);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 24);
            btnSearch.TabIndex = 49;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(314, 142);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 23);
            txtSearch.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(247, 144);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 47;
            label2.Text = "Search:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 107);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 32);
            btnBack.TabIndex = 50;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbGenre);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBookAuthor);
            panel1.Controls.Add(txtBookTitle);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(btnUpdateBookDetails);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblFName);
            panel1.Controls.Add(lblLName);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblID);
            panel1.Location = new Point(128, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 341);
            panel1.TabIndex = 51;
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
            // btnUpdateBookDetails
            // 
            btnUpdateBookDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBookDetails.Location = new Point(154, 262);
            btnUpdateBookDetails.Name = "btnUpdateBookDetails";
            btnUpdateBookDetails.Size = new Size(241, 44);
            btnUpdateBookDetails.TabIndex = 29;
            btnUpdateBookDetails.Text = "Update Book Details";
            btnUpdateBookDetails.UseVisualStyleBackColor = true;
            btnUpdateBookDetails.Click += btnUpdateBookDetails_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(87, 20);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 22;
            label6.Text = "BookID";
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
            // UpdateBookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "UpdateBookDetailForm";
            Text = "UpdateBookDetailForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label3;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Button btnBack;
        private Panel panel1;
        private ComboBox cmbGenre;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox txtBookAuthor;
        private TextBox txtBookTitle;
        private Label lblPassword;
        private Button btnUpdateBookDetails;
        private Label label4;
        private Label label6;
        private Label lblFName;
        private Label lblLName;
        private Label lblPass;
        private Label lblID;
    }
}