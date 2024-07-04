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
using System.Text.RegularExpressions;

namespace Librarty_Management_Sysy
{
    public partial class Reserve_Book : Form
    {

        public Reserve_Book()
        {
            InitializeComponent();
        }

        //search button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

          
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM book WHERE boolkName='"+txt_search.Text+"'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;

            
            con.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_author.Clear();
            txt_bookName.Clear();
            txt_dateCollect.Clear();
            txt_isbn.Clear();
            txt_memberID.Clear();
            txt_memberName.Clear();

            lbl_invalidDate.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.libraryManagementDataSet.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Reserve_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryManagementDataSet.book);
            lbl_invalidDate.Visible = false;
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            String ISBN = txt_isbn.Text;
            String bookName = txt_bookName.Text;
            String bookAuthor = txt_author.Text;
            String mID = txt_memberID.Text;
            String mName = txt_memberName.Text;
            String colDate = txt_dateCollect.Text;

            if (!Regex.IsMatch(colDate, @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$"))
            {
                lbl_invalidDate.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                con.Open();
                SqlCommand cmdOne = new SqlCommand("insert into reservations (isbn,bookName,bookAuthor,memberID,memberName,dateCollecting) values ('"+ISBN+"','"+bookName+"','"+bookAuthor+"','"+mID+"','"+mName+"','"+colDate+"')", con);
                int i = cmdOne.ExecuteNonQuery();
                cmdOne.Dispose();

                if (i == 1)
                {
                    txt_author.Clear();
                    txt_bookName.Clear();
                    txt_dateCollect.Clear();
                    txt_isbn.Clear();
                    txt_memberID.Clear();
                    txt_memberName.Clear();

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
    }
}
