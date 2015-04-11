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
    public partial class AddTestForm : Form
    {
        public AddTestForm()
        {
            InitializeComponent();
        }

        Test test = new Test();
        private List<Test> testList;

        private void AddTestForm_Load(object sender, EventArgs e)
        {
            
        }

        
        


        //this method wil submit the test to the patient selected 
        private void PutTestData(Test test)
        {
            test.TestID = Convert.ToInt32(txtTestID.Text);
            test.TestName = txtTestName.Text;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Test newTest = new Test();
                this.PutTestData(newTest);

                try
                {
                    if (!TestDAL.CreateTest(newTest)) 
                    {
                        MessageBox.Show("ID already in use. Please use another");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        test = newTest;

                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Test has been created");

                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id already in use. Please select another");
                    
                }

                finally
                {
                    this.Close();
                }
            }
        }

        //validation 
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtTestName) &&
               Validator.IsInt32(txtTestID))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboTestID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
