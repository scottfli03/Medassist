using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.View
{
    public partial class MainForm : Form
    {



        NewPatient np;
        UpdatePatientForm up;
        VisitForm vf;
        SearchPatient sp;
        FormLogin login;

        public MainForm()
        {
            InitializeComponent();
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayNewPatientForm();
        }

        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            //throw new NotImplementedException();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.DisplayUpdatePatientForm();
        }

        /// <summary>
        /// Displays update patient form 
        /// </summary>
        private void DisplayUpdatePatientForm()
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

        /// <summary>
        /// Displays new Patient form 
        /// </summary>
        private void displayNewPatientForm()
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

        void up_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.up = null;
            //throw new NotImplementedException();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DisplaySearchPatientForm();
        }

        private void DisplaySearchPatientForm()
        {
            if (sp == null)
            {
                sp = new MedAssist.View.SearchPatient();
                sp.StartPosition = FormStartPosition.Manual;
                sp.MdiParent = this;
                sp.FormClosed += new FormClosedEventHandler(sp_FormClosed);
                sp.Show();
            }
            else
                sp.Activate();
        }

        private void sp_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.login = new FormLogin();
            if (this.login.ShowDialog() == DialogResult.OK)
            {
                this.login.Close();
            }
            else
            {
                this.Close();
            }
           
           
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.DisplayUpdatePatientForm();

            this.up.Hide();

            this.displayNewPatientForm();
            this.np.Hide();

            this.DisplaySearchPatientForm();
            this.sp.Hide();
            this.Text = "You are logged off";
        }

        private void newVisitToolStripMenuItem1_Click_1(object sender, EventArgs e)
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

        void vf_FormClosed(object sender, FormClosedEventArgs e)
        {
            vf = null;
            //throw new NotImplementedException();
        }
    }
}



