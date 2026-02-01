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
using Oracle.ManagedDataAccess.Client;

namespace Raillway
{

    public partial class TravelMaster : Form
    {
        private OracleConnection Con = new OracleConnection("User ID=Railway;Password=railway123;Data Source=127.0.0.1:1521/XE;");
        public TravelMaster()
        {
            InitializeComponent();
            populate();
            FillTCode();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ChangeStatus()
        {
            string TrStatus = "Busy";

            try
            {
                Con.Open();
                string Query = "UPDATE TRAINTBL SET TrainStatus = :Status WHERE TrainId = :TrainId";
                OracleCommand cmd = new OracleCommand(Query, Con);
                cmd.Parameters.Add(new OracleParameter(":Status", TrStatus));
                cmd.Parameters.Add(new OracleParameter(":TrainId", Convert.ToInt32(TCode.SelectedValue)));

                cmd.ExecuteNonQuery();
                Con.Close();
                populate();
                Reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(TCostTb.Text) || TCode.SelectedIndex == -1 || SrcCb.SelectedIndex == -1 || DestCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            try
            {
                Con.Open();
                string query = "INSERT INTO TRAVELTBL (TravCode, TravDate, Train, Src, Dest, Cost) " +
                               "VALUES (TRAVEL_SEQ.NEXTVAL, :TravDate, :TrainId, :Src, :Dest, :Cost)";

                OracleCommand cmd = new OracleCommand(query, Con);
                cmd.Parameters.Add(new OracleParameter(":TravDate", TravDate.Value));
                cmd.Parameters.Add(new OracleParameter(":TrainId", TCode.SelectedValue));
                cmd.Parameters.Add(new OracleParameter(":Src", SrcCb.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter(":Dest", DestCb.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter(":Cost", Convert.ToDecimal(TCostTb.Text)));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Travel Added Successfully");
                Con.Close();
                populate();
                ChangeStatus();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }

        }
        
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM TRAVELTBL";
                OracleDataAdapter sda = new OracleDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                TravelDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train data: " + ex.Message);
            }
        }
        private void FillTCode()
        {
            string TrStatus = "Available";
            Con.Open();
            string query = "SELECT TrainId FROM TRAINTBL WHERE TrainStatus = :Status";
            OracleCommand cmd = new OracleCommand(query, Con);
            cmd.Parameters.Add(new OracleParameter(":Status", TrStatus));
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TrainId";
            TCode.DataSource = dt;
            Con.Close();
        }
        private void TravelMaster_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            SrcCb.SelectedIndex = -1;
            DestCb.SelectedIndex = -1;
            TCostTb.Text = "";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (SrcCb.SelectedIndex == -1 || DestCb.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TCostTb.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE TRAVELTBL SET TravDate = :TravDate, Train = :Train, Src = :Src, Dest = :Dest, Cost = :Cost WHERE TravCode = :TravCode";
                    OracleCommand cmd = new OracleCommand(query, Con);
                    cmd.Parameters.Add(new OracleParameter(":TravDate", TravDate.Value));
                    cmd.Parameters.Add(new OracleParameter(":Train", TCode.SelectedValue));
                    cmd.Parameters.Add(new OracleParameter(":Src", SrcCb.SelectedItem.ToString()));
                    cmd.Parameters.Add(new OracleParameter(":Dest", DestCb.SelectedItem.ToString()));
                    cmd.Parameters.Add(new OracleParameter(":Cost", Convert.ToDecimal(TCostTb.Text)));
                    cmd.Parameters.Add(new OracleParameter(":TravCode", Key));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Travel updated successfully.");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        int Key = 0;
        private void TravelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TravelDGV.Rows[e.RowIndex];

                if (row.Cells["TravDate"].Value != DBNull.Value)
                    TravDate.Value = Convert.ToDateTime(row.Cells["TravDate"].Value);

               
                if (row.Cells["Train"].Value != DBNull.Value)
                    TCode.SelectedValue = row.Cells["Train"].Value;

                
                if (row.Cells["Src"].Value != DBNull.Value)
                    SrcCb.SelectedItem = row.Cells["Src"].Value.ToString();

                
                if (row.Cells["Dest"].Value != DBNull.Value)
                    DestCb.SelectedItem = row.Cells["Dest"].Value.ToString();

                
                if (row.Cells["Cost"].Value != DBNull.Value)
                    TCostTb.Text = row.Cells["Cost"].Value.ToString();

                
                if (row.Cells["TravCode"].Value != DBNull.Value && int.TryParse(row.Cells["TravCode"].Value.ToString(), out int id))
                    Key = id;
                else
                    Key = 0;
            }
        }

        private void SrcCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TCostTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }
    }
}
