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
    public partial class Infor_Play : Form
    {
        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Player";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Infor_Play()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "delete from Player where ID_player='" + txtID.Text + "' ";
          
            command.ExecuteNonQuery();
            MessageBox.Show("Delete Success!!!");
            loaddata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (isNumber(txtSalry.Text)&& isNumber(txtCLother.Text))
            {
                command = conn.CreateCommand();
                command.CommandText = "update  Player set Name_player='" + txtName.Text + "',Birthday='" + timeDob.Text + "',Country='" + txtCoun.Text + "',Position='" + comboBox1.Text + "',Clothers_number=" + txtCLother.Text + ",Salary=" + txtSalry.Text + ", Start_join='" + timeStart.Text + "', End_join='" + timeEnd.Text + "',Img='" + txtSource.Text + "'   where ID_player=" + txtID.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Update Success!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isNumber(txtSalry.Text) && isNumber(txtCLother.Text))
            {
                command = conn.CreateCommand();
                command.CommandText = "insert into Player values('" + txtName.Text + "','" + timeDob.Text + "','" + txtCoun.Text + "','" + comboBox1.Text + "'," + txtCLother.Text + "," + txtSalry.Text + ",'" + timeEnd.Text + "','" + timeEnd.Text + "','" + txtSource.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Insert Success!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            timeDob.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCoun.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtSalry.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            timeStart.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            timeEnd.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txtCLother.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

            if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "")
            {
                image.Image = Image.FromFile(@"H:\FPTU\Project Football Manager\image\noimg.jpg");
            }
            else
            {
                image.Image = Image.FromFile(dataGridView1.Rows[i].Cells[9].Value.ToString());
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            txtSource.Text = filepath.ToString();

            image.Image = Image.FromFile(filepath.ToString());
        }
    }
}
