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
            button5 = new Button();
            btnAddNewBooks = new Button();
            btnSearchBook = new Button();
            btnUpdateBook = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            btnLogOut = new Button();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnAddNewBooks);
            panel1.Controls.Add(btnSearchBook);
            panel1.Controls.Add(btnUpdateBook);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(269, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 390);
            panel1.TabIndex = 35;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(50, 321);
            button5.Name = "button5";
            button5.Size = new Size(238, 48);
            button5.TabIndex = 34;
            button5.Text = "Books Tracking";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnAddNewBooks
            // 
            btnAddNewBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewBooks.Location = new Point(50, 35);
            btnAddNewBooks.Name = "btnAddNewBooks";
            btnAddNewBooks.Size = new Size(238, 48);
            btnAddNewBooks.TabIndex = 29;
            btnAddNewBooks.Text = "Add New Books";
            btnAddNewBooks.UseVisualStyleBackColor = true;
            btnAddNewBooks.Click += btnAddNewBooks_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBook.Location = new Point(50, 102);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(238, 48);
            btnSearchBook.TabIndex = 33;
            btnSearchBook.Text = "Search Books";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateBook.Location = new Point(50, 173);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(238, 48);
            btnUpdateBook.TabIndex = 30;
            btnUpdateBook.Text = "Update Book Details";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, 245);
            button2.Name = "button2";
            button2.Size = new Size(238, 48);
            button2.TabIndex = 31;
            button2.Text = "Delete Books";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(168, 12);
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
            label3.Location = new Point(220, 67);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 7;
            label3.Text = "Librarian";
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location = new Point(719, 127);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(152, 48);
            btnLogOut.TabIndex = 37;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 138);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 39;
            label4.Text = "//loggedin admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 38;
            label2.Text = "Session Admin:";
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 580);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnLogOut);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button btnAddNewBooks;
        private Button btnSearchBook;
        private Button btnUpdateBook;
        private Button button2;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Button btnLogOut;
        private Label label4;
        private Label label2;
    }
}