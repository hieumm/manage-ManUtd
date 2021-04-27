using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Hello : Form
    {
        string strConnect = @"Data Source=DESKTOP-2VI451C;Initial Catalog=Football;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;



        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (btnMember.Checked)
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                string sql = "SELECT count(*) from Account where ID=@acc and Pass=@pass and Type='user'";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtUser.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPass.Text));
                int x = (int)command.ExecuteScalar();//lấy ra số lượng giá trị câu lệnh sql tìm được
                if (x == 1)
                {
                    Information_User f = new Information_User(txtUser.Text);//để truyền dữ liệu sang form Infor User
                    MessageBox.Show("You choser member");
                    this.Hide();
                    f.ShowDialog();
                }
                else { MessageBox.Show("Login fail"); }
            }


            if (btnManager.Checked)
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                string sql = "SELECT count(*) from Account where ID=@acc and Pass=@pass and Type='admin' ";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtUser.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPass.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    Manager f1 = new Manager();
                    MessageBox.Show("You chose manager");
                    this.Hide();
                    f1.ShowDialog();
                }
                else { MessageBox.Show("Login fail"); }

            }
        }
    }
}
