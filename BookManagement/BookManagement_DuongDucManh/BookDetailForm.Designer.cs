namespace BookManagement_DuongDucManh
{
    partial class BookDetailForm
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
            btnSave = new Button();
            SearchCriteia = new GroupBox();
            cboBookCategory = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            SearchCriteia.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 15F);
            btnSave.ForeColor = Color.DarkMagenta;
            btnSave.Location = new Point(897, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 53);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SearchCriteia
            // 
            SearchCriteia.Controls.Add(cboBookCategory);
            SearchCriteia.Controls.Add(dtpPublicationDate);
            SearchCriteia.Controls.Add(txtAuthor);
            SearchCriteia.Controls.Add(txtPrice);
            SearchCriteia.Controls.Add(txtQuantity);
            SearchCriteia.Controls.Add(txtDescription);
            SearchCriteia.Controls.Add(txtBookName);
            SearchCriteia.Controls.Add(lblCategory);
            SearchCriteia.Controls.Add(lblAuthor);
            SearchCriteia.Controls.Add(lblPrice);
            SearchCriteia.Controls.Add(lblQuantity);
            SearchCriteia.Controls.Add(lblPublicationDate);
            SearchCriteia.Controls.Add(lblDescription);
            SearchCriteia.Controls.Add(lblBookId);
            SearchCriteia.Controls.Add(txtBookId);
            SearchCriteia.Controls.Add(lblBookName);
            SearchCriteia.Font = new Font("Segoe UI", 14F);
            SearchCriteia.ForeColor = Color.Gold;
            SearchCriteia.Location = new Point(12, 79);
            SearchCriteia.Name = "SearchCriteia";
            SearchCriteia.Size = new Size(852, 544);
            SearchCriteia.TabIndex = 3;
            SearchCriteia.TabStop = false;
            SearchCriteia.Text = "Book information";
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(219, 488);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(211, 39);
            cboBookCategory.TabIndex = 18;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(219, 239);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(211, 39);
            dtpPublicationDate.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 15F);
            txtAuthor.Location = new Point(219, 403);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(552, 41);
            txtAuthor.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 15F);
            txtPrice.Location = new Point(560, 312);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(211, 41);
            txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(219, 312);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(211, 41);
            txtQuantity.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 15F);
            txtDescription.Location = new Point(219, 166);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(552, 64);
            txtDescription.TabIndex = 12;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 15F);
            txtBookName.Location = new Point(219, 105);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(552, 41);
            txtBookName.TabIndex = 11;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 15F);
            lblCategory.ForeColor = Color.Gold;
            lblCategory.Location = new Point(19, 488);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(115, 29);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Microsoft Sans Serif", 15F);
            lblAuthor.ForeColor = Color.Gold;
            lblAuthor.Location = new Point(19, 403);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(87, 29);
            lblAuthor.TabIndex = 9;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 15F);
            lblPrice.ForeColor = Color.Gold;
            lblPrice.Location = new Point(467, 312);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(71, 29);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 15F);
            lblQuantity.ForeColor = Color.Gold;
            lblQuantity.Location = new Point(19, 312);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(107, 29);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Microsoft Sans Serif", 15F);
            lblPublicationDate.ForeColor = Color.Gold;
            lblPublicationDate.Location = new Point(19, 239);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(194, 29);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 15F);
            lblDescription.ForeColor = Color.Gold;
            lblDescription.Location = new Point(19, 166);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 29);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Microsoft Sans Serif", 15F);
            lblBookId.ForeColor = Color.Gold;
            lblBookId.Location = new Point(19, 55);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(102, 29);
            lblBookId.TabIndex = 4;
            lblBookId.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI", 15F);
            txtBookId.Location = new Point(219, 38);
            txtBookId.Multiline = true;
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(552, 46);
            txtBookId.TabIndex = 2;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Microsoft Sans Serif", 15F);
            lblBookName.ForeColor = Color.Gold;
            lblBookName.Location = new Point(19, 105);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(142, 29);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book name";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 30F);
            lblHeader.ForeColor = Color.Gold;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(346, 67);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "ADD | UPDATE";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 15F);
            btnCancel.ForeColor = Color.DarkMagenta;
            btnCancel.Location = new Point(897, 221);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 53);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1097, 690);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(SearchCriteia);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add|Update";
            Load += BookUpdateForm_Load;
            SearchCriteia.ResumeLayout(false);
            SearchCriteia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox SearchCriteia;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblHeader;
        private Label lblBookId;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private Button btnCancel;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategory;
    }
}