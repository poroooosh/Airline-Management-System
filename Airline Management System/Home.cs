using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            AddPassenger Pass = new AddPassenger();
            Pass.Show();
            this.Hide();
        }



        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            CancellationTbl Can = new CancellationTbl();
            Can.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton23_Click_1(object sender, EventArgs e)
        {
            Ticket tick = new Ticket();
            tick.Show();
            this.Hide();
        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            AddPassenger Pass = new AddPassenger();
            Pass.Show();
            this.Hide();
        }
    }
}
