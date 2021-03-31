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
        SqlDataAdapter adp;
        DataTable dt;
        int ID;


        public RegistrationForms()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
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

                    cmd = new SqlCommand("INSERT INTO Employee VALUES (@Name,@Fname,@Design,@eMail,@Emp_ID,@Gender,@Address)", con);
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
                    display();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void bunUpdate_Click(object sender, EventArgs e)
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
                cmd = new SqlCommand("update Employee set Name ='" + txtName.Text + "', Fname ='" + txtfname.Text + "', Design ='" + txtDesign.Text + "', eMail ='" + txteMail.Text + "', Emp_ID ='" + txtID.Text + "',Gender ='" + Gender + "', Address ='" + txtAddress.Text + "' where EmployeeID = '"+ID+"' ",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adp = new SqlDataAdapter("select * from Employee", con);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDesign.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txteMail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            rdoMale.Checked = true;
            rdoFemale.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Female")
            {
                rdoMale.Checked = false;
                rdoFemale.Checked = true;
            }
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
