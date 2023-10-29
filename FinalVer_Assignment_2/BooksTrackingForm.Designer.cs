namespace FinalVer_Assignment_2
{
    partial class BooksTrackingForm
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
            label1 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnBack2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(191, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 188);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 16);
            label1.Name = "label1";
            label1.Size = new Size(678, 65);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 113);
            label4.Name = "label4";
            label4.Size = new Size(259, 48);
            label4.TabIndex = 1;
            label4.Text = "Book Tracking";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(259, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(657, 271);
            dataGridView1.TabIndex = 1;
            // 
            // btnBack2
            // 
            btnBack2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack2.Location = new Point(37, 174);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(147, 53);
            btnBack2.TabIndex = 0;
            btnBack2.Text = "Back";
            btnBack2.UseVisualStyleBackColor = true;
            btnBack2.Click += btnBack_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(516, 247);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSearch_Click;
            // 
            // BooksTrackingForm
            // 
            ClientSize = new Size(1183, 573);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(btnBack2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "BooksTrackingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += ListBookForm_Load;
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnBack2;
        private TextBox textBox2;
        private Button button1;
    }
}
