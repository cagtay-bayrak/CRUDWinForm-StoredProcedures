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

        private void btnInsert_Click(object sender, EventArgs e)
        {

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
    }
}
