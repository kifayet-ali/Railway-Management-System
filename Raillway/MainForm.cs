using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raillway
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cancellation Cancel = new Cancellation();
            Cancel.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Cancellation Cancel = new Cancellation();
            Cancel.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Reservation Res = new Reservation();
            Res.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Reservation Res = new Reservation();
            Res.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TravelMaster Tr = new TravelMaster();
            Tr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TravelMaster Tr = new TravelMaster();
            Tr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PassengerMaster Ps = new PassengerMaster();
            Ps.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PassengerMaster Ps = new PassengerMaster();
            Ps.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrainMaster Tn = new TrainMaster();
            Tn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TrainMaster Tn = new TrainMaster();
            Tn.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}
