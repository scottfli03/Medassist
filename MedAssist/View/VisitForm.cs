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
using System.Text.RegularExpressions;

namespace MedAssist.View
{
    /// <summary>
    /// Form that allows a nurse to enter Visit information including the Checkup information
    /// </summary>
    public partial class VisitForm : Form
    {
        private List<Patient> patientList;
        private List<Employee> doctorList;
        public VisitForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carries out actions when the VisitForm loads, including loading the ComboBoxes and assigning Tags.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisitForm_Load(object sender, EventArgs e)
        {
            this.loadComboBoxes();
            txtDiastolic.Tag = "Diastolic Reading";
            txtBoxDiagnosis.Tag = "Diagnosis";
            txtHeartRate.Tag = "Heart Rate";
            txtNurse.Tag = "Nurse";
            txtRespRate.Tag = "Respiratory Rate";
            txtSymptoms.Tag = "Symptoms";
            txtSystolic.Tag = "Systolic Reading";
            txtTemp.Tag = "Temperature";
            cmbDoctor.Tag = "Doctor";
            cmbPatient.Tag = "Patient";
            txtNurse.Text = EmployeeController.GetEmployeeByID(UserSecurityController.NurseLoggedIn.NurseID).FullName;
        }

        /// <summary>
        /// Gets the data from the form and returns it in the form of a Visit Object
        /// </summary>
        /// <returns>The Visit Object</returns>
        private Visit GetVisitData()
        {
            Visit visit = new Visit();
            try
            {
                visit.NurseID = (int)UserSecurityController.NurseLoggedIn.NurseID;
                visit.HeartRate = Int32.Parse(txtHeartRate.Text);
                visit.PatientID = (int)cmbPatient.SelectedValue;
                visit.RespirationRate = Int32.Parse(txtRespRate.Text);
                visit.Symptoms = txtSymptoms.Text;
                visit.Systolic = Int32.Parse(txtSystolic.Text);
                visit.Diastolic = Int32.Parse(txtDiastolic.Text);
                visit.DoctorID = (int)cmbDoctor.SelectedValue;
                visit.Diagnosis = txtBoxDiagnosis.Text + " " + txtBoxFnlDiagnosis.Text;
                visit.VisitDate = DateTime.Today;
                visit.Temperature = Decimal.Parse(txtTemp.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return visit;
        }

        /// <summary>
        /// Checks if the data entered into the form is valid.
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtHeartRate) &&
                Validator.IsPresent(cmbPatient) &&
                Validator.IsPresent(txtNurse) &&
                Validator.IsPresent(txtRespRate) &&
                Validator.IsPresent(txtSymptoms) &&
                Validator.IsPresent(txtSystolic) &&
                Validator.IsPresent(txtDiastolic) &&
                Validator.IsPresent(cmbDoctor) &&
                Validator.IsPresent(txtBoxDiagnosis) &&
                Validator.IsPresent(txtTemp) &&
                Validator.IsInt32(txtDiastolic) &&
                Validator.IsInt32(txtHeartRate) &&
                Validator.IsInt32(txtRespRate) &&
                Validator.IsInt32(txtSystolic) &&
                Validator.IsDecimal(txtTemp))

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// When the submit button is clicked it checks if the data is valid, 
        /// gets the data, and creates a new visit in the Visit table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    Visit visit = GetVisitData();
                    int visitID = VisitController.CreateVisit(visit);
                    MessageBox.Show("Visit " + visitID + " was successfully entered in.", "Visit Completed");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// When the cancel button is clicked the user is asked if they are sure they
        /// want to cancel their form.  If confirmed the Form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you would like to exit the form?", "Form Closing", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Loads the information into the Doctor ComboBox and the Patient ComboBox.
        /// </summary>
        private void loadComboBoxes()
        {
            EmployeeController empCont = new EmployeeController();
            PatientController patCont = new PatientController();
            try
            {
                doctorList = empCont.GetListOfDoctorEmployees();
                cmbDoctor.DataSource = doctorList;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "EmployeeID";
                patientList = patCont.GetPatientList();
                cmbPatient.DataSource = patientList;
                cmbPatient.DisplayMember = "FullName";
                cmbPatient.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Decides the actions taken when the Order Test Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implemented soon", "Under Construction");
        }

        /// <summary>
        /// Decides the actions taken when the Update/View Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewUpdateTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implemented soon", "Under Construction");
        }
    }
}
