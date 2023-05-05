using System;
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
    public partial class TrainMaster : Form
    {
        public TrainMaster()
        {
            InitializeComponent();
            populate();
        }
SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DHANANJAY\OneDrive\Documents\RailwayDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from TrainTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            var ds = new DataSet();
            sda.Fill(ds);
            trainlist.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string TrStatus = "";
            if (TrNameTb.Text == "" || TrainCapTb.Text == "")
            {
                MessageBox.Show("missing info");
            }
            else
            {
                if(BusyRd.Checked == true)
                {
                    TrStatus = "busy";

                }else if(AvailableRd.Checked == true)
                {
                    TrStatus = "available";
                }

                try
                {
                    Con.Open();
                    string Query = "insert into TrainTbl values('"+TrNameTb.Text+"',"+TrainCapTb.Text+",'"+TrStatus+"')";
                    SqlCommand cmd = new SqlCommand(Query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("train added sucessfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            TrNameTb.Text = trainlist.SelectedRows[0].Cells[1].Value.ToString();
            TrainCapTb.Text = trainlist.SelectedRows[0].Cells[2].Value.ToString();
            if (TrNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(trainlist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e, TextBox TrNameTb)
        {
           

        }
        private void reset()
        {
            TrNameTb.Text = string.Empty;
            TrainCapTb.Text = string.Empty;
            BusyRd.Checked = false;
            AvailableRd.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key== 0)
            {
                MessageBox.Show("select the train to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from TrainTbl where TrainId=" + key + "";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("train deleted sucessfully");
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
            string TrStatus = "";
            if (TrNameTb.Text == "" || TrainCapTb.Text == "")
            {
                MessageBox.Show("missing info");
            }
            else
            {
                if (BusyRd.Checked == true)
                {
                    TrStatus = "busy";

                }
                else if (AvailableRd.Checked == true)
                {
                    TrStatus = "available";
                }

                try
                {
                    Con.Open();
                    string Query = "update TrainTbl set TrainName='"+TrNameTb.Text+"',TrainCap="+TrainCapTb.Text+",TrainStatus='"+TrStatus+"' where TrainId="+key+";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("train updated sucessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }
    }
}
