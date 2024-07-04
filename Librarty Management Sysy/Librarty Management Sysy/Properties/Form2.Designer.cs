
namespace Librarty_Management_Sysy.Properties
{
    partial class Form2
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
            this.libraryManagementDataSet4 = new Librarty_Management_Sysy.LibraryManagementDataSet4();
            this.returnBooksTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet4TableAdapters.returnBooksTableAdapter();
            this.issuedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet5 = new Librarty_Management_Sysy.LibraryManagementDataSet5();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.issuedBooksTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet5TableAdapters.issuedBooksTableAdapter();
            this.returnBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_books = new Guna.UI2.WinForms.Guna2Button();
            this.btn_members = new Guna.UI2.WinForms.Guna2Button();
            this.btn_returnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_issueBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addBooks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet1 = new Librarty_Management_Sysy.LibraryManagementDataSet1();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bookTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet1TableAdapters.bookTableAdapter();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.libraryManagementDataSet6 = new Librarty_Management_Sysy.LibraryManagementDataSet6();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter1 = new Librarty_Management_Sysy.LibraryManagementDataSet6TableAdapters.bookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryManagementDataSet4
            // 
            this.libraryManagementDataSet4.DataSetName = "LibraryManagementDataSet4";
            this.libraryManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnBooksTableAdapter
            // 
            this.returnBooksTableAdapter.ClearBeforeFill = true;
            // 
            // issuedBooksBindingSource
            // 
            this.issuedBooksBindingSource.DataMember = "issuedBooks";
            this.issuedBooksBindingSource.DataSource = this.libraryManagementDataSet5;
            // 
            // libraryManagementDataSet5
            // 
            this.libraryManagementDataSet5.DataSetName = "LibraryManagementDataSet5";
            this.libraryManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(493, 80);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(270, 38);
            this.guna2HtmlLabel2.TabIndex = 69;
            this.guna2HtmlLabel2.Text = "VIEW ALL  BOOKS ";
            // 
            // issuedBooksTableAdapter
            // 
            this.issuedBooksTableAdapter.ClearBeforeFill = true;
            // 
            // returnBooksBindingSource
            // 
            this.returnBooksBindingSource.DataMember = "returnBooks";
            this.returnBooksBindingSource.DataSource = this.libraryManagementDataSet4;
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
            this.guna2Panel1.Location = new System.Drawing.Point(32, -54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(402, 1217);
            this.guna2Panel1.TabIndex = 64;
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
            this.btn_exit.Location = new System.Drawing.Point(74, 1072);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(309, 64);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.btn_books.Location = new System.Drawing.Point(74, 427);
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
            this.btn_members.Location = new System.Drawing.Point(74, 344);
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
            this.btn_returnBook.Location = new System.Drawing.Point(74, 255);
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
            this.btn_issueBook.Location = new System.Drawing.Point(74, 166);
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
            this.btn_addBooks.Location = new System.Drawing.Point(74, 78);
            this.btn_addBooks.Name = "btn_addBooks";
            this.btn_addBooks.Size = new System.Drawing.Size(362, 64);
            this.btn_addBooks.TabIndex = 0;
            this.btn_addBooks.Text = "ADD BOOKS";
            this.btn_addBooks.Click += new System.EventHandler(this.btn_addBooks_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            this.isbnDataGridViewTextBoxColumn,
            this.boolkNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.bookBindingSource1;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(493, 157);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(837, 233);
            this.guna2DataGridView1.TabIndex = 66;
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
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // boolkNameDataGridViewTextBoxColumn
            // 
            this.boolkNameDataGridViewTextBoxColumn.DataPropertyName = "boolkName";
            this.boolkNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.boolkNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.boolkNameDataGridViewTextBoxColumn.Name = "boolkNameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            this.publicationDataGridViewTextBoxColumn.DataPropertyName = "publication";
            this.publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            this.publicationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.libraryManagementDataSet1;
            // 
            // libraryManagementDataSet1
            // 
            this.libraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1";
            this.libraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(493, -30);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(203, 38);
            this.guna2HtmlLabel8.TabIndex = 65;
            this.guna2HtmlLabel8.Text = "VIEW BOOKS";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // libraryManagementDataSet6
            // 
            this.libraryManagementDataSet6.DataSetName = "LibraryManagementDataSet6";
            this.libraryManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "book";
            this.bookBindingSource1.DataSource = this.libraryManagementDataSet6;
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 1108);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBooksBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryManagementDataSet4 libraryManagementDataSet4;
        private LibraryManagementDataSet4TableAdapters.returnBooksTableAdapter returnBooksTableAdapter;
        private System.Windows.Forms.BindingSource issuedBooksBindingSource;
        private LibraryManagementDataSet5 libraryManagementDataSet5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private LibraryManagementDataSet5TableAdapters.issuedBooksTableAdapter issuedBooksTableAdapter;
        private System.Windows.Forms.BindingSource returnBooksBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_books;
        private Guna.UI2.WinForms.Guna2Button btn_members;
        private Guna.UI2.WinForms.Guna2Button btn_returnBook;
        private Guna.UI2.WinForms.Guna2Button btn_issueBook;
        private Guna.UI2.WinForms.Guna2Button btn_addBooks;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boolkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryManagementDataSet1 libraryManagementDataSet1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private LibraryManagementDataSet1TableAdapters.bookTableAdapter bookTableAdapter;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private LibraryManagementDataSet6 libraryManagementDataSet6;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private LibraryManagementDataSet6TableAdapters.bookTableAdapter bookTableAdapter1;
    }
}