using System.Drawing.Text;

namespace Airline_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 82)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
