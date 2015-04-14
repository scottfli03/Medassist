using System;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patient_Report_Dataset.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.patient_Report_Dataset.Visits);
            // TODO: This line of code loads data into the 'patient_Report_Dataset.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.patient_Report_Dataset.Visits);

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
