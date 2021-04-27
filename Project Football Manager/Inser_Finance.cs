using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Project_Football_Manager
{
    public partial class Inser_Finance : Form
    {
        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM     Finance";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Inser_Finance()
        {
            InitializeComponent();
        }

        private bool isNumber(string s)
        {
            int value;
            if (int.TryParse(s, out value) && value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isNumber(txtBuy.Text) && isNumber(txtCSalary.Text) && isNumber(txtPsalary.Text) && isNumber(txtSell.Text) && isNumber(txtTotal.Text))
            {
                command = conn.CreateCommand();
                command.CommandText = "insert into Finance values('" + txtSeason.Text + "'," + txtTotal.Text + "," + txtPsalary.Text + "," + txtCSalary.Text + "," + txtSell.Text + "," + txtBuy.Text + ")";
                command.ExecuteNonQuery();
                MessageBox.Show("Insert Success!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi dữ liệu");
            }

           
        }

        private void Inser_Finance_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();

        }

    

        

       

    }
}


