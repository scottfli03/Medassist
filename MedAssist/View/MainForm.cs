using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        ChangePasswordForm cpf;
        Thread th;

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void np_FormClosed(object sender, FormClosedEventArgs e)
        {
            np = null;
            //throw new NotImplementedException();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
                {
                    sp.Activate();
                }
            }

        }


        private void sp_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }


        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            
            this.Close();
            this.th = new Thread(openLoginForm);
            this.th.SetApartmentState(ApartmentState.STA);
            this.th.Start();
           
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new FormLogin());
        }

        private void newVisitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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

        void vf_FormClosed(object sender, FormClosedEventArgs e)
        {
            vf = null;
            //throw new NotImplementedException();
        }

        
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
            if (UserSecurityController.AdminLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void uvf_FormClosed(object sender, FormClosedEventArgs e)
        {
            uvf = null;
            //throw new NotImplementedException();
        }

        ReportForm rf;
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void rf_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf = null;
            //throw new NotImplementedException();
        }

        UpdateDeleteEmployeeForm udef;
        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void udef_FormClosed(object sender, FormClosedEventArgs e)
        {
            udef = null;
            //throw new NotImplementedException();
        }

        AddEmployeeForm aef;
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void aef_FormClosed(object sender, FormClosedEventArgs e)
        {
            aef = null;
            //throw new NotImplementedException();
        }

        AddTestForm atf;
        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSecurityController.NurseLoggedIn != null)
            {
                MessageBox.Show("You are not authorized to access this. ", "Access denied");
            }
            else
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
        }

        void atf_FormClosed(object sender, FormClosedEventArgs e)
        {
            atf = null;
            //throw new NotImplementedException();
        }

        UpdateTestForm utf;
        private void updateTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (utf == null)
            {
                utf = new UpdateTestForm();
                utf.MdiParent = this;
                utf.FormClosed += new FormClosedEventHandler(utf_FormClosed);
                utf.Show();

            }
            else
            {
                utf.Activate();
            }
        }

        void utf_FormClosed(object sender, FormClosedEventArgs e)
        {
            utf = null;
            //throw new NotImplementedException();
        }

        
    }
}



