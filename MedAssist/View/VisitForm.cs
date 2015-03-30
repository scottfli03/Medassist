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

namespace MedAssist.View
{
    public partial class VisitForm : Form
    {
        private List<Patient> patientList;
        private List<Employee> doctorList;
        public VisitForm()
        {
            InitializeComponent();
        }

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
        }

        private Visit GetVisitData()
        {
            Visit visit = new Visit();
            //TODO: Get the NurseID of the nurse currently logged in.
            try
            {
                visit.NurseID = 1;
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
                Validator.IsPresent(txtTemp))
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
            if (IsValidData())
            {
                Visit visit = GetVisitData();
                VisitController.CreateVisit(visit);
            }
            else
            {
                return;
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
    }
}
