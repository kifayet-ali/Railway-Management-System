using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Raillway
{
    public partial class Cancellation : Form
    {
        private OracleConnection Con = new OracleConnection("User ID=Railway;Password=railway123;Data Source=127.0.0.1:1521/XE;");
        public Cancellation()
        {
            InitializeComponent();
            populate();
            FillTicketId();
        }
        private void populate()
        {
                Con.Open();
                string query = "SELECT * FROM Cancellationtbl";
                OracleDataAdapter sda = new OracleDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                CancelDGV.DataSource = ds.Tables[0];
                Con.Close();
            
        }
        private void FillTicketId()
        {

            Con.Open();
            string query = "SELECT TicketId from Reservationtbl ";
            OracleCommand cmd = new OracleCommand(query, Con);
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId", typeof(int));
            dt.Load(rdr);
            TidCb.ValueMember = "TicketId";
            TidCb.DataSource = dt;
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (TidCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                   
                    Con.Open();
                    string query = "INSERT INTO Cancellationtbl VALUES (cancellation_seq.NEXTVAL, " + TidCb.SelectedValue.ToString() + ", TO_DATE('" + DateTime.Today.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'))";
                    OracleCommand cmd = new OracleCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled!!!");
                    Con.Close();
                    populate();
                    remove();
                    FillTicketId();
                    TidCb.SelectedIndex = -1;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error: " + Ex.Message);
                }
            }
        }
        private void remove()
        {
                try
                {
                    Con.Open();
                string Query = "DELETE FROM Reservationtbl WHERE TicketId =" + TidCb.SelectedValue.ToString() + "";
                    OracleCommand cmd = new OracleCommand(Query, Con);
                    cmd.ExecuteNonQuery();  
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Database Error: " + Ex.Message);
                }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cancellation_Load(object sender, EventArgs e)
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
