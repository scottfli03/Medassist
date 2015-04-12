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
            System.Windows.Forms.Label testNameLabel;
            System.Windows.Forms.Label label9;
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerSearchVisit = new System.Windows.Forms.DateTimePicker();
            this.btnSearchVisit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.cboPatient = new System.Windows.Forms.ComboBox();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            nurseIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            testNameLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
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
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(27, 34);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(31, 13);
            testNameLabel.TabIndex = 41;
            testNameLabel.Text = "Test:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(363, 63);
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
            this.txtSearchFirstName.Location = new System.Drawing.Point(97, 17);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(103, 20);
            this.txtSearchFirstName.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Last Name";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(270, 17);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "Visit Date";
            // 
            // dateTimePickerSearchVisit
            // 
            this.dateTimePickerSearchVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchVisit.Location = new System.Drawing.Point(457, 18);
            this.dateTimePickerSearchVisit.Name = "dateTimePickerSearchVisit";
            this.dateTimePickerSearchVisit.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerSearchVisit.TabIndex = 78;
            // 
            // btnSearchVisit
            // 
            this.btnSearchVisit.Location = new System.Drawing.Point(586, 17);
            this.btnSearchVisit.Name = "btnSearchVisit";
            this.btnSearchVisit.Size = new System.Drawing.Size(75, 23);
            this.btnSearchVisit.TabIndex = 79;
            this.btnSearchVisit.Text = "Search Visit";
            this.btnSearchVisit.UseVisualStyleBackColor = true;
            this.btnSearchVisit.Click += new System.EventHandler(this.btnSearchVisit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNurse);
            this.groupBox3.Controls.Add(nurseIDLabel);
            this.groupBox3.Controls.Add(this.cboPatient);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(patientNameLabel);
            this.groupBox3.Controls.Add(this.cboDoctor);
            this.groupBox3.Location = new System.Drawing.Point(12, 63);
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
            // cboPatient
            // 
            this.cboPatient.DisplayMember = "PatientName";
            this.cboPatient.FormattingEnabled = true;
            this.cboPatient.Location = new System.Drawing.Point(74, 78);
            this.cboPatient.Name = "cboPatient";
            this.cboPatient.Size = new System.Drawing.Size(219, 21);
            this.cboPatient.TabIndex = 3;
            this.cboPatient.ValueMember = "PatientID";
            // 
            // cboDoctor
            // 
            this.cboDoctor.DisplayMember = "DoctorName";
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(74, 22);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(219, 21);
            this.cboDoctor.TabIndex = 1;
            this.cboDoctor.ValueMember = "DoctorID";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 345);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routine Checks";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(118, 163);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTests);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnOrderTest);
            this.groupBox1.Controls.Add(this.cmbTest);
            this.groupBox1.Controls.Add(this.btnAddTest);
            this.groupBox1.Controls.Add(testNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(393, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 319);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Tests";
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(30, 90);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.Size = new System.Drawing.Size(242, 182);
            this.dgvTests.TabIndex = 43;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(30, 278);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 33;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            // 
            // cmbTest
            // 
            this.cmbTest.DisplayMember = "TestName";
            this.cmbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(64, 31);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(206, 21);
            this.cmbTest.TabIndex = 42;
            this.cmbTest.ValueMember = "TestID";
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(162, 61);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(108, 23);
            this.btnAddTest.TabIndex = 43;
            this.btnAddTest.Text = "Add";
            this.btnAddTest.UseVisualStyleBackColor = true;
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(425, 63);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(240, 172);
            this.txtBoxDiagnosis.TabIndex = 81;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 25);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(425, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 25);
            this.btnSubmit.TabIndex = 85;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UpdateVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxDiagnosis);
            this.Controls.Add(label9);
            this.Controls.Add(this.btnSearchVisit);
            this.Controls.Add(this.dateTimePickerSearchVisit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.diagnosisLabel);
            this.Name = "UpdateVisitForm";
            this.Text = "UpdateVisitForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchVisit;
        private System.Windows.Forms.Button btnSearchVisit;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.ComboBox cboPatient;
        private System.Windows.Forms.ComboBox cboDoctor;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}