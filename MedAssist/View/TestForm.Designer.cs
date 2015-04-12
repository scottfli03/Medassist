namespace MedAssist.View
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label datePerformedLabel;
            System.Windows.Forms.Label resultLabel;
            System.Windows.Forms.Label testIDLabel;
            System.Windows.Forms.Label visitIDLabel;
            System.Windows.Forms.Label testNameLabel;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label patientLabel;
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePerformedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            this.testIDTextBox = new System.Windows.Forms.TextBox();
            this.visitIDTextBox = new System.Windows.Forms.TextBox();
            this.testNameComboBox = new System.Windows.Forms.ComboBox();
            this.visitDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.fillByTestsToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByTestsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTestDataSet = new MedAssist.OrderTestDataSet();
            this.ordersTableAdapter = new MedAssist.OrderTestDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new MedAssist.OrderTestDataSetTableAdapters.TableAdapterManager();
            this.testsTableAdapter = new MedAssist.OrderTestDataSetTableAdapters.TestsTableAdapter();
            orderIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            datePerformedLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            testIDLabel = new System.Windows.Forms.Label();
            visitIDLabel = new System.Windows.Forms.Label();
            testNameLabel = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.fillByTestsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(944, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Enabled = false;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(104, 87);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 1;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(194, 84);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 2;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(104, 114);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(194, 110);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 4;
            // 
            // datePerformedLabel
            // 
            datePerformedLabel.AutoSize = true;
            datePerformedLabel.Location = new System.Drawing.Point(104, 140);
            datePerformedLabel.Name = "datePerformedLabel";
            datePerformedLabel.Size = new System.Drawing.Size(84, 13);
            datePerformedLabel.TabIndex = 5;
            datePerformedLabel.Text = "Date Performed:";
            // 
            // datePerformedDateTimePicker
            // 
            this.datePerformedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "DatePerformed", true));
            this.datePerformedDateTimePicker.Location = new System.Drawing.Point(194, 136);
            this.datePerformedDateTimePicker.Name = "datePerformedDateTimePicker";
            this.datePerformedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datePerformedDateTimePicker.TabIndex = 6;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(104, 165);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(40, 13);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Result:";
            // 
            // resultComboBox
            // 
            this.resultComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Result", true));
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Location = new System.Drawing.Point(194, 162);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(200, 21);
            this.resultComboBox.TabIndex = 8;
            // 
            // testIDLabel
            // 
            testIDLabel.AutoSize = true;
            testIDLabel.Location = new System.Drawing.Point(104, 192);
            testIDLabel.Name = "testIDLabel";
            testIDLabel.Size = new System.Drawing.Size(45, 13);
            testIDLabel.TabIndex = 9;
            testIDLabel.Text = "Test ID:";
            // 
            // testIDTextBox
            // 
            this.testIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "TestID", true));
            this.testIDTextBox.Location = new System.Drawing.Point(194, 189);
            this.testIDTextBox.Name = "testIDTextBox";
            this.testIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.testIDTextBox.TabIndex = 10;
            // 
            // visitIDLabel
            // 
            visitIDLabel.AutoSize = true;
            visitIDLabel.Location = new System.Drawing.Point(104, 218);
            visitIDLabel.Name = "visitIDLabel";
            visitIDLabel.Size = new System.Drawing.Size(43, 13);
            visitIDLabel.TabIndex = 11;
            visitIDLabel.Text = "Visit ID:";
            // 
            // visitIDTextBox
            // 
            this.visitIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "VisitID", true));
            this.visitIDTextBox.Location = new System.Drawing.Point(194, 215);
            this.visitIDTextBox.Name = "visitIDTextBox";
            this.visitIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.visitIDTextBox.TabIndex = 12;
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(104, 244);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(62, 13);
            testNameLabel.TabIndex = 13;
            testNameLabel.Text = "Test Name:";
            // 
            // testNameComboBox
            // 
            this.testNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "TestName", true));
            this.testNameComboBox.DataSource = this.ordersBindingSource;
            this.testNameComboBox.DisplayMember = "TestName";
            this.testNameComboBox.FormattingEnabled = true;
            this.testNameComboBox.Location = new System.Drawing.Point(194, 244);
            this.testNameComboBox.Name = "testNameComboBox";
            this.testNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.testNameComboBox.TabIndex = 14;
            this.testNameComboBox.ValueMember = "TestID";
            // 
            // visitDateLabel
            // 
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(104, 272);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(55, 13);
            visitDateLabel.TabIndex = 15;
            visitDateLabel.Text = "Visit Date:";
            // 
            // visitDateDateTimePicker
            // 
            this.visitDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "VisitDate", true));
            this.visitDateDateTimePicker.Location = new System.Drawing.Point(194, 268);
            this.visitDateDateTimePicker.Name = "visitDateDateTimePicker";
            this.visitDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.visitDateDateTimePicker.TabIndex = 16;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(104, 297);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(43, 13);
            patientLabel.TabIndex = 17;
            patientLabel.Text = "Patient:";
            // 
            // patientTextBox
            // 
            this.patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Patient", true));
            this.patientTextBox.Location = new System.Drawing.Point(194, 294);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientTextBox.TabIndex = 18;
            // 
            // fillByTestsToolStrip
            // 
            this.fillByTestsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByTestsToolStripButton});
            this.fillByTestsToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByTestsToolStrip.Name = "fillByTestsToolStrip";
            this.fillByTestsToolStrip.Size = new System.Drawing.Size(944, 25);
            this.fillByTestsToolStrip.TabIndex = 19;
            this.fillByTestsToolStrip.Text = "fillByTestsToolStrip";
            // 
            // fillByTestsToolStripButton
            // 
            this.fillByTestsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTestsToolStripButton.Name = "fillByTestsToolStripButton";
            this.fillByTestsToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.fillByTestsToolStripButton.Text = "FillByTests";
            this.fillByTestsToolStripButton.Click += new System.EventHandler(this.fillByTestsToolStripButton_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.orderTestDataSet;
            // 
            // orderTestDataSet
            // 
            this.orderTestDataSet.DataSetName = "OrderTestDataSet";
            this.orderTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedAssist.OrderTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitsTableAdapter = null;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.fillByTestsToolStrip);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(datePerformedLabel);
            this.Controls.Add(this.datePerformedDateTimePicker);
            this.Controls.Add(resultLabel);
            this.Controls.Add(this.resultComboBox);
            this.Controls.Add(testIDLabel);
            this.Controls.Add(this.testIDTextBox);
            this.Controls.Add(visitIDLabel);
            this.Controls.Add(this.visitIDTextBox);
            this.Controls.Add(testNameLabel);
            this.Controls.Add(this.testNameComboBox);
            this.Controls.Add(visitDateLabel);
            this.Controls.Add(this.visitDateDateTimePicker);
            this.Controls.Add(patientLabel);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.fillByTestsToolStrip.ResumeLayout(false);
            this.fillByTestsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OrderTestDataSet orderTestDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrderTestDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private OrderTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker datePerformedDateTimePicker;
        private System.Windows.Forms.ComboBox resultComboBox;
        private System.Windows.Forms.TextBox testIDTextBox;
        private System.Windows.Forms.TextBox visitIDTextBox;
        private System.Windows.Forms.ComboBox testNameComboBox;
        private System.Windows.Forms.DateTimePicker visitDateDateTimePicker;
        private System.Windows.Forms.TextBox patientTextBox;
        private OrderTestDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByTestsToolStrip;
        private System.Windows.Forms.ToolStripButton fillByTestsToolStripButton;



    }
}