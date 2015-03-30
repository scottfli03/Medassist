using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.View
{
    public partial class SearchPatient : Form
    {
        //TODO: Make sure main form is large enough to fit this form
        private Patient patient;
        private List<Visit> visitList;
        private String fName;
        private String lName;
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void SearchPatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsAndVisits.PatientVisitSearch' table. You can move, or remove it, as needed.
           // this.patientVisitSearchTableAdapter.Fill(this.patientsAndVisits.PatientVisitSearch);
            this.GetPatientData();
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
        private void GetPatientData()
        {
            if (txtFName.Text == null && txtLName.Text == null)
            {
                MessageBox.Show(txtFName.Tag.ToString() + " is a required field.", fName);
            }
            else fName = txtFName.Text;
                 lName = txtLName.Text;
                 //int patientID = (int)txtFName.Text;
                 

            try
            {
                //get a patient object for the typed Patient
                //will bind the datagrid to that object    

                //**scott I'm trying to take the first name and last name of the patient to create a patient object for the datagrid view
                //to use inorder to populate the list.** 
                //patient = PatientDAL.GetPatientListWithFNameLName(fName,  lName);
                //patientVisitSearchBindingSource.Add();
                visitList = VisitDAL.GetVisitForPatient(fName, lName);
                patientVisitSearchDataGridView.DataSource = visitList;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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
