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
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.nurseIDLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.txtBoxFnlDiagnosis = new System.Windows.Forms.TextBox();
            this.btnViewUpdateTest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.txtRespRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerSearchVisit = new System.Windows.Forms.DateTimePicker();
            this.btnSearchVisit = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(37, 127);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(43, 13);
            this.patientNameLabel.TabIndex = 64;
            this.patientNameLabel.Text = "Patient:";
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
            // nurseIDLabel
            // 
            this.nurseIDLabel.AutoSize = true;
            this.nurseIDLabel.Location = new System.Drawing.Point(37, 101);
            this.nurseIDLabel.Name = "nurseIDLabel";
            this.nurseIDLabel.Size = new System.Drawing.Size(38, 13);
            this.nurseIDLabel.TabIndex = 46;
            this.nurseIDLabel.Text = "Nurse:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Diagnosis:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Doctor:";
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
            // cmbPatient
            // 
            this.cmbPatient.DisplayMember = "PatientName";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(97, 127);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(219, 21);
            this.cmbPatient.TabIndex = 43;
            this.cmbPatient.ValueMember = "PatientID";
            // 
            // txtBoxFnlDiagnosis
            // 
            this.txtBoxFnlDiagnosis.Location = new System.Drawing.Point(421, 306);
            this.txtBoxFnlDiagnosis.Multiline = true;
            this.txtBoxFnlDiagnosis.Name = "txtBoxFnlDiagnosis";
            this.txtBoxFnlDiagnosis.Size = new System.Drawing.Size(240, 166);
            this.txtBoxFnlDiagnosis.TabIndex = 63;
            // 
            // btnViewUpdateTest
            // 
            this.btnViewUpdateTest.Location = new System.Drawing.Point(553, 266);
            this.btnViewUpdateTest.Name = "btnViewUpdateTest";
            this.btnViewUpdateTest.Size = new System.Drawing.Size(108, 23);
            this.btnViewUpdateTest.TabIndex = 62;
            this.btnViewUpdateTest.Text = "View/Update";
            this.btnViewUpdateTest.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Final Diagnosis:";
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(421, 271);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 60;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Tests:";
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(421, 74);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(240, 170);
            this.txtBoxDiagnosis.TabIndex = 58;
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(144, 186);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(56, 20);
            this.txtSystolic.TabIndex = 44;
            // 
            // txtRespRate
            // 
            this.txtRespRate.Location = new System.Drawing.Point(118, 285);
            this.txtRespRate.Name = "txtRespRate";
            this.txtRespRate.Size = new System.Drawing.Size(198, 20);
            this.txtRespRate.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Respitory Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "S";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(238, 186);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(56, 20);
            this.txtDiastolic.TabIndex = 45;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(118, 252);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(198, 20);
            this.txtHeartRate.TabIndex = 52;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(118, 220);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(198, 20);
            this.txtTemp.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Body Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Heart Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Blood Pressure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Routine Check";
            // 
            // txtNurse
            // 
            this.txtNurse.Location = new System.Drawing.Point(97, 101);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(219, 20);
            this.txtNurse.TabIndex = 42;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(118, 337);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(198, 124);
            this.txtSymptoms.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Symptoms:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(421, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "DoctorName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "DoctorID";
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
            this.btnSearchVisit.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 543);
            this.Controls.Add(this.btnSearchVisit);
            this.Controls.Add(this.dateTimePickerSearchVisit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.txtBoxFnlDiagnosis);
            this.Controls.Add(this.btnViewUpdateTest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOrderTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxDiagnosis);
            this.Controls.Add(this.diagnosisLabel);
            this.Controls.Add(this.txtSystolic);
            this.Controls.Add(this.txtRespRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiastolic);
            this.Controls.Add(this.txtHeartRate);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nurseIDLabel);
            this.Controls.Add(this.txtNurse);
            this.Name = "UpdateVisitForm";
            this.Text = "UpdateVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.TextBox txtBoxFnlDiagnosis;
        private System.Windows.Forms.Button btnViewUpdateTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtRespRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchVisit;
        private System.Windows.Forms.Button btnSearchVisit;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label nurseIDLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}