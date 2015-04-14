namespace MedAssist.View
{
    partial class UpdateVisitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label label9;
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.btnSearchVisit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRespRate = new System.Windows.Forms.TextBox();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboVisits = new System.Windows.Forms.ComboBox();
            this.txtBoxFnlDiagnosis = new System.Windows.Forms.TextBox();
            this.btnViewUpdateTest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGetVisitInfo = new System.Windows.Forms.Button();
            this.gpBoxFindPatientVisits = new System.Windows.Forms.GroupBox();
            this.gpBoxVisitDates = new System.Windows.Forms.GroupBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            nurseIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpBoxVisitDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(16, 52);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(38, 13);
            nurseIDLabel.TabIndex = 5;
            nurseIDLabel.Text = "Nurse:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 13);
            label1.TabIndex = 40;
            label1.Text = "Doctor:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(16, 78);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(43, 13);
            patientNameLabel.TabIndex = 39;
            patientNameLabel.Text = "Patient:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(370, 97);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(56, 13);
            label9.TabIndex = 80;
            label9.Text = "Diagnosis:";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Location = new System.Drawing.Point(16, -32);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorNameLabel.TabIndex = 65;
            this.doctorNameLabel.Text = "Doctor:";
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Location = new System.Drawing.Point(309, -32);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            this.diagnosisLabel.TabIndex = 57;
            this.diagnosisLabel.Text = "Diagnosis:";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DisplayMember = "DoctorName";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(74, -36);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(219, 21);
            this.cmbDoctor.TabIndex = 41;
            this.cmbDoctor.ValueMember = "DoctorID";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(72, 25);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(103, 20);
            this.txtSearchFirstName.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Last Name";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(72, 54);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 76;
            // 
            // btnSearchVisit
            // 
            this.btnSearchVisit.Location = new System.Drawing.Point(190, 27);
            this.btnSearchVisit.Name = "btnSearchVisit";
            this.btnSearchVisit.Size = new System.Drawing.Size(115, 23);
            this.btnSearchVisit.TabIndex = 79;
            this.btnSearchVisit.Text = "Search Visit Dates";
            this.btnSearchVisit.UseVisualStyleBackColor = true;
            this.btnSearchVisit.Click += new System.EventHandler(this.btnSearchVisit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPatient);
            this.groupBox3.Controls.Add(this.txtDoctor);
            this.groupBox3.Controls.Add(this.txtNurse);
            this.groupBox3.Controls.Add(nurseIDLabel);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(patientNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 125);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participants";
            // 
            // txtNurse
            // 
            this.txtNurse.Location = new System.Drawing.Point(74, 49);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(219, 20);
            this.txtNurse.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSymptoms);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Controls.Add(this.txtHeartRate);
            this.groupBox2.Controls.Add(this.txtDiastolic);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRespRate);
            this.groupBox2.Controls.Add(this.txtSystolic);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 345);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routine Checks";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(118, 166);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(198, 124);
            this.txtSymptoms.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Blood Pressure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Heart Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Body Temp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Symptoms:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(118, 56);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(198, 20);
            this.txtTemp.TabIndex = 22;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(118, 88);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(198, 20);
            this.txtHeartRate.TabIndex = 23;
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(238, 22);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(56, 20);
            this.txtDiastolic.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Respitory Rate:";
            // 
            // txtRespRate
            // 
            this.txtRespRate.Location = new System.Drawing.Point(118, 121);
            this.txtRespRate.Name = "txtRespRate";
            this.txtRespRate.Size = new System.Drawing.Size(198, 20);
            this.txtRespRate.TabIndex = 29;
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(144, 22);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(56, 20);
            this.txtSystolic.TabIndex = 4;
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(386, 123);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(281, 172);
            this.txtBoxDiagnosis.TabIndex = 81;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 25);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(395, 551);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 25);
            this.btnSubmit.TabIndex = 85;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboVisits
            // 
            this.cboVisits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisits.FormattingEnabled = true;
            this.cboVisits.Location = new System.Drawing.Point(16, 22);
            this.cboVisits.Name = "cboVisits";
            this.cboVisits.Size = new System.Drawing.Size(208, 21);
            this.cboVisits.TabIndex = 87;
            // 
            // txtBoxFnlDiagnosis
            // 
            this.txtBoxFnlDiagnosis.Location = new System.Drawing.Point(395, 377);
            this.txtBoxFnlDiagnosis.Multiline = true;
            this.txtBoxFnlDiagnosis.Name = "txtBoxFnlDiagnosis";
            this.txtBoxFnlDiagnosis.Size = new System.Drawing.Size(272, 144);
            this.txtBoxFnlDiagnosis.TabIndex = 92;
            // 
            // btnViewUpdateTest
            // 
            this.btnViewUpdateTest.Location = new System.Drawing.Point(412, 314);
            this.btnViewUpdateTest.Name = "btnViewUpdateTest";
            this.btnViewUpdateTest.Size = new System.Drawing.Size(108, 23);
            this.btnViewUpdateTest.TabIndex = 91;
            this.btnViewUpdateTest.Text = "View/Update";
            this.btnViewUpdateTest.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Final Diagnosis:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Tests:";
            // 
            // btnGetVisitInfo
            // 
            this.btnGetVisitInfo.Location = new System.Drawing.Point(245, 20);
            this.btnGetVisitInfo.Name = "btnGetVisitInfo";
            this.btnGetVisitInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetVisitInfo.TabIndex = 93;
            this.btnGetVisitInfo.Text = "Get Visit Info";
            this.btnGetVisitInfo.UseVisualStyleBackColor = true;
            this.btnGetVisitInfo.Click += new System.EventHandler(this.btnGetVisitInfo_Click);
            // 
            // gpBoxFindPatientVisits
            // 
            this.gpBoxFindPatientVisits.Location = new System.Drawing.Point(5, 7);
            this.gpBoxFindPatientVisits.Name = "gpBoxFindPatientVisits";
            this.gpBoxFindPatientVisits.Size = new System.Drawing.Size(323, 79);
            this.gpBoxFindPatientVisits.TabIndex = 94;
            this.gpBoxFindPatientVisits.TabStop = false;
            this.gpBoxFindPatientVisits.Text = "Find Visit Dates By Patient";
            // 
            // gpBoxVisitDates
            // 
            this.gpBoxVisitDates.Controls.Add(this.btnGetVisitInfo);
            this.gpBoxVisitDates.Controls.Add(this.cboVisits);
            this.gpBoxVisitDates.Location = new System.Drawing.Point(338, 7);
            this.gpBoxVisitDates.Name = "gpBoxVisitDates";
            this.gpBoxVisitDates.Size = new System.Drawing.Size(343, 75);
            this.gpBoxVisitDates.TabIndex = 95;
            this.gpBoxVisitDates.TabStop = false;
            this.gpBoxVisitDates.Text = "Visit Dates for Patient";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(74, 20);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(219, 20);
            this.txtDoctor.TabIndex = 41;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(75, 78);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(219, 20);
            this.txtPatient.TabIndex = 42;
            // 
            // UpdateVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 593);
            this.Controls.Add(this.gpBoxVisitDates);
            this.Controls.Add(this.txtBoxFnlDiagnosis);
            this.Controls.Add(this.btnViewUpdateTest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBoxDiagnosis);
            this.Controls.Add(label9);
            this.Controls.Add(this.btnSearchVisit);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.diagnosisLabel);
            this.Controls.Add(this.gpBoxFindPatientVisits);
            this.Name = "UpdateVisitForm";
            this.Text = "Update Visit";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpBoxVisitDates.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Button btnSearchVisit;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRespRate;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboVisits;
        private System.Windows.Forms.TextBox txtBoxFnlDiagnosis;
        private System.Windows.Forms.Button btnViewUpdateTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGetVisitInfo;
        private System.Windows.Forms.GroupBox gpBoxFindPatientVisits;
        private System.Windows.Forms.GroupBox gpBoxVisitDates;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtDoctor;
    }
}