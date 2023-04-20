namespace Lab3_HC_
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(152, 23);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(119, 25);
            this.tbSearch.TabIndex = 1;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(277, 23);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(134, 25);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book a book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete a book";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(557, 23);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(134, 25);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(399, 280);
            this.dataGridView.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 280);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSort.Location = new System.Drawing.Point(170, 55);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 376);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Книжковий каталог";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSort;
    }
}

