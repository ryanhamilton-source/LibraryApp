using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalVer_Assignment_2
{
    partial class LibrarianForm
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
            btnBooksTracking = new Button();
            btnAddNewBooks = new Button();
            btnSearchBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBooks = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBooksTracking);
            panel1.Controls.Add(btnAddNewBooks);
            panel1.Controls.Add(btnSearchBook);
            panel1.Controls.Add(btnUpdateBook);
            panel1.Controls.Add(btnDeleteBooks);
            panel1.Location = new Point(384, 250);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 650);
            panel1.TabIndex = 35;
            // 
            // BtnBooksTracking
            // 
            btnBooksTracking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooksTracking.Location = new Point(71, 535);
            btnBooksTracking.Margin = new Padding(4, 5, 4, 5);
            btnBooksTracking.Name = "BtnBooksTracking";
            btnBooksTracking.Size = new Size(340, 80);
            btnBooksTracking.TabIndex = 34;
            btnBooksTracking.Text = "Books Tracking";
            btnBooksTracking.UseVisualStyleBackColor = true;
            btnBooksTracking.Click += btnBooksTracking_Click;
            // 
            // btnAddNewBooks
            // 
            btnAddNewBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewBooks.Location = new Point(71, 58);
            btnAddNewBooks.Margin = new Padding(4, 5, 4, 5);
            btnAddNewBooks.Name = "btnAddNewBooks";
            btnAddNewBooks.Size = new Size(340, 80);
            btnAddNewBooks.TabIndex = 29;
            btnAddNewBooks.Text = "Add New Books";
            btnAddNewBooks.UseVisualStyleBackColor = true;
            btnAddNewBooks.Click += btnAddNewBooks_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBook.Location = new Point(71, 170);
            btnSearchBook.Margin = new Padding(4, 5, 4, 5);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(340, 80);
            btnSearchBook.TabIndex = 33;
            btnSearchBook.Text = "Search Books";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBook.Location = new Point(71, 288);
            btnUpdateBook.Margin = new Padding(4, 5, 4, 5);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(340, 80);
            btnUpdateBook.TabIndex = 30;
            btnUpdateBook.Text = "Update Book Details";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBooks
            // 
            btnDeleteBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteBooks.Location = new Point(71, 408);
            btnDeleteBooks.Margin = new Padding(4, 5, 4, 5);
            btnDeleteBooks.Name = "btnDeleteBooks";
            btnDeleteBooks.Size = new Size(340, 80);
            btnDeleteBooks.TabIndex = 31;
            btnDeleteBooks.Text = "Delete Books";
            btnDeleteBooks.UseVisualStyleBackColor = true;
            btnDeleteBooks.Click += btnDeleteBooks_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(240, 20);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 188);
            panel2.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(678, 65);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 7;
            label3.Text = "Librarian";
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location = new Point(1027, 212);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(217, 80);
            btnLogOut.TabIndex = 37;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 967);
            Controls.Add(btnLogOut);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBooksTracking;
        private Button btnAddNewBooks;
        private Button btnSearchBook;
        private Button btnUpdateBook;
        private Button btnDeleteBooks;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Button btnLogOut;
    }
}