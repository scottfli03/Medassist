﻿using System;
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
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_cs6232_g5DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this._cs6232_g5DataSet.Patients);
            // TODO: This line of code loads data into the 'doctorsIDandNameDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.doctorsIDandNameDataSet.Doctors);

        }
    }
}
