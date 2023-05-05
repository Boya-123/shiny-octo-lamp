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
    public partial class TravelMaster : Form
    {
        public TravelMaster()
        {
            InitializeComponent();
            populate();
            FillTrainCode();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DHANANJAY\OneDrive\Documents\RailwayDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from TravelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            travellist.DataSource = ds.Tables[0];
            Con.Close();
        }

  
        private void FillTrainCode()
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TrainTbl ",Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId",typeof(int));
            dt.Load(reader);
            trainC.ValueMember = "TrainId";
            trainC.DataSource = dt;
            Con.Close();

        }
        private void TravelMaster_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    
        private void changestatus()
        {
            string TrStatus = "Busy";
            
            {
                
                try
                {
                    Con.Open();
                    string Query = "update TrainTbl set  TrainStatus='" + TrStatus + "' where TrainId=" + trainC.SelectedValue.ToString() + ";";
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

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (Costtb.Text == "" || srcCb.SelectedIndex == -1 || DestiCb.SelectedIndex == -1 || trainC.SelectedIndex == -1)
            {
                MessageBox.Show("missing info");
            }
            else
            {

                try
                {
                    

                        Con.Open();
                        
                    

                
                    string Query = "insert into TravelTbl values ('" + dt.Value + "','" + trainC.SelectedValue.ToString() + "','" + srcCb.SelectedIndex.ToString() + "','" + DestiCb.SelectedIndex.ToString() + "','" + Costtb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("travel added sucessfully");
                    Con.Close();
                    populate();
                    reset();
                    changestatus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void reset()
        {
            srcCb.SelectedIndex = -1;
            DestiCb.SelectedIndex = -1;
            trainC.SelectedIndex = -1;
            Costtb.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }
        
    
           
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (srcCb.SelectedIndex == -1 || Costtb.Text == "" || DestiCb.SelectedIndex == -1)
            {
                MessageBox.Show("missing info");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    string Query = "update TravelTbl set TravDate='" + dt.Text + "',Train='" + trainC.SelectedValue.ToString() + "',Src='" + srcCb.SelectedItem.ToString() + "',Dest='" + DestiCb.SelectedItem.ToString() + "',Cost='" + Costtb.Text + "' where TravCode=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("travel updated sucessfully");
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
        private void travellist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dt.Text = travellist.SelectedRows[0].Cells[1].Value.ToString();
            trainC.SelectedValue = travellist.SelectedRows[0].Cells[2].Value.ToString();
            srcCb.SelectedItem = travellist.SelectedRows[0].Cells[3].Value.ToString();
            DestiCb.SelectedValue = travellist.SelectedRows[0].Cells[4].Value.ToString();
            Costtb.Text = travellist.SelectedRows[0].Cells[5].Value.ToString();

            if (trainC.SelectedIndex == -1)
            {
                key = 0;
                Costtb.Text = "";
                srcCb.SelectedIndex = -1;
                DestiCb.SelectedIndex = -1;
            }
            else
            {
                key = Convert.ToInt32(travellist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
