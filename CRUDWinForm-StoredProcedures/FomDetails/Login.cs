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
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter user Name and Password");
                }

                else
                {
                    SqlCommand cmd = new SqlCommand("select * from Login where UserName=@Name and UserPassword=@Passw", con);
                    cmd.Parameters.Add("@Name", txtUserName.Text);
                    cmd.Parameters.Add("@UserPassword", txtPassword.Text);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count > 0)
                    {
                        MessageBox.Show("Logged In");
                    }
                    else
                    {
                        MessageBox.Show("Please enter user Name and Password");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
