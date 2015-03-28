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
    public partial class UpdatePatientForm : Form
    {

        private Patient patient;

        public UpdatePatientForm()
        {
            InitializeComponent();
            txtDOB.Enabled = false;
            txtSSN.Enabled = false;
            txtGender.Enabled = false;
        }

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

        private void DisplayPatient()
        {
            txtFirstName.Text = patient.FirstName;
            txtMiddleInit.Text = patient.MInit.ToString();
            txtLastName.Text = patient.LastName;
            txtAddress1.Text = patient.StreetAddr1;
            txtAddress2.Text = patient.StreetAddr2;
            txtCity.Text = patient.City;
            txtState.Text = patient.State;
            txtZip.Text = patient.ZipCode;
            txtPhone.Text = patient.Phone;
            txtDOB.Text = patient.DOB.ToString();
            txtSSN.Text = patient.SSN;
            txtGender.Text = patient.Gender.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            newPatient.PatientID = patient.PatientID;

            this.PutPatientData(newPatient);

            try
            {
                if (!PatientDAL.UpdatePatient(patient, newPatient))
                {
                    MessageBox.Show("Another user has updated or " +
                                    "deleted that patientt.", "Database Error");
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

        private void PutPatientData(Patient patient)
        {
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.MInit = txtMiddleInit.Text[0];
            patient.StreetAddr1 = txtAddress1.Text;
            patient.StreetAddr2 = txtAddress2.Text;
            patient.City = txtCity.Text;
            patient.State = txtState.Text;
            patient.Phone = txtPhone.Text;
            patient.ZipCode = txtZip.Text;

        }

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(txtPatientID) &&
                Validator.IsInt32(txtPatientID))
            {
                int patientID = Convert.ToInt32((txtPatientID.Text));
                this.GetPatient(patientID);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
