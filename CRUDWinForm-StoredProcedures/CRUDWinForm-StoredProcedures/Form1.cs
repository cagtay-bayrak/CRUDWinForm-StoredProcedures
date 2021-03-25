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
                SqlCommand com = new SqlCommand("exec dbo.SP_Product_Insert '" + int.Parse(txtProductid.Text) + "', '" + txtitemname.Text + "', '" + cbocolor.Text + "', '" + txtAddress.Text + "', '" + status + "' ", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
                
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


         
    }
}
