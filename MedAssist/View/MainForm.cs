using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAssist.View
{
    public partial class MainForm : Form
    {


        NewPatient np;
        UpdatePatientForm up;
        VisitForm vf;

        public MainForm()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (np == null)
            {
                np = new NewPatient();
                np.MdiParent = this;
                np.FormClosed += new FormClosedEventHandler(np_FormClosed);
                np.Show();
            }
            else
            {
                np.Activate();
            }
        }

        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            //throw new NotImplementedException();
        }

        void vf_FormClosed(object sender, FormClosedEventArgs e)
        {
            vf = null;
            //throw new NotImplementedException();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (up == null)
            {
                up = new UpdatePatientForm();
                up.MdiParent = this;
                this.up.FormClosed += up_FormClosed;
                up.Show();
            }
            else
            {
                up.Activate();
            }
        }

        void up_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.up = null;
            //throw new NotImplementedException();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newVisitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (vf == null)
            {
                vf = new VisitForm();
                vf.MdiParent = this;
                vf.FormClosed += new FormClosedEventHandler(vf_FormClosed);
                vf.Show();
            }
            else
            {
                vf.Activate();
            }
        }

    }
}
