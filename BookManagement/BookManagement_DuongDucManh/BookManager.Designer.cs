namespace BookManagement_DuongDucManh
{
    partial class BookManager
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
            txtDescription = new TextBox();
            lblHeader = new Label();
            btnSearch = new Button();
            txtBookName = new TextBox();
            lblDescrition = new Label();
            lblBookName = new Label();
            dgvBookList = new DataGridView();
            SearchCriteia = new GroupBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SearchCriteia.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 15F);
            txtDescription.Location = new Point(504, 39);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(141, 41);
            txtDescription.TabIndex = 3;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 30F);
            lblHeader.ForeColor = Color.Gold;
            lblHeader.Location = new Point(22, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(350, 67);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F);
            btnSearch.ForeColor = Color.DarkMagenta;
            btnSearch.Location = new Point(666, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 41);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 15F);
            txtBookName.Location = new Point(167, 39);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(141, 41);
            txtBookName.TabIndex = 2;
            // 
            // lblDescrition
            // 
            lblDescrition.AutoSize = true;
            lblDescrition.Font = new Font("Segoe UI", 15F);
            lblDescrition.ForeColor = Color.Gold;
            lblDescrition.Location = new Point(344, 39);
            lblDescrition.Name = "lblDescrition";
            lblDescrition.Size = new Size(142, 35);
            lblDescrition.TabIndex = 1;
            lblDescrition.Text = "Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Microsoft Sans Serif", 15F);
            lblBookName.ForeColor = Color.Gold;
            lblBookName.Location = new Point(19, 39);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(142, 29);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book name";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(22, 239);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(815, 225);
            dgvBookList.TabIndex = 7;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // SearchCriteia
            // 
            SearchCriteia.Controls.Add(txtBookName);
            SearchCriteia.Controls.Add(btnSearch);
            SearchCriteia.Controls.Add(lblBookName);
            SearchCriteia.Controls.Add(txtDescription);
            SearchCriteia.Controls.Add(lblDescrition);
            SearchCriteia.Font = new Font("Segoe UI", 14F);
            SearchCriteia.ForeColor = Color.Gold;
            SearchCriteia.Location = new Point(22, 95);
            SearchCriteia.Name = "SearchCriteia";
            SearchCriteia.Size = new Size(815, 125);
            SearchCriteia.TabIndex = 0;
            SearchCriteia.TabStop = false;
            SearchCriteia.Text = " Search Criteria ";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Microsoft Sans Serif", 15F);
            btnCreate.ForeColor = Color.DarkMagenta;
            btnCreate.Location = new Point(843, 239);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(188, 46);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create Book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 15F);
            btnDelete.ForeColor = Color.DarkMagenta;
            btnDelete.Location = new Point(843, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 15F);
            btnUpdate.ForeColor = Color.DarkMagenta;
            btnUpdate.Location = new Point(843, 343);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 46);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Microsoft Sans Serif", 15F);
            btnQuit.ForeColor = Color.DarkMagenta;
            btnQuit.Location = new Point(843, 395);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(188, 46);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1175, 495);
            Controls.Add(btnQuit);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(SearchCriteia);
            Controls.Add(dgvBookList);
            Controls.Add(lblHeader);
            Name = "BookManager";
            Text = "Book Manager";
            Load += BookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            SearchCriteia.ResumeLayout(false);
            SearchCriteia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Label lblHeader;
        private Button btnSearch;
        private TextBox txtBookName;
        private Button button2;
        private Label lblDescrition;
        private Label lblBookName;
        private DataGridView dgvBookList;
        private GroupBox SearchCriteia;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnQuit;
    }
}
