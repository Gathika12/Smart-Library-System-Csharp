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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addBook_Click(object sender, EventArgs e)
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
            txt_author.Clear();
            txt_bookName.Clear();
            txt_description.Clear();
            txt_isbn.Clear();
            txt_publication.Clear();
            txt_qty.Clear();
            lbl_invlidInput.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String isbn = txt_isbn.Text;
            String name = txt_bookName.Text;
            String author = txt_author.Text;
            String des = txt_description.Text;
            String publication = txt_publication.Text;
            int qty = Convert.ToInt32(txt_qty.Text);
            String cat = cmbx_cat.Text;

            if (qty < 1)
            {
                lbl_invlidInput.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                con.Open();
                SqlCommand cmdOne = new SqlCommand("insert into book values ('" + isbn + "','" + name + "','" + author + "','" + cat + "','" + publication + "'," + qty + ",'" + des + "')", con);
                int i = cmdOne.ExecuteNonQuery();
                cmdOne.Dispose();

                if (i == 1)
                {
                    txt_author.Clear();
                    txt_bookName.Clear();
                    txt_description.Clear();
                    txt_isbn.Clear();
                    txt_publication.Clear();
                    txt_qty.Clear();
                    lbl_invlidInput.Visible = false;

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
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            lbl_invlidInput.Visible = false;
        }
    }
}
