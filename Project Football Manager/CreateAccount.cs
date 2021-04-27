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
    public partial class CreateAccount : Form
    {
        string strConnect = @"Data Source=LAPTOP-HIEUMM\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public CreateAccount()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Account";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "insert into Account values('"+txtID.Text+"','"+txtPass.Text+"',"+txtID_Player.Text+",'"+cboType.Text+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("Create account Success!!!");
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa"+txtID.Text, "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = conn.CreateCommand();
                command.CommandText = "delete from Account where ID='" + txtID.Text + "' ";
                command.ExecuteNonQuery();
                MessageBox.Show("Delete Success!!!");
                loaddata();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
    }
}
