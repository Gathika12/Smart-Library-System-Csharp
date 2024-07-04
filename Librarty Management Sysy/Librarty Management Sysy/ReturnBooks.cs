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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mName.Clear();
            txt_memID.Clear();
            txt_isseDate.Clear();
            txt_ISBN.Clear();
            txt_bookName.Clear();
            txt_dueDate.ClearSelection();
            txt_returnDate.Clear();
            lbl_fine.Text = "There is no fine records available";
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            String mName = txt_mName.Text;
            String mID = txt_memID.Text;
            String bName = txt_bookName.Text;
            String isbn = txt_ISBN.Text;
            String issDate = txt_isseDate.Text;
            String dueDate = txt_dueDate.Text;
            String retDate = txt_returnDate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmdOne = new SqlCommand("insert into returnBooks (bookISBN,bookName,memID,memName,issuedDate,dueDate,returnDate) values ('" + isbn + "','" + bName + "','" + mID + "','" + mName + "','" + issDate + "','" + dueDate + "','"+retDate+"')", con);
            int i = cmdOne.ExecuteNonQuery();
            cmdOne.Dispose();

            if (i == 1)
            {
                txt_mName.Clear();
                txt_memID.Clear();
                txt_isseDate.Clear();
                txt_ISBN.Clear();
                txt_bookName.Clear();
                txt_dueDate.ClearSelection();
                txt_returnDate.Clear();
                lbl_fine.Text = "There is no fine records available";

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

        private void txt_memID_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
