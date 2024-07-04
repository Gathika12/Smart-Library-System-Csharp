using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarty_Management_Sysy
{
    public partial class viewBooks : Form
    {
        public viewBooks()
        {
            InitializeComponent();
        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet5.issuedBooks' table. You can move, or remove it, as needed.
            this.issuedBooksTableAdapter.Fill(this.libraryManagementDataSet5.issuedBooks);
            // TODO: This line of code loads data into the 'libraryManagementDataSet4.returnBooks' table. You can move, or remove it, as needed.
            this.returnBooksTableAdapter.Fill(this.libraryManagementDataSet4.returnBooks);
            // TODO: This line of code loads data into the 'libraryManagementDataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryManagementDataSet1.book);

        }

        private void btn_addBooks_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBooks adb = new AddBooks();
            adb.Show();
        }

        private void btn_issueBook_Click(object sender, EventArgs e)
        {
            this.Close();
            IssueBooks isb = new IssueBooks();
            isb.Show();
        }

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnBooks rtb = new ReturnBooks();
            rtb.Show();
        }

        private void btn_members_Click(object sender, EventArgs e)
        {
            this.Close();
            Members m = new Members();
            m.Show();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            this.Close();
            books b = new books();
            b.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
