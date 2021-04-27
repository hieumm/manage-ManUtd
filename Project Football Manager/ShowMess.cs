using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class ShowMess : Form
    {
        string strConnect = @"Data Source=LAPTOP-HIEUMM\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "select *from Message ORDER BY Time Asc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public ShowMess()
        {
            InitializeComponent();
        }

        private void ShowMess_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMess.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMess.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            
        }
    }
}
