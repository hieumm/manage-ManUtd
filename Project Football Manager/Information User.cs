using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Information_User : Form
    {
        private string _message;
        string strConnect = @"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;


        public Information_User()
        {
            InitializeComponent();
        }
        //lấy dữ liệu truyền sang từ form hello
        public Information_User(string Message) : this()
        {
            _message = Message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Information_User_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label4.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            conn = new SqlConnection(strConnect);
            conn.Open();
            string sql = "SELECT top 1 Player.Name_player, Player.Salary, Player.Start_join, Player.End_join,Player.Img, Match.*FROM Account INNER JOIN Player ON Account.ID_player = Player.ID_player CROSS JOIN Match where Account.ID = @acc and Date>= @date ORDER BY Date Asc";
            command = new SqlCommand(sql, conn);
            command.Parameters.Add(new SqlParameter("@acc", _message));
            command.Parameters.Add(new SqlParameter("@date", DateTime.Now.ToShortDateString()));
            SqlDataReader da = command.ExecuteReader();

            while (da.Read())
            {
               label1.Text = "XIN CHÀO: " + da.GetValue(0).ToString();
                label2.Text = "YOUR SALARY \n " + da.GetValue(1).ToString();
                label3.Text = "Thời hạn hợp đồng: \n" + da.GetValue(2).ToString().Substring(0, 9) + "-" + da.GetValue(3).ToString().Substring(0, 9);
                imagePlayer.Image = Image.FromFile(da.GetValue(4).ToString());
                label5.Text = "Next match: " + da.GetValue(5).ToString().Substring(0, 10) + " VS " + da.GetValue(6).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message m = new Message();
            m.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
