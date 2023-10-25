using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalVer_Assignment_2
{
    partial class AdminForm
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
            btnAddUser = new Button();
            btnLogOut = new Button();
            btnAddLibrarian = new Button();
            panel1 = new Panel();
            button6 = new Button();
            btnListUser = new Button();
            label2 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(149, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 113);
            panel2.TabIndex = 28;
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
            label3.Size = new Size(90, 32);
            label3.TabIndex = 7;
            label3.Text = "Admin";
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.Location = new Point(50, 29);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(238, 48);
            btnAddUser.TabIndex = 29;
            btnAddUser.Text = "Add New User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location = new Point(669, 152);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(152, 48);
            btnLogOut.TabIndex = 32;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnAddLibrarian
            // 
            btnAddLibrarian.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLibrarian.Location = new Point(50, 102);
            btnAddLibrarian.Name = "btnAddLibrarian";
            btnAddLibrarian.Size = new Size(238, 48);
            btnAddLibrarian.TabIndex = 33;
            btnAddLibrarian.Text = "Add New Librarian";
            btnAddLibrarian.UseVisualStyleBackColor = true;
            btnAddLibrarian.Click += btnAddLibrarian_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnListUser);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnAddLibrarian);
            panel1.Location = new Point(248, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 341);
            panel1.TabIndex = 34;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(50, 258);
            button6.Name = "button6";
            button6.Size = new Size(238, 48);
            button6.TabIndex = 35;
            button6.Text = "List all librarian";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnListUser
            // 
            btnListUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListUser.Location = new Point(50, 179);
            btnListUser.Name = "btnListUser";
            btnListUser.Size = new Size(238, 48);
            btnListUser.TabIndex = 34;
            btnListUser.Text = "List all user";
            btnListUser.UseVisualStyleBackColor = true;
            btnListUser.Click += btnListUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 35;
            label2.Text = "Session Admin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 143);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 36;
            label4.Text = "//loggedin admin";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 557);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnLogOut);
            Controls.Add(panel2);
            Name = "AdminForm";
            Text = "Admin";
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
        private Button btnAddUser;
        private Button btnLogOut;
        private Button btnAddLibrarian;
        private Panel panel1;
        private Button btnListUser;
        private Label label2;
        private Label label4;
        private Button button6;
    }
}