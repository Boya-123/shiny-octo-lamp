using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railway
{
    public partial class Passengermaster : Form
    {
        public Passengermaster()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DHANANJAY\OneDrive\Documents\RailwayDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            passengerlist.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (passengertb.Text == "" || phonetb.Text == "" || addresstb.Text == "")
            {
                MessageBox.Show("missing info");
            }
            else
            {
                if (malerd.Checked == true)
                {
                    Gender = "Male";


                }
                else if (femaleRd.Checked == true)
                {
                    Gender = "Female";
                }

                try
                {
                    Con.Open();
                    string Query = "insert into PassengerTbl values ('" + passengertb.Text +"','" + addresstb.Text + "','" + Gender + "','" + natcb.Text + "','" + phonetb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger added sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void passengerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passengertb.Text = passengerlist.SelectedRows[0].Cells[1].Value.ToString();
            addresstb.Text = passengerlist.SelectedRows[0].Cells[2].Value.ToString();
            natcb.SelectedItem = passengerlist.SelectedRows[0].Cells[4].Value.ToString();
            phonetb.Text = passengerlist.SelectedRows[0].Cells[5].Value.ToString();
            if (passengertb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(passengerlist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void reset()
        {
            passengertb.Text = string.Empty;
            addresstb.Text = string.Empty;
            natcb.SelectedIndex = 0;
            phonetb.Text = string.Empty;
            malerd.Checked = false;
            femaleRd.Checked = false;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the passenger to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from PassengerTbl where Pid=" + key + "";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger deleted sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (passengertb.Text == "" || phonetb.Text == "" || addresstb.Text == "")
            {
                MessageBox.Show("missing info");
            }
            else
            {
                if (malerd.Checked == true)
                {
                    Gender = "Male";

                }
                else if (femaleRd.Checked == true)
                {
                    Gender = "Female";
                }

                try
                {
                    Con.Open();
                    string Query = "update PassengerTbl set PName='" + passengertb.Text + "',PAdd='" + addresstb.Text + "',PGender='" + Gender + "',PNat='" + natcb.SelectedItem.ToString() + "',Pphone='" + phonetb.Text + "' where Pid=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger updated sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
           




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void Passengermaster_Load(object sender, EventArgs e)
        {

        }
    }
}
