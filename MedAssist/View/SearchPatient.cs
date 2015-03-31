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


        private List<Visit> visitList;
        private String fName;
        private String lName;
        private DateTime patientDob;
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void SearchPatientForm_Load(object sender, EventArgs e)
        {
            //this.GetPatientData();

        }

        private void patientVisitSearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //This method will search for the patient by their first name and last name
        private void GetPatientData()
        {
            fName = txtFName.Text;
            lName = txtLName.Text;

            try
            {
                //get a patient object for the typed Patient
                //will bind the datagrid to that object
                visitList = VisitDAL.GetVisitForPatient(fName, lName);
                patientVisitSearchDataGridView.DataSource = visitList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetPatientDataWithDOB()
        {
            lName = txtLName.Text;
            DateTime patientDob = Convert.ToDateTime(txtDOB.Text);

            try
            {
                visitList = VisitDAL.GetVisitForPatientWithDobAndLName(lName, patientDob);
                patientVisitSearchDataGridView.DataSource = visitList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtFName.Text != null && txtFName.Text != "") && (txtLName.Text != null && txtLName.Text != ""))
            {
                this.GetPatientData();
            }

            else if ((txtLName.Text != null && txtLName.Text != "") && (txtDOB.Text != null && txtDOB.Text != ""))
            {
                this.GetPatientDataWithDOB();
            }

            else if ((txtFName.Text == null || txtFName.Text == ""))
            {
                MessageBox.Show(txtFName.Tag.ToString() + " is a required field.", "First Name Required");

            }

            else if ((txtLName.Text == null || txtLName.Text == ""))
            {
                MessageBox.Show(txtLName.Tag.ToString() + " is a required field.", "Last Name Required");

            }


            else if (txtLName.Text == null || txtLName.Text == "")
            {
                MessageBox.Show(txtLName.Tag.ToString() + " is a required field.", "Last Name Required");

            }

            else if (txtDOB.Text == null || txtDOB.Text == "")
            {
                MessageBox.Show(txtDOB.Tag.ToString() + " is a required field.", "Date of Birth is Required");

            }
        }

    }
}


