using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.Model;

namespace MedAssist.View
{
    public partial class UpdateDeleteEmployeeForm : Form
    {
        private bool isDoctor;
        private bool isNurse;
        private bool isAdmin;
        private Employee employee;
        private Employee oldEmployee;

        public UpdateDeleteEmployeeForm()
        {
            InitializeComponent();
        }

        private void UpdateDeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            this.disableFields();
        }

        private void disableFields()
        {
            txtCity.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtMinit.Enabled = false;
            txtPhone.Enabled = false;
            txtSSN.Enabled = false;
            txtState.Enabled = false;
            txtStreet.Enabled = false;
            txtStreet2.Enabled = false;
            rBtnAdmin.Enabled = false;
            rBtnDoctor.Enabled = false;
            rBtnFemale.Enabled = false;
            rBtnMale.Enabled = false;
            rBtnNurse.Enabled = false;
            btnUpdate.Enabled = false;
            dtpDOB.Enabled = false;
            chkEnabled.Enabled = false;
        }

        private void enableFields()
        {
            txtCity.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtMinit.Enabled = true;
            txtPhone.Enabled = true;
            txtSSN.Enabled = true;
            txtState.Enabled = true;
            txtStreet.Enabled = true;
            txtStreet2.Enabled = true;
            rBtnFemale.Enabled = true;
            rBtnMale.Enabled = true;
            btnUpdate.Enabled = true;
            dtpDOB.Enabled = true;
            chkEnabled.Enabled = true;
        }

        /// <summary>
        /// Checks if the data entered into the form is valid.
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmployeeData()
        {
            if (Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtSSN) &&
                Validator.IsPresent(txtState) &&
                Validator.IsPresent(txtStreet) &&
                Validator.IsInt32(txtSSN) &&
                this.IsValidEmployeeID())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidEmployeeID()
        {
            if (Validator.IsPresent(txtEmployeeID) &&
                Validator.IsInt32(txtEmployeeID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            oldEmployee = null;
            if (this.IsValidEmployeeID()) 
            {
                try
                {
                    oldEmployee = EmployeeController.GetEmployeeByID(Int32.Parse(txtEmployeeID.Text));
                    this.fillEmployeeData();
                    fillEmployeePosition(oldEmployee.EmployeeID);
                    this.enableFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                return;
            }
        }

        private void fillEmployeeData()
        {
            if (oldEmployee != null)
            {
                try
                {
                    txtCity.Text = oldEmployee.City;
                    txtFirstName.Text = oldEmployee.FirstName;
                    txtLastName.Text = oldEmployee.LastName;
                    txtMinit.Text = oldEmployee.MInit;
                    txtPhone.Text = oldEmployee.Phone.ToString();
                    txtSSN.Text = oldEmployee.SSN.ToString();
                    txtState.Text = oldEmployee.State;
                    txtStreet.Text = oldEmployee.StreetAddr1;
                    txtStreet2.Text = oldEmployee.StreetAddr2;
                    dtpDOB.Value = oldEmployee.DOB;
                    if (oldEmployee.Gender == 'm' || oldEmployee.Gender == 'M')
                    {
                        rBtnMale.Checked = true;
                    }
                    if (oldEmployee.Gender == 'f' || oldEmployee.Gender == 'F')
                    {
                        rBtnFemale.Checked = true;
                    }
                    if (!oldEmployee.Inactive)
                    {
                        chkEnabled.Checked = true;
                    }
                    else
                    {
                        chkEnabled.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void fillEmployeePosition(int employeeID) 
        {
            if (EmployeeController.isEmployeeDoctor(employeeID))
            {
                rBtnDoctor.Checked = true;
                this.isDoctor = true;
            }
            else if (EmployeeController.isEmployeeNurse(employeeID))
            {
                rBtnNurse.Checked = true;
                this.isNurse = true;
            }
            else if (EmployeeController.isEmployeeAdmin(employeeID))
            {
                rBtnAdmin.Checked = true;
                this.isAdmin = true;
            }
            else
            {
                MessageBox.Show("Employee\'s position has not been established yet.  Please select one and update it.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                getEmployeeData();
                EmployeeController.UpdateEmployee(oldEmployee, employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: make sure admin count will not become zero
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'd like to close the form?", "Close Form?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void getEmployeeData()
        {
            if (IsValidEmployeeData())
            {
                try
                {
                    employee = new Employee();
                    employee.City = txtCity.Text;
                    employee.FirstName = txtFirstName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.MInit = txtMinit.Text;
                    employee.Phone = txtPhone.Text;
                    employee.SSN = txtSSN.Text;
                    employee.State = txtState.Text;
                    employee.StreetAddr1 = txtStreet.Text;
                    employee.StreetAddr2 = txtStreet2.Text;
                    employee.DOB = dtpDOB.Value;
                    if (rBtnMale.Checked)
                    {
                        employee.Gender = 'M';
                    }
                    if (rBtnFemale.Checked)
                    {
                        employee.Gender = 'F';
                    }
                    if (chkEnabled.Checked)
                    {
                        employee.Inactive = false;
                    }
                    else
                    {
                        employee.Inactive = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}