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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void SearchPatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsAndVisits.PatientVisitSearch' table. You can move, or remove it, as needed.
            this.patientVisitSearchTableAdapter.Fill(this.patientsAndVisits.PatientVisitSearch);

        }

        private void patientVisitSearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFName))
            {

            }
        }

        //This method will search for the patient by their first name and last name
        private void GetPatient(string fName, string lName)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFName))
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsDate(txtDOB)) {

            }
        }
    }
}
