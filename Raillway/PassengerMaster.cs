using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Raillway
{
    public partial class PassengerMaster : Form
    {
        private OracleConnection Con = new OracleConnection("User ID=Railway;Password=railway123;Data Source=127.0.0.1:1521/XE;");
        public PassengerMaster()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM Passengertbl";
                OracleDataAdapter sda = new OracleDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                PassengerDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train data: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = "";

            if (string.IsNullOrWhiteSpace(PnameTb.Text) || string.IsNullOrWhiteSpace(PPhoneTb.Text) || string.IsNullOrWhiteSpace(PaddressTb.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            if (MaleRd.Checked)
                Gender = "Male";
            else if (FemaleRd.Checked)
                Gender = "Female";
            try
            {
                Con.Open();
                string query = "INSERT INTO PASSENGERTBL (PID, PName, PAdd, PGender, PNat, Pphone) " + "VALUES (PASSENGER_SEQ.NEXTVAL, :PName, :PAdd, :PGender, :PNat, :Pphone)";
                OracleCommand cmd = new OracleCommand(query, Con);
                cmd.Parameters.Add(new OracleParameter(":PName", PnameTb.Text));
                cmd.Parameters.Add(new OracleParameter(":PAdd", PaddressTb.Text));
                cmd.Parameters.Add(new OracleParameter(":PGender", Gender));
                cmd.Parameters.Add(new OracleParameter(":PNat", NatCb.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter(":Pphone", PPhoneTb.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger Added Successfully");
                Con.Close();
                populate();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            PnameTb.Text = "";
            PaddressTb.Text = "";
            PPhoneTb.Text = "";
            MaleRd.Checked = false;
            FemaleRd.Checked = false;
            NatCb.SelectedIndex = -1;
            Key = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int Key = 0;
        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PassengerDGV.Rows[e.RowIndex];

                PnameTb.Text = row.Cells["PName"].Value?.ToString();
                PaddressTb.Text = row.Cells["PAdd"].Value?.ToString();
                PPhoneTb.Text = row.Cells["PPhone"].Value?.ToString();
                NatCb.SelectedItem = row.Cells["PNat"].Value?.ToString();

                string gender = row.Cells["PGender"].Value?.ToString();
                if (gender == "Male") MaleRd.Checked = true;
                else if (gender == "Female") FemaleRd.Checked = true;

                if (row.Cells["PID"].Value != null && int.TryParse(row.Cells["PID"].Value.ToString(), out int id))
                    Key = id;
                else
                    Key = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the passenger to be deleted.");
                return;
            }

            try
            {
                Con.Open();
                string query = "DELETE FROM PASSENGERTBL WHERE PID = :PID";
                OracleCommand cmd = new OracleCommand(query, Con);
                cmd.Parameters.Add(new OracleParameter("PID", Key));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger deleted successfully.");
                Con.Close();
                populate();
                Reset();
                Key = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Gender = "";

            if (Key == 0)
            {
                MessageBox.Show("Please select a passenger to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(PnameTb.Text) || string.IsNullOrWhiteSpace(PPhoneTb.Text) || string.IsNullOrWhiteSpace(PaddressTb.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            if (MaleRd.Checked)
                Gender = "Male";
            else if (FemaleRd.Checked)
                Gender = "Female";
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            try
            {
                Con.Open();
                string query = "UPDATE PASSENGERTBL SET PName = :PName, PAdd = :PAdd, PGender = :PGender, PNat = :PNat, PPhone = :PPhone WHERE PID = :PID";
                OracleCommand cmd = new OracleCommand(query, Con);
                cmd.Parameters.Add(new OracleParameter(":PName", PnameTb.Text));
                cmd.Parameters.Add(new OracleParameter(":PAdd", PaddressTb.Text));
                cmd.Parameters.Add(new OracleParameter(":PGender", Gender));
                cmd.Parameters.Add(new OracleParameter(":PNat", NatCb.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter(":PPhone", PPhoneTb.Text));
                cmd.Parameters.Add(new OracleParameter(":PID", Key));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger updated successfully.");
                Con.Close();
                populate();
                Reset();
                Key = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }
    }
}
