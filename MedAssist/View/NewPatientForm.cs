﻿using MedAssist.Controller;
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
    /// <summary>
    /// Shows Update Patient Form
    /// </summary>
    public partial class NewPatient : Form
    {
        private Patient patient;

        public NewPatient()
        {
            InitializeComponent();
            txtMiddleInit.MaxLength = 1;
            txtPhone.MaxLength = 10;
            txtZip.MaxLength = 10;
            txtSSN.MaxLength = 9;
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

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
                    Close();
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }


        private bool IsValidData()
        {
            if (Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtAddress1) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(cboState) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtZip) &&
                Validator.IsPresent(dateTimePickerDOB) &&
                Validator.IsInt64(txtPhone) &&
                Validator.IsInt64(txtZip) &&
                Validator.IsInt32(txtSSN))
            {
                return true;
            }
            return false;
        }

        private void PutPatientData(Patient patient)
        {
            try
            { 
                patient.FirstName = txtFirstName.Text;
                patient.LastName = txtLastName.Text;
                patient.MInit = txtMiddleInit.Text[0];
                patient.StreetAddr1 = txtAddress1.Text;
                patient.StreetAddr2 = txtAddress2.Text;
                patient.City = txtCity.Text;
                patient.State = cboState.Text;
                patient.SSN = Int32.Parse(txtSSN.Text);
                patient.Phone = Int64.Parse(txtPhone.Text);
                patient.Gender = cboGender.Text[0];
                patient.ZipCode = Int64.Parse(txtZip.Text);
                patient.DOB = dateTimePickerDOB.Value.Date;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
