namespace FinalVer_Assignment_2
{
    partial class ListLibrarianForm
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(533, 148);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 24);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(345, 149);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 23);
            txtSearch.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 151);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 44;
            label2.Text = "Search:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(23, 129);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 32);
            btnBack.TabIndex = 43;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 233);
            dataGridView1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(145, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 113);
            panel2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 68);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 7;
            label3.Text = "List all librarians";
            // 
            // ListLibrarianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 463);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "ListLibrarianForm";
            Text = "ListLibrarianForm";
            Load += ListLibrarianForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Button btnBack;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Label label3;
    }
}