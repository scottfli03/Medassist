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
            txtNurse.Text = EmployeeController.GetEmployeeByID(UserSecurityController.NurseLoggedIn.NurseID).FullName;
            this.loadComboBoxes();
        }

        private void GetVisitInfo(string firstName, string lastName, DateTime visitDate)
        {
            try
            {

                visit = VisitDAL.GetVisitToUpdate(firstName, lastName, visitDate); 
                if (visit == null)
                    MessageBox.Show("No Visit found with this First Name, Last Name or Visit Date. " +
                                    "Please try again.", "Visit Not Found");
                else
                {
                    this.DisplayVisit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayVisit()
        {
            cboDoctor.SelectedText = visit.DoctorID.ToString();
            cboPatient.SelectedText = visit.PatientID.ToString();
            txtSystolic.Text = visit.Systolic.ToString();
            txtDiastolic.Text = visit.Diagnosis.ToString();
            txtHeartRate.Text = visit.HeartRate.ToString();
            txtTemp.Text = visit.Temperature.ToString();
            txtRespRate.Text = visit.RespirationRate.ToString();
            txtBoxDiagnosis.Text = visit.Diagnosis;
            txtSymptoms.Text = visit.Symptoms;
        }

        private void btnSearchVisit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSearchFirstName) &&
               Validator.IsPresent(txtSearchLastName) &&
                Validator.IsPresent(dateTimePickerSearchVisit))
            {
            string firstName = txtSearchFirstName.Text;
            string lastName = txtSearchLastName.Text;
            DateTime visitDate = dateTimePickerSearchVisit.Value.Date;
            this.GetVisitInfo(firstName, lastName, visitDate);
            }
        }

        private void PutVisitData(Visit visit)
        {
            try
            {
            visit.DoctorID = (int)cboDoctor.SelectedValue;
            //visit.Diagnosis = txtBoxDiagnosis.Text;
            visit.PatientID = (int)cboPatient.SelectedValue;
                if (!string.IsNullOrWhiteSpace(txtBoxDiagnosis.Text))
                {
                    visit.Diagnosis = txtBoxDiagnosis.Text;
                }
                else
                {
                    visit.Diagnosis = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private bool IsValidData()
        {
            if (Validator.IsPresent(txtHeartRate) &&
                Validator.IsPresent(cboPatient) &&
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Visit newVisit = new Visit();

            if (IsValidData())
            {
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
    }
}
