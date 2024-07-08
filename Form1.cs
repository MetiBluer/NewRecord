using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBrecords
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboSearch.Items.Add("Patients");
            cboSearch.Items.Add("Doctors");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(cboSearch.Text == "Patients")
            {
                frmViewPatients frmViewPatients = new frmViewPatients();
                frmViewPatients.ShowDialog();

            }
            else if(cboSearch.Text == "Doctors")
            {
                frmViewDoctor frmViewDoctor = new frmViewDoctor();
                frmViewDoctor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a Record");
            }

            
        }
    }
}
