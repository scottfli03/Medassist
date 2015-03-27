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
    public partial class Main : Form
    {


        NewPatient np;

        public Main()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (np == null)
            {
                np = new NewPatient();
                np.MdiParent = this;
                np.Show();
            }
            else
            {
                np.Activate();
            }
        }
    }
}
