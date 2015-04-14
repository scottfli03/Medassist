using MedAssist.Controller;
using MedAssist.DAL;
using MedAssist.Model;
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
    public partial class UpdateVisitForm : Form
    {
        private Visit visit;
        private int visitID;
        private List<Visit> visitDates;
        private List<Patient> patientList;
        private List<Employee> doctorList;

        public UpdateVisitForm()
        {
            InitializeComponent();
            txtDiastolic.Enabled = false;
            txtSystolic.Enabled = false;
            txtHeartRate.Enabled = false;
            txtRespRate.Enabled = false;
            txtSymptoms.Enabled = false;
            txtTemp.Enabled = false;
            cboPatient.Enabled = false;
            cboDoctor.Enabled = false;
            txtNurse.Enabled = false;
            txtBoxFnlDiagnosis.Enabled = true;
            txtBoxDiagnosis.Enabled = false;
            txtNurse.Text = EmployeeController.GetEmployeeByID(UserSecurityController.NurseLoggedIn.NurseID).FullName;
            CurrentPatientController.currentPatient = null;
            
        }

        private void GetVisitsByPatient(string firstName, string lastName)
        {

            visitDates = VisitDAL.GetListVisitDates(firstName, lastName);
            cboVisits.DataSource = visitDates;
            cboVisits.DisplayMember = "VisitDateID";
            cboVisits.ValueMember = "VisitID";


        }

        private void GetVisitInfo(int visitID1)
        {

            try
            {
                
                visit = VisitDAL.GetVisitToUpdate(visitID);
                if (visit == null)
                    MessageBox.Show("No Visit found with this Visit ID. " +
                                    "Please try again.", "Visit Not Found");
                else
                {
                    this.DisplayVisit();
                    CurrentPatientController.currentPatient = PatientController.GetPatientWithID(visit.PatientID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayVisit()
        {
            cboDoctor.SelectedText = EmployeeController.GetEmployeeByID(visit.DoctorID).FullName;
            cboPatient.SelectedText = PatientController.GetPatientWithID(visit.PatientID).FullName;
            cboPatient.SelectedValue = 
            txtSystolic.Text = visit.Systolic.ToString();
            txtDiastolic.Text = visit.Diagnosis.ToString();
            txtHeartRate.Text = visit.HeartRate.ToString();
            txtTemp.Text = visit.Temperature.ToString();
            txtRespRate.Text = visit.RespirationRate.ToString();
            txtSymptoms.Text = visit.Symptoms;
            txtBoxDiagnosis.Text = visit.Diagnosis;
        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtSearchFirstName) &&
                Validator.IsPresent(txtSearchLastName))
            {
                string firstName = txtSearchFirstName.Text;
                string lastName = txtSearchLastName.Text;
                this.GetVisitsByPatient(firstName, lastName);
            }
        }

        private void PutVisitData(Visit visit)
        {
                visit.Diagnosis = txtBoxDiagnosis.Text + ", " + txtBoxFnlDiagnosis.Text;

        }


        private bool IsValidData()
        {
            if (Validator.IsPresent(txtSearchFirstName) &&
                Validator.IsPresent(txtSearchLastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            visit.VisitID = visitID;
            Visit newVisit = new Visit();
            newVisit.VisitID = visit.VisitID;
            this.PutVisitData(newVisit);

                try
                {
                    if (!VisitDAL.UpdateVisit(visit, newVisit))
                    {
                        MessageBox.Show("Another user has updated or " +
                                        "deleted that visit.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        visit = newVisit;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Visit Updated");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

        }

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

        private void loadComboBoxes()
        {
            EmployeeController empCont = new EmployeeController();
            PatientController patCont = new PatientController();
            try
            {
                doctorList = empCont.GetListOfDoctorEmployees();
                cboDoctor.DataSource = doctorList;
                cboDoctor.DisplayMember = "FullName";
                cboDoctor.ValueMember = "EmployeeID";
                patientList = patCont.GetPatientList();
                cboPatient.DataSource = patientList;
                cboPatient.DisplayMember = "FullName";
                cboPatient.ValueMember = "PatientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGetVisitInfo_Click(object sender, EventArgs e)
        {

            visitID = Convert.ToInt32(cboVisits.SelectedValue);
            this.GetVisitInfo(visitID);

        }

        private void btnViewUpdateTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentPatientController.currentPatient != null)
                {
                    TestForm tf = new TestForm();
                    tf.Show();
                }
                else
                {
                    MessageBox.Show("Please select a patient and visit before reviewing tests", "Patient Selection Needed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
