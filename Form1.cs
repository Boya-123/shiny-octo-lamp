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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || password.Text == "")
            {
                MessageBox.Show("enter username and password");
            }else if(username.Text == "admin" &&  password.Text == "dhan311") 
            {
                Mainform Main = new Mainform(); 
                Main.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("invalid username and password");
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
