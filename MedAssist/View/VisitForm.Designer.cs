namespace MedAssist.View
{
    partial class VisitForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label doctorNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.txtBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnViewUpdateTest = new System.Windows.Forms.Button();
            this.txtBoxFnlDiagnosis = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.doctor_Patient_Nurse_Employee_Visit_Dataset = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_Dataset();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.VisitsTableAdapter();
            this.tableAdapterManager = new MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager();
            this.visitsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visitsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            nurseIDLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            doctorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_Patient_Nurse_Employee_Visit_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).BeginInit();
            this.visitsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(53, 72);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(38, 13);
            nurseIDLabel.TabIndex = 5;
            nurseIDLabel.Text = "Nurse:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(346, 46);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 30;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(53, 98);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(43, 13);
            patientNameLabel.TabIndex = 39;
            patientNameLabel.Text = "Patient:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new System.Drawing.Point(53, 46);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            doctorNameLabel.TabIndex = 40;
            doctorNameLabel.Text = "Doctor:";
            // 
            // txtNurse
            // 
            this.txtNurse.Location = new System.Drawing.Point(111, 69);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(219, 20);
            this.txtNurse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Routine Check";
            // 
            // txtRespRate
            // 
            this.txtRespRate.Location = new System.Drawing.Point(111, 258);
            this.txtRespRate.Name = "txtRespRate";
            this.txtRespRate.Size = new System.Drawing.Size(198, 20);
            this.txtRespRate.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Respitory Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "S";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(231, 159);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(56, 20);
            this.txtDiastolic.TabIndex = 5;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(111, 300);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(198, 124);
            this.txtSymptoms.TabIndex = 24;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(111, 225);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(198, 20);
            this.txtHeartRate.TabIndex = 23;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(111, 193);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(198, 20);
            this.txtTemp.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Symptoms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Body Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Heart Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Blood Pressure:";
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(137, 159);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(56, 20);
            this.txtSystolic.TabIndex = 4;
            // 
            // txtBoxDiagnosis
            // 
            this.txtBoxDiagnosis.Location = new System.Drawing.Point(408, 43);
            this.txtBoxDiagnosis.Multiline = true;
            this.txtBoxDiagnosis.Name = "txtBoxDiagnosis";
            this.txtBoxDiagnosis.Size = new System.Drawing.Size(240, 170);
            this.txtBoxDiagnosis.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tests:";
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(408, 223);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 33;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            this.btnOrderTest.Click += new System.EventHandler(this.btnOrderTest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Final Diagnosis:";
            // 
            // btnViewUpdateTest
            // 
            this.btnViewUpdateTest.Location = new System.Drawing.Point(540, 223);
            this.btnViewUpdateTest.Name = "btnViewUpdateTest";
            this.btnViewUpdateTest.Size = new System.Drawing.Size(108, 23);
            this.btnViewUpdateTest.TabIndex = 35;
            this.btnViewUpdateTest.Text = "View/Update";
            this.btnViewUpdateTest.UseVisualStyleBackColor = true;
            this.btnViewUpdateTest.Click += new System.EventHandler(this.btnViewUpdateTest_Click);
            // 
            // txtBoxFnlDiagnosis
            // 
            this.txtBoxFnlDiagnosis.Location = new System.Drawing.Point(408, 258);
            this.txtBoxFnlDiagnosis.Multiline = true;
            this.txtBoxFnlDiagnosis.Name = "txtBoxFnlDiagnosis";
            this.txtBoxFnlDiagnosis.Size = new System.Drawing.Size(240, 166);
            this.txtBoxFnlDiagnosis.TabIndex = 36;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(408, 442);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // doctor_Patient_Nurse_Employee_Visit_Dataset
            // 
            this.doctor_Patient_Nurse_Employee_Visit_Dataset.DataSetName = "Doctor_Patient_Nurse_Employee_Visit_Dataset";
            this.doctor_Patient_Nurse_Employee_Visit_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.doctor_Patient_Nurse_Employee_Visit_Dataset;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.NursesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedAssist.Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // visitsBindingNavigator
            // 
            this.visitsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitsBindingNavigator.BindingSource = this.visitsBindingSource;
            this.visitsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.visitsBindingNavigatorSaveItem});
            this.visitsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitsBindingNavigator.Name = "visitsBindingNavigator";
            this.visitsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitsBindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.visitsBindingNavigator.TabIndex = 39;
            this.visitsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // visitsBindingNavigatorSaveItem
            // 
            this.visitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitsBindingNavigatorSaveItem.Enabled = false;
            this.visitsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitsBindingNavigatorSaveItem.Image")));
            this.visitsBindingNavigatorSaveItem.Name = "visitsBindingNavigatorSaveItem";
            this.visitsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.visitsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cmbPatient
            // 
            this.cmbPatient.DataSource = this.visitsBindingSource;
            this.cmbPatient.DisplayMember = "PatientName";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(111, 95);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(219, 21);
            this.cmbPatient.TabIndex = 3;
            this.cmbPatient.ValueMember = "PatientID";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DataSource = this.visitsBindingSource;
            this.cmbDoctor.DisplayMember = "DoctorName";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(111, 42);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(219, 21);
            this.cmbDoctor.TabIndex = 1;
            this.cmbDoctor.ValueMember = "DoctorID";
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 486);
            this.Controls.Add(doctorNameLabel);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.visitsBindingNavigator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
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
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.txtHeartRate);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(nurseIDLabel);
            this.Controls.Add(this.txtNurse);
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_Patient_Nurse_Employee_Visit_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingNavigator)).EndInit();
            this.visitsBindingNavigator.ResumeLayout(false);
            this.visitsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtBoxDiagnosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnViewUpdateTest;
        private System.Windows.Forms.TextBox txtBoxFnlDiagnosis;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private Doctor_Patient_Nurse_Employee_Visit_Dataset doctor_Patient_Nurse_Employee_Visit_Dataset;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private Doctor_Patient_Nurse_Employee_Visit_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton visitsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbDoctor;
    }
}