using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class QuayHang : Form
    {
        public QuayHang()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllProduceline().Tables[0];
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        DataSet GetAllProduceline(){

            DataSet data = new DataSet();

            string query = "SELECT * FROM QuayHang";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
