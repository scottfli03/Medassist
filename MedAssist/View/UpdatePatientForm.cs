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
    /// <summary>
    /// Update Patient form
    /// </summary>
    public partial class UpdatePatientForm : Form
    {

        private Patient patient;

        /// <summary>
        /// Initializes the form
        /// </summary>
        public UpdatePatientForm()
        {
            InitializeComponent();
            txtDOB.Enabled = false;
            txtSSN.Enabled = false;
            txtGender.Enabled = false;
            txtMiddleInit.MaxLength = 1;
        }

        /// <summary>
        /// Gets a Patient using their ID and displays their info.
        /// </summary>
        /// <param name="patientID"></param>
        private void GetPatient(int patientID)
        {
            try
            {
                patient = PatientDAL.GetPatientToUpdate(patientID);
                if (patient == null)
                    MessageBox.Show("No Patient found with this ID. " +
                                    "Please try again.", "Patient Not Found");
                else
                {
                    this.DisplayPatient();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Loads the Patient information to the form
        /// </summary>
        private void DisplayPatient()
        {           
            txtFirstName.Text = patient.FirstName;
            txtMiddleInit.Text = patient.MInit.ToString();
            txtLastName.Text = patient.LastName;
            txtAddress1.Text = patient.StreetAddr1;
            txtAddress2.Text = patient.StreetAddr2;
            txtCity.Text = patient.City;
            txtState.Text = patient.State;
            txtZip.Text = patient.ZipCode.ToString();
            txtPhone.Text = patient.Phone.ToString();
            txtDOB.Text = patient.DOB.ToString();
            txtSSN.Text = patient.SSN.ToString();
            txtGender.Text = patient.Gender.ToString();
        }
        
        /// <summary>
        /// Designates the actions carried out when the Submit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();


            if (IsValidData())
            {
                newPatient.PatientID = patient.PatientID;
                this.PutPatientData(newPatient);

                try
                {
                    if (!PatientDAL.UpdatePatient(patient, newPatient))
                    {
                        MessageBox.Show("Another user has updated or " +
                                        "deleted that patient.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        patient = newPatient;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Patient Updated");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Checks if the data is valid
        /// </summary>
        /// <returns>True if it is, false if it isn't</returns>
        private bool IsValidData()
        {
           if (Validator.IsPresent(txtFirstName) &&
               Validator.IsPresent(txtLastName) &&
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
        
        /// <summary>
        /// Sets the patients attributesbfrom the fields in the form
        /// </summary>
        /// <param name="patient">the Patient</param>
        private void PutPatientData(Patient patient)
        {
            txtMiddleInit.MaxLength = 1;
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.MInit = txtMiddleInit.Text[0];
            patient.StreetAddr1 = txtAddress1.Text;
            patient.StreetAddr2 = txtAddress2.Text;
            patient.City = txtCity.Text;
            patient.State = txtState.Text;
            patient.Phone = Int64.Parse(txtPhone.Text);
            patient.ZipCode = Int64.Parse(txtZip.Text);
        }
        
        /// <summary>
        /// Sets the actions taken when Get Patient button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(txtPatientID) &&
                Validator.IsInt32(txtPatientID))
            {
                int patientID = Convert.ToInt32((txtPatientID.Text));
                this.GetPatient(patientID);
            }
         }

        /// <summary>
        /// Sets the actions taken when the Cancel Button is clicked.
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
    }
}
