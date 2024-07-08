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
    public partial class frmViewDoctor : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\franc\\Desktop\\dbrecords.accdb");
        public frmViewDoctor()
        {
            InitializeComponent();
        }

        private void frmViewDoctor_Load(object sender, EventArgs e)
        {
            showRecords();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "INSERT into doctor(Firstname,Lastname,Age,Sex,Cellphonenum,Specialization) " +
                "VALUES ('" + txtFname.Text+ "','" +txtLname.Text+ "','" +txtAge.Text+ "','" +txtSex.Text+ "','" +txtCpNum.Text+ "','" +txtSpec.Text+"') ";
            cmd.ExecuteNonQuery();
            conn.Close();
            showRecords();
            MessageBox.Show("Added Record ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText =
                "UPDATE doctor " +
                "set Firstname = '"+txtFname.Text+"', Lastname = '"+txtLname.Text+"',Age = '"+txtAge.Text +"', Sex = '"+txtSex.Text+"', Cellphonenum = '"+txtCpNum.Text+ "', Specialization = '"+txtSpec.Text+"' " +
                "WHERE doctorID = "+txtDoctorID.Text+" ";
            cmd.ExecuteNonQuery();
            conn.Close();
            showRecords();
            MessageBox.Show("Record Updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = 
                "DELETE FROM doctor " +
                "WHERE doctorID = " +txtDoctorID.Text+ " ";
            cmd.ExecuteNonQuery();
            conn.Close();
            showRecords();
            MessageBox.Show("Record Deleted","Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM doctor WHERE doctorID LIKE '"+txtSearch.Text+"' ";
            OleDbCommand cmd = new OleDbCommand(query,conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvShow.DataSource = dt;
        }
        void showRecords()
        {
            string query = "SELECT * FROM doctor order by doctorID asc";
            OleDbCommand cmd = new OleDbCommand(query,conn);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();          
            oleDbDataAdapter.Fill(dt);
            dgvShow.DataSource = dt;
        }
        void clear()
        {
            txtDoctorID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAge.Text = "";
            txtSex.Text = "";
            txtSpec.Text = "";
            txtCpNum.Text = "";
            dgvShow.DataSource = null;
        }
    }
}
