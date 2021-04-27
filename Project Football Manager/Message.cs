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
    
    public partial class Message : Form
    {
        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                conn = new SqlConnection(strConnect);
                
                String time = DateTime.Now.ToShortDateString();
                command = conn.CreateCommand();
                command.CommandText = "insert into Message values(N'" + txtMess.Text + "','" + time + "')";
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                     MessageBox.Show("Thank you for góp í!!!");
               
            }
            catch(Exception g)
            {
                MessageBox.Show("Error" + g.Message);
            }
            
            
        }
    }
}
