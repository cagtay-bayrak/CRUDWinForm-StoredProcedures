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
                    con.Open();
                    cmd = new SqlCommand("insert into Employee (Name,Fname,Design,eMail,Emp_ID,Gender,Address) values ('" + txtName.Text + "','" + txtfname.Text + "','" + txtDesign.Text + "''" + txteMail.Text + "''" + txtID.Text + "''" + Gender + "''" + txtAddress.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("You Data has saved");
                }
                catch (Exception ex)
                {

                    //MessageBox.Show(ex.Message);
                }


            }
        }

        private void bunUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
