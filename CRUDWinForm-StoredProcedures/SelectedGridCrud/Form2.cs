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

        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
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
                GetStudentRecord();
                clearForm();
            }
        }






        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Name=@Name, FatherName=@FatherName,RollNumber=@RollNumber,Address=@Address,Mobile=@Mobile WHERE StudentID = @ID", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User Upadted", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                clearForm();
            }

            else
            {
                MessageBox.Show("please select registration", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (StudentID > 0)
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID = @ID", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                clearForm();
            }

            else
            {
                MessageBox.Show("please select registration", "delete?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearForm();

        }

        private void clearForm()
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtRollNumber.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
        }


        //dataGridView1 de seçilen kayıt texboxlarda yazar. form dataGridView1 selectionmode özelliği FullRowSelect yapıldı
        public int StudentID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
