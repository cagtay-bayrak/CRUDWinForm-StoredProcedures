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

        }

        private void bunUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
