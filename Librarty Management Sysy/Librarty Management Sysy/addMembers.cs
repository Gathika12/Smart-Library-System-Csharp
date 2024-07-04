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
    public partial class addMembers : Form
    {
        public addMembers()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 10;
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

        private void btn_meembers_Click(object sender, EventArgs e)
        {
            this.Close();
            Members mb = new Members();
            mb.Show();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            String NIC = txt_nic.Text;
            String Name = txt_name.Text;
            string ID = txt_id.Text;
            String email = txt_email.Text;
            String telephone = txt_telephone.Text;
            String dob = txt_dob.Text;
            String gender = cmb_gender.Text;
            String address = txt_address.Text;

            String username = txt_username.Text;
            String password = txt_password.Text;

            if(!Regex.IsMatch(NIC, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lbl_invalidNIC.Visible = true;
            }else if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                lbl_invalidEmail.Visible = true;
            }else if (!Regex.IsMatch(telephone, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                lbl_invalidTelephone.Visible = true;
            }/*else if (!Regex.IsMatch(dob, @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$"))
            {
                lbl_invalidDOB.Visible = true;
            }*/else if (password.Length>10)
            {
                lbl_invalidPass.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                con.Open();
                SqlCommand cmdOne = new SqlCommand("insert into members (nicNumber, memberName, emailAddress, telephoneNumber, dob, gender, mAddress) values ('" + NIC + "','" + Name + "','" + email + "','" + telephone + "','" + dob + "','" + gender + "','" + address + "')", con);
                int i = cmdOne.ExecuteNonQuery();
                cmdOne.Dispose();

                SqlCommand cmdTwo = new SqlCommand("insert into users values ('" + username + "','" + password + "','ma')", con);
                int ii = cmdTwo.ExecuteNonQuery();

                if (i == 1 && ii == 1)
                {
                    txt_address.Clear();
                    txt_dob.Clear();
                    txt_id . Clear();
                    txt_email.Clear();
                    txt_name.Clear();
                    txt_nic.Clear();
                    txt_password.Clear();
                    txt_telephone.Clear();
                    txt_username.Clear();
                    

                    Sucess suc = new Sucess();
                    suc.ShowDialog();
                }
                else
                {
                    error404F err = new error404F();
                    err.ShowDialog();
                }

                cmdTwo.Dispose();

                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_dob.Clear();
            txt_email.Clear();
            txt_name.Clear();
            txt_nic.Clear();
            txt_password.Clear();
            txt_telephone.Clear();
            txt_username.Clear();

            lbl_invalidTelephone.Visible = false;
            lbl_invalidPass.Visible = false;
            lbl_invalidNIC.Visible = false;
            lbl_invalidEmail.Visible = false;
            lbl_invalidDOB.Visible = false;
        }

        private void addMembers_Load(object sender, EventArgs e)
        {
            lbl_invalidTelephone.Visible = false;
            lbl_invalidPass.Visible = false;
            lbl_invalidNIC.Visible = false;
            lbl_invalidEmail.Visible = false;
            lbl_invalidDOB.Visible = false;
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txt_telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
