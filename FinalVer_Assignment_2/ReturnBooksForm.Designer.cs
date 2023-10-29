namespace FinalVer_Assignment_2
{
    partial class ReturnBooksForm
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
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            btnReturnBooks = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 260);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(773, 342);
            dataGridView1.TabIndex = 46;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(19, 218);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 53);
            btnBack.TabIndex = 45;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnReturnBooks
            // 
            btnReturnBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnBooks.Location = new Point(470, 638);
            btnReturnBooks.Margin = new Padding(4, 5, 4, 5);
            btnReturnBooks.Name = "btnReturnBooks";
            btnReturnBooks.Size = new Size(250, 73);
            btnReturnBooks.TabIndex = 44;
            btnReturnBooks.Text = "Return Books";
            btnReturnBooks.UseVisualStyleBackColor = true;
           
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(210, 20);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 188);
            panel2.TabIndex = 43;
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
            label3.Location = new Point(261, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 48);
            label3.TabIndex = 7;
            label3.Text = "Return Books";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1009, 533);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(147, 53);
            btnRefresh.TabIndex = 47;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnReturnBooks.Click += btnRefresh_Click;
            // 
            // ReturnBooksForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 752);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(btnReturnBooks);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReturnBooksForm";
            Text = "ReturnBooksForm";
            Load += ReturnBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBack;
        private Button btnReturnBooks;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Button btnRefresh;
    }
}