
namespace Librarty_Management_Sysy
{
    partial class ReturnView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.libraryManagementDataSet1 = new Librarty_Management_Sysy.LibraryManagementDataSet1();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet1TableAdapters.bookTableAdapter();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_books = new Guna.UI2.WinForms.Guna2Button();
            this.btn_members = new Guna.UI2.WinForms.Guna2Button();
            this.btn_returnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_issueBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addBooks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.libraryManagementDataSet3 = new Librarty_Management_Sysy.LibraryManagementDataSet3();
            this.returnBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnBooksTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet3TableAdapters.returnBooksTableAdapter();
            this.recNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // libraryManagementDataSet1
            // 
            this.libraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1";
            this.libraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.libraryManagementDataSet1;
            this.bookBindingSource.CurrentChanged += new System.EventHandler(this.bookBindingSource_CurrentChanged);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(460, 63);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(232, 38);
            this.guna2HtmlLabel8.TabIndex = 61;
            this.guna2HtmlLabel8.Text = "RETURN BOOK";
            this.guna2HtmlLabel8.Click += new System.EventHandler(this.guna2HtmlLabel8_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btn_exit
            // 
            this.btn_exit.AutoRoundedCorners = true;
            this.btn_exit.BorderRadius = 31;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(69, 701);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(309, 64);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            // 
            // btn_books
            // 
            this.btn_books.AutoRoundedCorners = true;
            this.btn_books.BorderRadius = 31;
            this.btn_books.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_books.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_books.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_books.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_books.FillColor = System.Drawing.Color.White;
            this.btn_books.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_books.ForeColor = System.Drawing.Color.Black;
            this.btn_books.Location = new System.Drawing.Point(69, 427);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(362, 64);
            this.btn_books.TabIndex = 4;
            this.btn_books.Text = "BOOKS";
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_members
            // 
            this.btn_members.AutoRoundedCorners = true;
            this.btn_members.BorderRadius = 31;
            this.btn_members.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_members.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_members.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_members.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_members.FillColor = System.Drawing.Color.DimGray;
            this.btn_members.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_members.ForeColor = System.Drawing.Color.White;
            this.btn_members.Location = new System.Drawing.Point(69, 344);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(362, 64);
            this.btn_members.TabIndex = 3;
            this.btn_members.Text = "MEMBERS";
            this.btn_members.Click += new System.EventHandler(this.btn_members_Click);
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.AutoRoundedCorners = true;
            this.btn_returnBook.BorderRadius = 31;
            this.btn_returnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_returnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_returnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_returnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_returnBook.FillColor = System.Drawing.Color.DimGray;
            this.btn_returnBook.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_returnBook.ForeColor = System.Drawing.Color.White;
            this.btn_returnBook.Location = new System.Drawing.Point(69, 255);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(362, 64);
            this.btn_returnBook.TabIndex = 2;
            this.btn_returnBook.Text = "RETURN BOOK";
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // btn_issueBook
            // 
            this.btn_issueBook.AutoRoundedCorners = true;
            this.btn_issueBook.BorderRadius = 31;
            this.btn_issueBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_issueBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_issueBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_issueBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_issueBook.FillColor = System.Drawing.Color.DimGray;
            this.btn_issueBook.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_issueBook.ForeColor = System.Drawing.Color.White;
            this.btn_issueBook.Location = new System.Drawing.Point(69, 166);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(362, 64);
            this.btn_issueBook.TabIndex = 1;
            this.btn_issueBook.Text = "ISSUE BOOK";
            this.btn_issueBook.Click += new System.EventHandler(this.btn_issueBook_Click);
            // 
            // btn_addBooks
            // 
            this.btn_addBooks.AutoRoundedCorners = true;
            this.btn_addBooks.BorderRadius = 31;
            this.btn_addBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addBooks.FillColor = System.Drawing.Color.DimGray;
            this.btn_addBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_addBooks.ForeColor = System.Drawing.Color.White;
            this.btn_addBooks.Location = new System.Drawing.Point(69, 78);
            this.btn_addBooks.Name = "btn_addBooks";
            this.btn_addBooks.Size = new System.Drawing.Size(362, 64);
            this.btn_addBooks.TabIndex = 0;
            this.btn_addBooks.Text = "ADD BOOKS";
            this.btn_addBooks.Click += new System.EventHandler(this.btn_addBooks_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.guna2DataGridView1.ColumnHeadersHeight = 19;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recNoDataGridViewTextBoxColumn,
            this.bookISBNDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.memIDDataGridViewTextBoxColumn,
            this.memNameDataGridViewTextBoxColumn,
            this.issuedDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.returnBooksBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(460, 141);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(837, 611);
            this.guna2DataGridView1.TabIndex = 62;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 19;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.guna2Panel1.Controls.Add(this.btn_exit);
            this.guna2Panel1.Controls.Add(this.btn_books);
            this.guna2Panel1.Controls.Add(this.btn_members);
            this.guna2Panel1.Controls.Add(this.btn_returnBook);
            this.guna2Panel1.Controls.Add(this.btn_issueBook);
            this.guna2Panel1.Controls.Add(this.btn_addBooks);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(402, 813);
            this.guna2Panel1.TabIndex = 60;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // libraryManagementDataSet3
            // 
            this.libraryManagementDataSet3.DataSetName = "LibraryManagementDataSet3";
            this.libraryManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnBooksBindingSource
            // 
            this.returnBooksBindingSource.DataMember = "returnBooks";
            this.returnBooksBindingSource.DataSource = this.libraryManagementDataSet3;
            // 
            // returnBooksTableAdapter
            // 
            this.returnBooksTableAdapter.ClearBeforeFill = true;
            // 
            // recNoDataGridViewTextBoxColumn
            // 
            this.recNoDataGridViewTextBoxColumn.DataPropertyName = "recNo";
            this.recNoDataGridViewTextBoxColumn.HeaderText = "recNo";
            this.recNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recNoDataGridViewTextBoxColumn.Name = "recNoDataGridViewTextBoxColumn";
            this.recNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookISBNDataGridViewTextBoxColumn
            // 
            this.bookISBNDataGridViewTextBoxColumn.DataPropertyName = "bookISBN";
            this.bookISBNDataGridViewTextBoxColumn.HeaderText = "bookISBN";
            this.bookISBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookISBNDataGridViewTextBoxColumn.Name = "bookISBNDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // memIDDataGridViewTextBoxColumn
            // 
            this.memIDDataGridViewTextBoxColumn.DataPropertyName = "memID";
            this.memIDDataGridViewTextBoxColumn.HeaderText = "memID";
            this.memIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memIDDataGridViewTextBoxColumn.Name = "memIDDataGridViewTextBoxColumn";
            // 
            // memNameDataGridViewTextBoxColumn
            // 
            this.memNameDataGridViewTextBoxColumn.DataPropertyName = "memName";
            this.memNameDataGridViewTextBoxColumn.HeaderText = "memName";
            this.memNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memNameDataGridViewTextBoxColumn.Name = "memNameDataGridViewTextBoxColumn";
            // 
            // issuedDateDataGridViewTextBoxColumn
            // 
            this.issuedDateDataGridViewTextBoxColumn.DataPropertyName = "issuedDate";
            this.issuedDateDataGridViewTextBoxColumn.HeaderText = "issuedDate";
            this.issuedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issuedDateDataGridViewTextBoxColumn.Name = "issuedDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "returnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "returnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // ReturnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 742);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnView";
            this.Text = "ReturnView";
            this.Load += new System.EventHandler(this.ReturnView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private LibraryManagementDataSet1 libraryManagementDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryManagementDataSet1TableAdapters.bookTableAdapter bookTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_books;
        private Guna.UI2.WinForms.Guna2Button btn_members;
        private Guna.UI2.WinForms.Guna2Button btn_returnBook;
        private Guna.UI2.WinForms.Guna2Button btn_issueBook;
        private Guna.UI2.WinForms.Guna2Button btn_addBooks;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private LibraryManagementDataSet3 libraryManagementDataSet3;
        private System.Windows.Forms.BindingSource returnBooksBindingSource;
        private LibraryManagementDataSet3TableAdapters.returnBooksTableAdapter returnBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
    }
}