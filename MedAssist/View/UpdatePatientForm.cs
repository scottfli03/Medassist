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
        }



        private void DisplayPatient()
        {
            txtFirstName.Text = patient.FirstName;
            txtMiddleInit.Text = Convert.ToString(patient.MInit);
            txtLastName.Text = patient.LastName;
            txtSSN.Text = patient.SSN;



        }
    }
}
