using System;
using System.Collections;
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
    public partial class Reservation : Form
    {
        private OracleConnection Con = new OracleConnection("User ID=Railway;Password=railway123;Data Source=127.0.0.1:1521/XE;");
        public Reservation()
        {
            InitializeComponent();
            populate();
            FillPid();
            FillTravCode();
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM RESERVATIONTBL";
                OracleDataAdapter sda = new OracleDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ReservationDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train data: " + ex.Message);
            }
        }
        private void FillPid()
        {
           
            Con.Open();
            string query = "SELECT Pid FROM Passengertbl";
            OracleCommand cmd = new OracleCommand(query, Con);
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Pid", typeof(int));
            dt.Load(rdr);
            PidCb.ValueMember = "Pid";
            PidCb.DataSource = dt;
            Con.Close();
        }
        private void FillTravCode()
        {

            Con.Open();
            string query = "SELECT TravCode FROM Traveltbl";
            OracleCommand cmd = new OracleCommand(query, Con);
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TravCode", typeof(int));
            dt.Load(rdr);
            TravelCb.ValueMember = "TravCode";
            TravelCb.DataSource = dt;
            Con.Close();
        }
        string pname;
        private void GetPName()
        {
            Con.Open();
            string mysql = "SELECT * FROM Passengertbl WHERE Pid = :Pid";
            OracleCommand cmd = new OracleCommand(mysql, Con);
            cmd.Parameters.Add(new OracleParameter(":Pid", PidCb.SelectedValue));
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                pname = dr["PName"].ToString();
            }
            Con.Close();
            //MessageBox.Show(pname);
        }
        string Date, Src, Dest;
        int Cost;
        private void GetTravel()
        {
            Con.Open();
            string mysql = "SELECT * FROM Traveltbl WHERE TravCode = :Pid";
            OracleCommand cmd = new OracleCommand(mysql, Con);
            cmd.Parameters.Add(new OracleParameter(":Pid", TravelCb.SelectedValue));
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                Date = dr["TravDate"].ToString();
                Src = dr["Src"].ToString();
                Dest = dr["Dest"].ToString();
                Cost = Convert.ToInt32(dr["Cost"].ToString());
            }
            Con.Close();
            //MessageBox.Show(Date+Src+Dest+Cost);
        }

        private void TravelCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTravel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TravelCb.SelectedIndex == -1 || PidCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    GetTravel();  
                    Con.Open();
                    DateTime travelDate;
                    if (!DateTime.TryParse(Date, out travelDate))
                    {
                        MessageBox.Show("Invalid travel date.");
                        return;
                    }
                    string query = "INSERT INTO Reservationtbl VALUES (ticket_seq.NEXTVAL, :Pid, :PName, :TravCode, :TravDate, :TravSrc, :TravDest, :TravCost)";
                    OracleCommand cmd = new OracleCommand(query, Con);
                    cmd.Parameters.Add(":Pid", OracleDbType.Int32).Value = Convert.ToInt32(PidCb.SelectedValue);  
                    cmd.Parameters.Add(":PName", OracleDbType.Varchar2).Value = pname; 
                    cmd.Parameters.Add(":TravCode", OracleDbType.Int32).Value = Convert.ToInt32(TravelCb.SelectedValue);  
                    cmd.Parameters.Add(":TravDate", OracleDbType.Date).Value = travelDate;  
                    cmd.Parameters.Add(":TravSrc", OracleDbType.Varchar2).Value = Src;  
                    cmd.Parameters.Add(":TravDest", OracleDbType.Varchar2).Value = Dest;  
                    cmd.Parameters.Add(new OracleParameter(":Cost", Convert.ToDecimal(Cost.ToString())));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Accepted!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error: " + Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void PidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPName();
        }
    }
}
