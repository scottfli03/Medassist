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
        FormLogin login;

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
            this.displayNewPatientForm();
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

        /// <summary>
        /// Logout from the application and make the subfiles to hide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.DisplayUpdatePatientForm();

            this.up.Hide();

            this.displayNewPatientForm();
            this.np.Hide();
            this.Text = "You are logged off";
           
            

        }
   
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.login = new FormLogin();
               
               this.login.Show();
               this.Hide();
        }

        

        
    }
}



