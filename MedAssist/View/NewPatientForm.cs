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

namespace MedAssist
{
    public partial class NewPatient : Form
    {

        private Patient patient;

        public NewPatient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                patient = new Patient();
                PutPatientData(patient);


                try
                {
                    patient.PatientID = PatientDAL.AddPatient(patient); 
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Patient Accepted");
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                Close();
            }
        }


        private bool IsValidData()
        {
            if (Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtSSN) &&
                Validator.IsPresent(dateTimePickerDOB) &&
                Validator.IsPresent(txtAddress1) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtState) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtZip))
            {
                return true;
            }
            return false;
        }

        private void PutPatientData(Patient patient)
        {
            
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.MInit = txtMiddleInit.Text[0];
            patient.StreetAddr1 = txtAddress1.Text;
            patient.StreetAddr2 = txtAddress2.Text;
            patient.City = txtCity.Text;
            patient.State = txtState.Text;
            patient.SSN = txtSSN.Text;
            patient.Phone = txtPhone.Text;
            patient.Gender = txtGender.Text[0];
            patient.ZipCode = txtZip.Text;
            patient.DOB = dateTimePickerDOB.Value.Date;


        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }





    }
}
