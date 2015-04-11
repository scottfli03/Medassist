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
            if (UserSecurityController.NurseLoggedIn != null)
            {
                this.displayNewPatientForm();
            }
            else
            {
                this.DisplayLoginWarning();
            }


        }

        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            //throw new NotImplementedException();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (UserSecurityController.NurseLoggedIn != null)
            {
                this.DisplayUpdatePatientForm();
            }
            else
            {
                this.DisplayLoginWarning();
            }


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

        private void DisplayLoginWarning()
        {
            MessageBox.Show("You must login to get access. Go to the Account menu to login", "Access denied");
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (UserSecurityController.NurseLoggedIn != null)
            {
                this.DisplaySearchPatientForm();
            }
            else
            {
                this.DisplayLoginWarning();
            }


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

                this.Show();

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

            this.DisplayVisitForm();
            this.vf.Hide();
            this.Text = "You are logged off";
            UserSecurityController.NurseLoggedIn = null;
        }

        private void newVisitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                this.DisplayVisitForm();
            }
            else
            {

                this.DisplayLoginWarning();
            }

        }

        private void DisplayVisitForm()
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

        ChangePasswordForm cpf;
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cpf == null)
            {
                cpf = new ChangePasswordForm();
                cpf.MdiParent = this;
                cpf.FormClosed += new FormClosedEventHandler(cpf_FormClosed);
                cpf.Show();

            }
            else
            {
                cpf.Activate();
            }
        }

        void cpf_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpf = null;
            //throw new NotImplementedException();
        }

        UpdateVisitForm uvf;
        private void updateVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uvf == null)
            {
                uvf = new UpdateVisitForm();
                uvf.MdiParent = this;
                uvf.FormClosed += new FormClosedEventHandler(uvf_FormClosed);
                uvf.Show();

            }
            else
            {
                uvf.Activate();
            }
        }

        void uvf_FormClosed(object sender, FormClosedEventArgs e)
        {
            uvf = null;
            //throw new NotImplementedException();
        }

        ReportForm rf;
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rf == null)
            {
                rf = new ReportForm();
                rf.MdiParent = this;
                rf.FormClosed += new FormClosedEventHandler(rf_FormClosed);
                rf.Show();

            }
            else
            {
                rf.Activate();
            }
        }

        void rf_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf = null;
            //throw new NotImplementedException();
        }

        UpdateDeleteEmployeeForm udef;
        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (udef == null)
            {
                udef = new UpdateDeleteEmployeeForm();
                udef.MdiParent = this;
                udef.FormClosed += new FormClosedEventHandler(udef_FormClosed);
                udef.Show();

            }
            else
            {
                udef.Activate();
            }
        }

        void udef_FormClosed(object sender, FormClosedEventArgs e)
        {
            udef = null;
            //throw new NotImplementedException();
        }

        AddEmployeeForm aef;
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aef == null)
            {
                aef = new AddEmployeeForm();
                aef.MdiParent = this;
                aef.FormClosed += new FormClosedEventHandler(aef_FormClosed);
                aef.Show();

            }
            else
            {
                aef.Activate();
            }
        }

        void aef_FormClosed(object sender, FormClosedEventArgs e)
        {
            aef = null;
            //throw new NotImplementedException();
        }

        AddTestForm atf;
        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atf == null)
            {
                atf = new AddTestForm();
                atf.MdiParent = this;
                atf.FormClosed += new FormClosedEventHandler(atf_FormClosed);
                atf.Show();

            }
            else
            {
                atf.Activate();
            }
        }

        void atf_FormClosed(object sender, FormClosedEventArgs e)
        {
            atf = null;
            //throw new NotImplementedException();
        }
    }
}



