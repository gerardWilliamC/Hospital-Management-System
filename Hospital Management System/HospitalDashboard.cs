using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class HospitalDashboard : Form
    {
        public HospitalDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorForm pf = new DoctorForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void newBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            bf.MdiParent = this;
            bf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DoctorForm pf = new DoctorForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BillingForm pf = new BillingForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

    }
}
