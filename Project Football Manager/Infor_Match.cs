using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Infor_Match : Form
    {

        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM     Match";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Infor_Match()
        {
            InitializeComponent();
        }

        private void Infor_Match_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtVs.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            time.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtStadium.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "insert into Match values('" + time.Text + "','" + txtVs.Text + "','" + txtStadium.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "update  Match set Date='" + time.Text + "',VS='" + txtVs.Text + "',Stadium='" + txtStadium.Text + "' where VS='" + txtVs.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Match WHERE VS LIKE N'%" + txtVs.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
