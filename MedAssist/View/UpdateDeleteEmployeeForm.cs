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
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
            rBtnAdmin.Enabled = true;
            rBtnDoctor.Enabled = true;
            rBtnFemale.Enabled = true;
            rBtnMale.Enabled = true;
            rBtnNurse.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
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
            Employee employee = null;
            if (this.IsValidEmployeeID()) 
            {
                try
                {
                    employee = EmployeeController.GetEmployeeByID(Int32.Parse(txtEmployeeID.Text));
                    fillEmployeeData(employee);
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

        private void fillEmployeeData(Employee employee)
        {
            if (employee != null)
            {
                try
                {
                    txtCity.Text = employee.City;
                    txtFirstName.Text = employee.FirstName;
                    txtLastName.Text = employee.LastName;
                    txtMinit.Text = employee.MInit;
                    txtPhone.Text = employee.Phone.ToString();
                    txtSSN.Text = employee.SSN.ToString();
                    txtState.Text = employee.State;
                    txtStreet.Text = employee.StreetAddr1;
                    txtStreet2.Text = employee.StreetAddr2;
                    dtpDOB.Value = employee.DOB;
                    if (employee.Gender == 'm' || employee.Gender == 'M')
                    {
                        rBtnMale.Checked = true;
                    }
                    if (employee.Gender == 'f' || employee.Gender == 'F')
                    {
                        rBtnMale.Checked = true;
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