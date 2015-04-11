﻿using System;
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
    public partial class UpdateTestForm : Form
    {
        public UpdateTestForm()
        {
            InitializeComponent();
        }

        Test test;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGetTestID_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtTestID) &&
                Validator.IsInt32(txtTestID))
            {
                int testID = Convert.ToInt32(txtTestID.Text);
                this.GetTest(testID);
            }
        }

        private void GetTest(int testID)
        {
            try
            {
                test = TestDAL.GetTestWithID(testID);
                if (test == null)
                    MessageBox.Show("No test found with this ID. " +
                        "Please try again.", "Test Not Found");
                else
                    this.DisplayTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //this displays the incident to the form
        private void DisplayTest()
        {
            txtTestName.Text = test.TestName;

            btnUpdate.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you would like to Cancel?", "Cancel Update?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Test newTest = new Test();
                newTest.TestID = test.TestID;
                newTest.TestName = test.TestName;
                this.PutTestData(newTest);
                try
                {


                    if (!TestDAL.UpdateTest(test, newTest))
                    {
                        MessageBox.Show("Another user has updated or " + "deleted that Test.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        test = newTest;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Test has been updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                finally
                {

                    this.Close();
                }
            }
        }

        // this method sets the values that the form contains to the incident object
        private void PutTestData(Test newTest)
        {
            newTest.TestID = int.Parse(txtTestID.Text);
            newTest.TestName = txtTestName.Text;
            
        }


        private bool IsValidData()
        {
            if (Validator.IsInt32(txtTestID) &&
                             
                Validator.IsPresent(txtTestName))
            {
                return true;
            }
            else
                return false;

        }
    }
}