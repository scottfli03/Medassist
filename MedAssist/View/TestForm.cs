﻿using System;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orderTestDataSet);

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderTestDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.orderTestDataSet.Orders);
            // TODO: This line of code loads data into the 'orderTestDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.orderTestDataSet.Orders);
        }

        private void fillByPatientIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillByPatientID(this.orderTestDataSet.Orders, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByPatientIDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillByPatientID(this.orderTestDataSet.Orders, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
