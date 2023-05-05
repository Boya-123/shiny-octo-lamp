using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railway
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            populate();
            FillTrainCode();
            FillPid();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DHANANJAY\OneDrive\Documents\RailwayDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from ReservationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            reservationTb.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void FillPid()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("select Pid from PassengerTbl ", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Pid", typeof(int));
            dt.Load(reader);
            pidCb.ValueMember = "Pid";
            pidCb.DataSource = dt;
            Con.Close();

        }
        private void FillTrainCode()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("select TravCode from TravelTbl ", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TravCode", typeof(int));
            dt.Load(reader);
            TrcCb.ValueMember = "TravCode";
            TrcCb.DataSource = dt;
            Con.Close();

        }
        string pname;
        private void GetPname()
        {
            Con.Open();
            string mysql = "select * from PassengerTbl where Pid=" + pidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PName"].ToString();   

            }
            Con.Close() ;
        }
        string Date, Src, Dest;
        int Cost;
        private void GetTravel()
        {
            Con.Open();
            string mysql = "select * from TravelTbl where TravCode=" + TrcCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Date= dr["TravDate"].ToString();
                Src = dr["Src"].ToString();
                Dest = dr["Dest"].ToString();
                Cost = Convert.ToInt32(dr["Cost"].ToString());
            }
            Con.Close();
            MessageBox.Show(Date+Src+Dest+Cost);
        }
        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void TrcCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTravel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pidCb.SelectedIndex == -1 || TrcCb.SelectedIndex == -1)
            {
                MessageBox.Show("missing info");
            }
            else
            {
                

                try
                {
                    Con.Open();
                    string Query = "insert into ReservationTbl values ('" + pidCb.SelectedValue.ToString() + "','" + pname + "','" + TrcCb.SelectedValue.ToString() + "','" + Date + "','" + Src + "','"+Dest+"','"+Cost+"')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("reservation Accepted");
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
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show(pname);
            GetPname();
        }
    }
}
