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
using System.Text.RegularExpressions;

namespace Airline_Management_System
{
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ZADID13\SQLEXPRESS;Initial Catalog=AirlineDb;Integrated Security=True;");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            FlightDGV.ColumnHeadersVisible = true;
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTbl Addfl = new FlightTbl();
            Addfl.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Seatnum.Text = "";

        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DstCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
            Seatnum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set Fsrc=@Fsrc, FDest=@FDest, FDate=@FDate, Fcap=@Fcap where Fcode=@Fcode;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Fsrc", SrcCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FDest", DstCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FDate", FDate.Value.Date.ToString());
                    cmd.Parameters.AddWithValue("@Fcap", Seatnum.Text);
                    cmd.Parameters.AddWithValue("@Fcode", FcodeTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message); // Display the actual exception message
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
