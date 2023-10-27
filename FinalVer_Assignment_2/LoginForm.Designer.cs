using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalVer_Assignment_2
{
    partial class LoginForm
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
            lblTitle = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblPass = new Label();
            lblName = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(48, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(448, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(235, 69);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(134, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 113);
            panel1.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(306, 247);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(280, 23);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(322, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPass.Location = new Point(201, 247);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(93, 25);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(201, 178);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Username";
            // 
            // txtName
            // 
            txtName.Location = new Point(306, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 23);
            txtName.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblPass);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label lblTitle;
        private Label label2;
        private Panel panel1;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lblPass;
        private Label lblName;
        private TextBox txtName;
    }
}