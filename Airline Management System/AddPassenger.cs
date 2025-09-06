using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Airline_Management_System
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ZADID13\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True;");

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTbl values(" + PassId.Text + ",'" + PassName.Text + "','" + PassportTb.Text + "','" + PassAd.Text + "','" + NationalityCb.SelectedItem.ToString() + "','" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PassAd.Text = "";
            PhoneTb.Text = "";
            NationalityCb.SelectedIndex = -1; 
            GenderCb.SelectedIndex = -1;
        }

        private void NationalityCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
