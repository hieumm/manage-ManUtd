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
    public partial class Infor_Coa : Form
    {
        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM     Coach";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Infor_Coa()
        {
            InitializeComponent();
        }

        private void Infor_Coa_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();
            txtSearch.Text = "Search by name;";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "delete from Coach where Coach_ID='" + txtID.Text + "' ";
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Success!!!");
            loaddata();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string x = txtSalary.Text;
            int value;
            if (int.TryParse(x, out value) && value > 0)
            {
                command = conn.CreateCommand();
                command.CommandText = "insert into Coach values('" + txtName.Text + "','" + txtPos.Text + "','" + txtCountry.Text + "','" + timeStart.Text + "','" + timeEnd.Text + "','" + txtSalary.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Insert Success!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            string x = txtSalary.Text;
            int value;
            if (int.TryParse(x, out value) && value > 0)
            {
                command = conn.CreateCommand();
                command.CommandText = "update  Coach set Coach_Name='" + txtName.Text + "',Position='" + txtPos.Text + "',Country='" + txtCountry.Text + "',Start_join='" + timeStart.Text + "',End_join='" + timeEnd.Text + "',Salary=" + txtSalary.Text + " where Coach_ID=" + txtID.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Update Success!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Coach WHERE Coach_Name LIKE N'%" + txtSearch.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPos.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            timeStart.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            timeEnd.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
