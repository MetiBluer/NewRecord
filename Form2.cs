using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace DBrecords
{
    public partial class frmViewPatients : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Desktop\\dbrecords.accdb");
        public frmViewPatients()
        {
            InitializeComponent();
        }

        private void frmViewPatients_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //conn.Open();
            //OleDbCommand cmd = new OleDbCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "SELECT * FROM patients WHERE patientID = "+txtPatientID.Text+" ";
            //cmd.ExecuteNonQuery();
            //conn.Close();


            /*conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT patient * FROM patient WHERE Firstname = '"+txtFname.Text+"' ";
            conn.Close();

            ShowRecords();*/

        }        
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "UPDATE patients " +
                "set Firstname = '" + txtFname.Text + "', Lastname = '" + txtLname.Text + "', Age = '"+txtAge.Text+"', Sex = '" + txtSex.Text + "', Birthday = '" + txtBday.Text + "', CpNumber = '" + txtCpNum.Text + "'  " +
                "WHERE patientID = " + txtPatientID.Text + " ";
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowRecords();
            MessageBox.Show("Record Updated", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "INSERT into patients(Firstname,Lastname,Age,Sex,Birthday,CpNumber) " +
                "VALUES ('"+txtFname.Text+"','"+txtLname.Text+"','"+txtAge.Text+"','"+txtSex.Text+"','"+txtBday.Text+"','" + txtCpNum.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowRecords();
            MessageBox.Show("Added Record ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "DELETE FROM patients " +
                "WHERE patientID = "+txtPatientID.Text+" ";
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowRecords();
            MessageBox.Show("Record Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowRecords()
        {
            string query ="SELECT * FROM patients order by patientID asc" ;
            OleDbCommand cmd = new OleDbCommand(query,conn);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oleDbDataAdapter.Fill(dt);
            dgvShow.DataSource = dt;
        }
        void clear()
        {
            txtPatientID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAge.Text = "";
            txtSex.Text = "";
            txtBday.Text = "";
            txtCpNum.Text = "";
            dgvShow.DataSource = null;
        }
    }
}
