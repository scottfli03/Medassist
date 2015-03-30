using MedAssist.Controller;
using MedAssist.View;
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

        //TODO: Add Tags so that validation messages show names of what is not correct.
        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //TODO: Display message asking them if they want to cancel
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
                //TODO: Possibly move this into the try statement. 
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
                //TODO: Add a radio button group or a statement validating gender was entered correctly.
                //TODO: Check if MInits length is only one char long. Display message if not.  You may be able to set the textbox to only allow one char.
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
    }
}
