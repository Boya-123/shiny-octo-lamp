using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railway
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void TrainMaster_Click(object sender, EventArgs e)
        {
            TrainMaster trainMaster = new TrainMaster();
            trainMaster.Show();
            this.Hide();    
        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();    
            reservation.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passengermaster passengermaster = new Passengermaster();    
            passengermaster.Show();
            this.Hide();
        }

        private void TravelMaster_Click(object sender, EventArgs e)
        {
            TravelMaster travelmaster = new TravelMaster(); 
            travelmaster.Show();
            this.Hide();
        }

        private void Cancellation_Click(object sender, EventArgs e)
        {
            Cancellation cancellation = new Cancellation();
            cancellation.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
