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
    public partial class TestForm : Form
    {
        private BindingList<OrderDetails> orders;
        private Order newOrder;
        private Order oldOrder;
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtPatient.Text = CurrentPatientController.currentPatient.FullName;
                this.FillComboBoxes();
                orders = OrderController.GetPatientsOrders(CurrentPatientController.currentPatient.PatientID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void FillComboBoxes()
        {
            cmbOrderID.DisplayMember = "OrderID";
            cmbOrderID.ValueMember = "OrderID";
            cmbOrderID.DataSource = orders;
        }

        private void buildDGV()
        {
            dgvOrders.DataSource = orders;
        }

        private void getOrderAdjustments()
        {

        }
    }
}
