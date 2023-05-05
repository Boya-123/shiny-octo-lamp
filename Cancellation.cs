using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railway
{
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
            populate();
            FillTicketCode();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DHANANJAY\OneDrive\Documents\RailwayDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from CancellationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            CanList.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void FillTicketCode()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("select TicketId from CancellationTbl ", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId", typeof(int));
            dt.Load(reader);
            Cantb.ValueMember = "TicketId";
            Cantb.DataSource = dt;
            Con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cantb.SelectedIndex == -1)
            {
                MessageBox.Show("missing info");
            }
            else
            {


                try
                {
                    Con.Open();
                    string Query = "insert into CancellationTbl values ('" + Cantb.SelectedValue.ToString() + "','" + DateTime.Today.Date + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket cancelled");
                    Con.Close();
                    populate();
                    remove();
                    FillTicketCode();
                    Cantb.SelectedIndex = -1;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void remove()
        {

            try
            {
                Con.Open();
                string Query = "Delete from ReservationTbl where TicketId=" + Cantb.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Cancellation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }
    }
}
    

