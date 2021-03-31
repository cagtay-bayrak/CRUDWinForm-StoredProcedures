using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FomDetails
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "" || txtPassw.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand("select * from Login where UserName=@Name and UserPassword=@Passw", con);
                cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Passw", txtPassw.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                  
                    Form1 fm = new Form1();
                    this.Hide();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
