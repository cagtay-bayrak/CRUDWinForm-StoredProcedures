using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FomDetails
{
    public partial class RegistrationForms : Form
    {


        string path = @"Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;


        public RegistrationForms()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void RegistrationForms_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtfname.Text == "" || txtDesign.Text == "" || txteMail.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("selected data");
            }

            else
            {

                try
                {

                    string Gender;
                    if (rdoMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@Name,@Fname,@Design,@eMail,@Emp_ID,@Gender,@Address)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Fname", txtfname.Text);
                    cmd.Parameters.AddWithValue("@Design", txtDesign.Text);
                    cmd.Parameters.AddWithValue("@eMail", txteMail.Text);
                    cmd.Parameters.AddWithValue("@Emp_ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("new user added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void bunUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtName.Clear();
            txtfname.Clear();
            txtDesign.Clear();
            txteMail.Clear();
            txtID.Clear();
            txtAddress.Clear();

        }
    }
}
