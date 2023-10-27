using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalVer_Assignment_2
{
    partial class UserForm
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
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button5 = new Button();
            btnSearch = new Button();
            btnBorrowBooks = new Button();
            btnLogOut = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(122, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 113);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(257, 69);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 7;
            label3.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 138);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 38;
            label4.Text = "//loggedin user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 37;
            label2.Text = "Session User:";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnBorrowBooks);
            panel1.Location = new Point(240, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 341);
            panel1.TabIndex = 39;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(50, 254);
            button1.Name = "button1";
            button1.Size = new Size(238, 48);
            button1.TabIndex = 35;
            button1.Text = "View Borrow Books";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(50, 179);
            button5.Name = "button5";
            button5.Size = new Size(238, 48);
            button5.TabIndex = 34;
            button5.Text = "Return Books";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(50, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(238, 48);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search Books";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBorrowBooks
            // 
            btnBorrowBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrowBooks.Location = new Point(50, 102);
            btnBorrowBooks.Name = "btnBorrowBooks";
            btnBorrowBooks.Size = new Size(238, 48);
            btnBorrowBooks.TabIndex = 33;
            btnBorrowBooks.Text = "Borrow Books";
            btnBorrowBooks.UseVisualStyleBackColor = true;
            btnBorrowBooks.Click += btnBorrowBooks_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location = new Point(670, 138);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(152, 48);
            btnLogOut.TabIndex = 40;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 607);
            Controls.Add(btnLogOut);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "UserForm";
            Text = "User";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Button button5;
        private Button btnSearch;
        private Button btnBorrowBooks;
        private Button button1;
        private Button btnLogOut;
    }
}