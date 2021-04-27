using System;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Infor_Play f = new Infor_Play();

            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Infor_Coa f = new Infor_Coa();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Infor_Match f = new Infor_Match();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Infor_finan f = new Infor_finan();
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ShowMess f = new ShowMess();
            f.Show();
        }

        private void btnCreateAcount_Click(object sender, EventArgs e)
        {
            CreateAccount f = new CreateAccount();
            f.Show();
        }
    }
}
