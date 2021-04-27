using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Football_Manager
{
    public partial class Infor_finan : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UVMCLH1\SQLEXPRESS;Initial Catalog=Football;Integrated Security=True");

        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Infor_finan()
        {
            InitializeComponent();
        }
        private void Infor_finan_Load(object sender, EventArgs e)
        { }



        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM     Finance", conn);
                conn.Open();
                da.Fill(dt);
                conn.Close();
                MessageBox.Show("THANH CONG");

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Season";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Money";
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart1.Series.Add("player'stotalsalary");
                chart1.Series.Add("hlv total salary");
                chart1.Series.Add("sell players");
                chart1.Series.Add("buy players");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["totalspending"].Points.AddXY(dt.Rows[i]["Season"], dt.Rows[i]["totalspending"]);
                    chart1.Series["player'stotalsalary"].Points.AddXY(dt.Rows[i]["Season"], dt.Rows[i]["player'stotalsalary"]);
                    chart1.Series["hlv total salary"].Points.AddXY(dt.Rows[i]["Season"], dt.Rows[i]["hlv total salary"]);
                    chart1.Series["sell players"].Points.AddXY(dt.Rows[i]["Season"], dt.Rows[i]["sell players"]);
                    chart1.Series["buy players"].Points.AddXY(dt.Rows[i]["Season"], dt.Rows[i]["buy players"]);


                }



            }
            catch (Exception exp) { throw exp; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Inser_Finance i = new Inser_Finance();
            i.Show();
        }



    }
}
