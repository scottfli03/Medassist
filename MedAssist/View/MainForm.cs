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
                np.Show();
            }
            else
            {
                np.Activate();
            }
        }
        MedAssist.View.SearchPatient f4;
        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f4 == null)
            {
                f4 = new MedAssist.View.SearchPatient();
                f4.StartPosition = FormStartPosition.Manual;
                f4.MdiParent = this;
                f4.FormClosed += new FormClosedEventHandler(f4_FormClosed);
                f4.Show();
            }
            else
                f4.Activate();
        }
        private void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f4 = null;
        }
    }
}
