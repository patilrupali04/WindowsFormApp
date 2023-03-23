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

namespace GridViewTable
{
    public partial class Form1 : Form
    {
        string conectionString = @"Data Source=DESKTOP-RKENVIH\SQLEXPRESS; Initial Catalog =Test; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "Select * from Employee";
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
        }
    }
}
