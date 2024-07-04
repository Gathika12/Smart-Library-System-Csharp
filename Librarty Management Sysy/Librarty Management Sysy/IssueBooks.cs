using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarty_Management_Sysy
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
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
            addMembers m = new addMembers();
            m.Show();
        }

        private void btn_book_Click(object sender, EventArgs e)
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

        private void btn_issue_Click(object sender, EventArgs e)
        {
            String isbn = txt_isbn.Text;
            String bName = txt_isbn.Text;
            String mID = txt_mID.Text;
            String mName = txt_mName.Text;
            String iDate = txt_iDate.Text;
            String dDate = txt_dDate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmdOne = new SqlCommand("insert into issuedBooks (bookISBN,bookName,memID,memName,issuedDate,dueDate) values ('" + isbn + "','" + bName + "','" + mID + "','" + mName + "','" + iDate + "','" + dDate + "')", con);
            int i = cmdOne.ExecuteNonQuery();
            cmdOne.Dispose();

            if (i == 1)
            {
                txt_bName.Clear();
                txt_dDate.Clear();
                txt_iDate.Clear();
                txt_isbn.Clear();
                txt_mID.Clear();
                txt_mName.Clear();

                Sucess suc = new Sucess();
                suc.ShowDialog();
            }
            else
            {
                error404F err = new error404F();
                err.ShowDialog();
            }

            con.Close();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bName.Clear();
            txt_dDate.Clear();
            txt_iDate.Clear();
            txt_isbn.Clear();
            txt_mID.Clear();
            txt_mName.Clear();
        }
    }
}
