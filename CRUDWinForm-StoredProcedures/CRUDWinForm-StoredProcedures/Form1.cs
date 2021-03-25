using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm_StoredProcedures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllRecords();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                string status = "";

                if (rdoStatus.Checked == true)
                {
                    status = rdoStatus.Text;

                }

                else
                {
                    status = rdoRunning.Text;
                }
                SqlCommand com = new SqlCommand("exec dbo.SP_Product_Insert '" + int.Parse(txtProductid.Text) + "', '" + txtitemname.Text + "', '" + cbocolor.Text + "', '" + status + "', '" + txtAddress.Text + "' ", con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved");
                LoadAllRecords();


            }
            catch (Exception)
            {

                throw;
            }
        }

        void LoadAllRecords()
        {

            SqlCommand com = new SqlCommand("exec dbo.SP_Product_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView1.Sort(this.dataGridView1.Columns["ProductID"], ListSortDirection.Descending);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string status = "";

                if (rdoStatus.Checked == true)
                {
                    status = rdoStatus.Text;

                }

                else
                {
                    status = rdoRunning.Text;
                }
                SqlCommand com = new SqlCommand("exec dbo.SP_Product_Update '" + int.Parse(txtProductid.Text) + "', '" + txtitemname.Text + "', '" + cbocolor.Text + "', '" + status + "', '" + txtAddress.Text + "' ", con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated");
                LoadAllRecords();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductid.Text == "")
                {
                    MessageBox.Show("Enter Registration Number");
                }


                else if (MessageBox.Show("Are you confirm to delete", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand com = new SqlCommand("exec dbo.SP_Product_Delete '" + int.Parse(txtProductid.Text) + "' ", con);

                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Records Deleted");
                    LoadAllRecords();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProductid.Text == "")
            {
                MessageBox.Show("Enter Registration Number");
            }

            else
            {

                SqlCommand com = new SqlCommand("exec dbo.SP_Product_Search '" + int.Parse(txtProductid.Text) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void grptransactions_Enter(object sender, EventArgs e)
        {

        }
    }
}
