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
            System.Windows.Forms.Label doctorNameLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
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
            doctorNameLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            nurseIDLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new System.Drawing.Point(16, -32);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            doctorNameLabel.TabIndex = 65;
            doctorNameLabel.Text = "Doctor:";
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
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(37, 110);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(43, 13);
            patientNameLabel.TabIndex = 64;
            patientNameLabel.Text = "Patient:";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DisplayMember = "PatientName";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(97, 110);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(219, 21);
            this.cmbPatient.TabIndex = 43;
            this.cmbPatient.ValueMember = "PatientID";
            // 
            // txtBoxFnlDiagnosis
            // 
            this.txtBoxFnlDiagnosis.Location = new System.Drawing.Point(421, 289);
            this.txtBoxFnlDiagnosis.Multiline = true;
            this.txtBoxFnlDiagnosis.Name = "txtBoxFnlDiagnosis";
            this.txtBoxFnlDiagnosis.Size = new System.Drawing.Size(240, 166);
            this.txtBoxFnlDiagnosis.TabIndex = 63;
            // 
            // btnViewUpdateTest
            // 
            this.btnViewUpdateTest.Location = new System.Drawing.Point(553, 238);
            this.btnViewUpdateTest.Name = "btnViewUpdateTest";
            this.btnViewUpdateTest.Size = new System.Drawing.Size(108, 23);
            this.btnViewUpdateTest.TabIndex = 62;
            this.btnViewUpdateTest.Text = "View/Update";
            this.btnViewUpdateTest.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Final Diagnosis:";
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(421, 238);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 60;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Tests:";
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(421, 57);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(240, 170);
            this.txtBoxDiagnosis.TabIndex = 58;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(309, -32);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 57;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(144, 169);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(56, 20);
            this.txtSystolic.TabIndex = 44;
            // 
            // txtRespRate
            // 
            this.txtRespRate.Location = new System.Drawing.Point(118, 268);
            this.txtRespRate.Name = "txtRespRate";
            this.txtRespRate.Size = new System.Drawing.Size(198, 20);
            this.txtRespRate.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Respitory Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "S";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(238, 169);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(56, 20);
            this.txtDiastolic.TabIndex = 45;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(118, 235);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(198, 20);
            this.txtHeartRate.TabIndex = 52;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(118, 203);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(198, 20);
            this.txtTemp.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Body Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Heart Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Blood Pressure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Routine Check";
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(37, 84);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(38, 13);
            nurseIDLabel.TabIndex = 46;
            nurseIDLabel.Text = "Nurse:";
            // 
            // txtNurse
            // 
            this.txtNurse.Location = new System.Drawing.Point(97, 84);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(219, 20);
            this.txtNurse.TabIndex = 42;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(118, 320);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(198, 124);
            this.txtSymptoms.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Symptoms:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(421, 461);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(334, 74);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(56, 13);
            label11.TabIndex = 70;
            label11.Text = "Diagnosis:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(37, 57);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 13);
            label12.TabIndex = 72;
            label12.Text = "Doctor:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "DoctorName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "DoctorID";
            // 
            // UpdateVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 509);
            this.Controls.Add(label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.label5);
            this.Controls.Add(doctorNameLabel);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.txtBoxFnlDiagnosis);
            this.Controls.Add(this.btnViewUpdateTest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOrderTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxDiagnosis);
            this.Controls.Add(diagnosisLabel);
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
            this.Controls.Add(nurseIDLabel);
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
    }
}