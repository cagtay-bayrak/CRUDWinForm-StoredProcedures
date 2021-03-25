using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SelectedGridCrud
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetStudentRecord()
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
            using (connection)
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.CommandText = "select * from Students";

                        cmd.Connection = connection;
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            reader.Close();
                        }

                        else
                        {
                            MessageBox.Show("Not Found!");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    finally
                    {

                        connection.Close();

                    }


                }

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {


                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES (@Name,@FatherName,@RollNumber,@Address,@Mobile)", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("new user added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



      

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }



    }
}
