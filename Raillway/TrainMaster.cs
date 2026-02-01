using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace Raillway
{
    public partial class TrainMaster : Form
    {
        private OracleConnection Con = new OracleConnection("User ID=Railway;Password=railway123;Data Source=127.0.0.1:1521/XE;");

        public TrainMaster()
        {
            InitializeComponent();
            populate();
        }

        private void TrainMaster_Load(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM TRAINTBL";
                OracleDataAdapter sda = new OracleDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                TrainDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train data: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string TrStatus = "";

            if (string.IsNullOrWhiteSpace(TrNameTb.Text) || string.IsNullOrWhiteSpace(TrainCapTb.Text))
            {
                MessageBox.Show("Please enter both Train Name and Capacity.");
                return;
            }

            if (BusyRd.Checked)
                TrStatus = "Busy";
            else if (FreeRd.Checked)
                TrStatus = "Available";
            else
            {
                MessageBox.Show("Please select the train status.");
                return;
            }

            try
            {
                Con.Open();
                string Query = "INSERT INTO TRAINTBL (TrainId, TrainName, TrainCap, TrainStatus) VALUES (TRAINID_SEQ.NEXTVAL, :TrainName, :Capacity, :Status)";
                OracleCommand cmd = new OracleCommand(Query, Con);
                cmd.Parameters.Add(new OracleParameter(":TrainName", TrNameTb.Text));
                cmd.Parameters.Add(new OracleParameter(":Capacity", Convert.ToInt32(TrainCapTb.Text)));
                cmd.Parameters.Add(new OracleParameter(":Status", TrStatus));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Train Added Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        private void reset()
        {
            TrNameTb.Text = "";
            TrainCapTb.Text = "";
            BusyRd.Checked = false;
            FreeRd.Checked = false;
            Key = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void TrainDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TrainDGV.Rows[e.RowIndex];

                if (row.Cells[1].Value != null)
                    TrNameTb.Text = row.Cells[1].Value.ToString();
                else
                    TrNameTb.Text = "";

                if (row.Cells[2].Value != null)
                    TrainCapTb.Text = row.Cells[2].Value.ToString();
                else
                    TrainCapTb.Text = "";

                if (row.Cells[0].Value != null && !string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                else
                    Key = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the train to be Deleted.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "DELETE FROM TRAINTBL WHERE TrainId = :TrainId";
                    OracleCommand cmd = new OracleCommand(Query, Con);
                    cmd.Parameters.Add(new OracleParameter("TrainId", Key));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Train Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Database Error: " + Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TrStatus = "";

            if (Key == 0)
            {
                MessageBox.Show("Please select a train to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TrNameTb.Text) || string.IsNullOrWhiteSpace(TrainCapTb.Text))
            {
                MessageBox.Show("Please enter both Train Name and Capacity.");
                return;
            }

            if (BusyRd.Checked)
                TrStatus = "Busy";
            else if (FreeRd.Checked)
                TrStatus = "Available";
            else
            {
                MessageBox.Show("Please select the train status.");
                return;
            }

            try
            {
                Con.Open();
                string Query = "UPDATE TRAINTBL SET TrainName = :TrainName, TrainCap = :Capacity, TrainStatus = :Status WHERE TrainId = :TrainId";
                OracleCommand cmd = new OracleCommand(Query, Con);
                cmd.Parameters.Add(new OracleParameter(":TrainName", TrNameTb.Text));
                cmd.Parameters.Add(new OracleParameter(":Capacity", Convert.ToInt32(TrainCapTb.Text)));
                cmd.Parameters.Add(new OracleParameter(":Status", TrStatus));
                cmd.Parameters.Add(new OracleParameter(":TrainId", Key));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Train Updated Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }
    }
}