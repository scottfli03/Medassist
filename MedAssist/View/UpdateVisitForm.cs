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
        

        public UpdateVisitForm()
        {
            InitializeComponent();
        }

        private void GetVisitInfo(string firstName, string lastName, DateTime DOB)
        {
            try
            {
                //patient = PatientDAL.GetPatientToUpdateWithNoID(firstName, lastName, DOB);
               // if (patient == null)
               //     MessageBox.Show("No Patient found with this First Name, Last Name or Date of Birth. " +
               //                     "Please try again.", "Patient Not Found");
               // else
               // {
               //     this.DisplayPatient();

               // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayPatient()
        {
            //txtFirstName.Text = patient.FirstName;
            //txtMiddleInit.Text = patient.MInit.ToString();
            //txtLastName.Text = patient.LastName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
