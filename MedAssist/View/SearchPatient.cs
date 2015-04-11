using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Model;
using MedAssist.Controller;
using MedAssist.View;

namespace MedAssist.View
{
    public partial class SearchPatient : Form
    {

        NewPatient np;
        private List<Visit> visitList;
        private List<Patient> patientList;
        private String fName;
        private String lName;
        private DateTime patientDob;
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void SearchPatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsAndAllVisitInfo.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsAndAllVisitInfo.Patients);


        }

        private void patientVisitSearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //This method will search for the patient by their first name and last name
        private void GetPatientData()
        {
            fName = txtFName.Text;
            lName = txtLName.Text;

            try
            {
                //get a patient object for the typed Patient
                //will bind the datagrid to that object
                //visitList = VisitDAL.GetVisitForPatient(fName, lName);
                patientList = PatientController.GetVisitForPatient(fName, lName);
                if (patientList.Count == 0) //was visitList
                {
                    MessageBox.Show("No Patient/Visit Found!", "Create a New Patient");
                }
                else
                {
                    patientVisitSearchDataGridView.DataSource = patientList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// gets patient data with dob and last name
        /// </summary>
        private void GetPatientDataLnameWithDOB()
        {
            lName = txtLName.Text;
            if (Validator.IsDate(txtDOB) == true)
            {
                DateTime patientDob = Convert.ToDateTime(txtDOB.Text);

                try
                {
                    //visitList = VisitDAL.GetVisitForPatientWithDobAndLName(lName, patientDob);
                    patientList = PatientController.GetVisitForPatientWithDobAndLName(lName, patientDob);

                    if (patientList.Count == 0) //was visitList
                    {
                        MessageBox.Show("No Patient/Visit Info Found!", "Create a New Patient");
                    }
                    else
                    {
                        patientVisitSearchDataGridView.DataSource = patientList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
       }

        /// <summary>
        /// Get patients with only the DOB
        /// </summary>
        private void GetPatientDataByDOB()
        {
            if (Validator.IsDate(txtDOB) == true)
            {
                DateTime patientDob = Convert.ToDateTime(txtDOB.Text);

                try
                {
                    // visitList = VisitDAL.GetPatientsByDOB(patientDob);
                    patientList = PatientController.GetPatientsByDOB(patientDob);

                    if (patientList.Count == 0) //was visitList
                    {
                        MessageBox.Show("No Patient/Visit Info Found!", "Create a New Patient");
                    }
                    else
                    {
                        patientVisitSearchDataGridView.DataSource = patientList;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtFName.Text != null && txtFName.Text != "") && (txtLName.Text != null && txtLName.Text != ""))
            {
                this.GetPatientData();
            }
            else if ((txtLName.Text != null && txtLName.Text != "") && (txtDOB.Text != null && txtDOB.Text != ""))
            {
                this.GetPatientDataLnameWithDOB();
            }
            else if (txtDOB.Text != null)
            {
                this.GetPatientDataByDOB();
            }


        }
        //New Patient Button
        private void button3_Click(object sender, EventArgs e)
        {
            this.displayNewPatientForm();
        }

        /// <summary>
        /// Displays new Patient form 
        /// </summary>
        private void displayNewPatientForm()
        {

            if (np == null)
            {
                np = new NewPatient();
                // np.MdiParent = this;
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
            this.np = null;
            //throw new NotImplementedException();
        }

    }
}


