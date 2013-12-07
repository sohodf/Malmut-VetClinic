namespace Vet_Clinic
{
    partial class ManageVaccines
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
            System.Windows.Forms.Label aNameLabel;
            System.Windows.Forms.Label custNumLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label dateGivenLabel;
            System.Windows.Forms.Label nextVacLabel;
            System.Windows.Forms.Label paymentTypeLabel;
            System.Windows.Forms.Label placeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVaccines));
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblgivenvaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblgivenvaccineTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblgivenvaccineTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.tblgivenvaccineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblgivenvaccineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aNameLabel1 = new System.Windows.Forms.Label();
            this.custNumLabel1 = new System.Windows.Forms.Label();
            this.typeLabel1 = new System.Windows.Forms.Label();
            this.dateGivenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextVacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblvaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblvaccineTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblvaccineTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.placeComboBox = new System.Windows.Forms.ComboBox();
            aNameLabel = new System.Windows.Forms.Label();
            custNumLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            dateGivenLabel = new System.Windows.Forms.Label();
            nextVacLabel = new System.Windows.Forms.Label();
            paymentTypeLabel = new System.Windows.Forms.Label();
            placeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingNavigator)).BeginInit();
            this.tblgivenvaccineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblvaccineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aNameLabel
            // 
            aNameLabel.AutoSize = true;
            aNameLabel.Location = new System.Drawing.Point(12, 57);
            aNameLabel.Name = "aNameLabel";
            aNameLabel.Size = new System.Drawing.Size(60, 18);
            aNameLabel.TabIndex = 1;
            aNameLabel.Text = "שם חיה:";
            // 
            // custNumLabel
            // 
            custNumLabel.AutoSize = true;
            custNumLabel.Location = new System.Drawing.Point(12, 98);
            custNumLabel.Name = "custNumLabel";
            custNumLabel.Size = new System.Drawing.Size(81, 18);
            custNumLabel.TabIndex = 3;
            custNumLabel.Text = "מספר לקוח:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 139);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(62, 18);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "סוג חיסון:";
            // 
            // dateGivenLabel
            // 
            dateGivenLabel.AutoSize = true;
            dateGivenLabel.Location = new System.Drawing.Point(10, 223);
            dateGivenLabel.Name = "dateGivenLabel";
            dateGivenLabel.Size = new System.Drawing.Size(82, 18);
            dateGivenLabel.TabIndex = 7;
            dateGivenLabel.Text = "תאריך חיסון:";
            // 
            // nextVacLabel
            // 
            nextVacLabel.AutoSize = true;
            nextVacLabel.Location = new System.Drawing.Point(10, 267);
            nextVacLabel.Name = "nextVacLabel";
            nextVacLabel.Size = new System.Drawing.Size(92, 18);
            nextVacLabel.TabIndex = 9;
            nextVacLabel.Text = "תאריך תפוגה:";
            // 
            // paymentTypeLabel
            // 
            paymentTypeLabel.AutoSize = true;
            paymentTypeLabel.Location = new System.Drawing.Point(10, 353);
            paymentTypeLabel.Name = "paymentTypeLabel";
            paymentTypeLabel.Size = new System.Drawing.Size(95, 18);
            paymentTypeLabel.TabIndex = 11;
            paymentTypeLabel.Text = "אמצעי תשלום:";
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new System.Drawing.Point(12, 310);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(44, 18);
            placeLabel.TabIndex = 16;
            placeLabel.Text = "מקום:";
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblgivenvaccineBindingSource
            // 
            this.tblgivenvaccineBindingSource.DataMember = "tblgivenvaccine";
            this.tblgivenvaccineBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblgivenvaccineTableAdapter
            // 
            this.tblgivenvaccineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GetInfoForStockUpdateTableAdapter = null;
            this.tableAdapterManager.tblanimalTableAdapter = null;
            this.tableAdapterManager.tblauthorizationTableAdapter = null;
            this.tableAdapterManager.tblbloodresultsTableAdapter = null;
            this.tableAdapterManager.tblcustomerTableAdapter = null;
            this.tableAdapterManager.tblgivenvaccineTableAdapter = this.tblgivenvaccineTableAdapter;
            this.tableAdapterManager.tblinsuranceTableAdapter = null;
            this.tableAdapterManager.tbllabresultsTableAdapter = null;
            this.tableAdapterManager.tblnotificationsTableAdapter = null;
            this.tableAdapterManager.tblproductpurchasedTableAdapter = null;
            this.tableAdapterManager.tblproductsTableAdapter = null;
            this.tableAdapterManager.tbltestresultsTableAdapter = null;
            this.tableAdapterManager.tbltreatmentpricesTableAdapter = null;
            this.tableAdapterManager.tblvaccineTableAdapter = null;
            this.tableAdapterManager.tblvisitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitForBasketTableAdapter = null;
            // 
            // tblgivenvaccineBindingNavigator
            // 
            this.tblgivenvaccineBindingNavigator.AddNewItem = null;
            this.tblgivenvaccineBindingNavigator.BindingSource = this.tblgivenvaccineBindingSource;
            this.tblgivenvaccineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblgivenvaccineBindingNavigator.CountItemFormat = "מתוך {0}";
            this.tblgivenvaccineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblgivenvaccineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.tblgivenvaccineBindingNavigatorSaveItem});
            this.tblgivenvaccineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblgivenvaccineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblgivenvaccineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblgivenvaccineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblgivenvaccineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblgivenvaccineBindingNavigator.Name = "tblgivenvaccineBindingNavigator";
            this.tblgivenvaccineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblgivenvaccineBindingNavigator.Size = new System.Drawing.Size(290, 25);
            this.tblgivenvaccineBindingNavigator.TabIndex = 0;
            this.tblgivenvaccineBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 22);
            this.bindingNavigatorCountItem.Text = "מתוך {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "מחיקה";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "ראשון";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "קודם";
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
            this.bindingNavigatorMoveNextItem.Text = "הבא";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "אחרון";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblgivenvaccineBindingNavigatorSaveItem
            // 
            this.tblgivenvaccineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblgivenvaccineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblgivenvaccineBindingNavigatorSaveItem.Image")));
            this.tblgivenvaccineBindingNavigatorSaveItem.Name = "tblgivenvaccineBindingNavigatorSaveItem";
            this.tblgivenvaccineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblgivenvaccineBindingNavigatorSaveItem.Text = "שמירה";
            this.tblgivenvaccineBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblgivenvaccineBindingNavigatorSaveItem_Click);
            // 
            // aNameLabel1
            // 
            this.aNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "aName", true));
            this.aNameLabel1.Location = new System.Drawing.Point(123, 57);
            this.aNameLabel1.Name = "aNameLabel1";
            this.aNameLabel1.Size = new System.Drawing.Size(123, 23);
            this.aNameLabel1.TabIndex = 2;
            this.aNameLabel1.Text = "label1";
            // 
            // custNumLabel1
            // 
            this.custNumLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "custNum", true));
            this.custNumLabel1.Location = new System.Drawing.Point(123, 98);
            this.custNumLabel1.Name = "custNumLabel1";
            this.custNumLabel1.Size = new System.Drawing.Size(123, 23);
            this.custNumLabel1.TabIndex = 4;
            this.custNumLabel1.Text = "label1";
            // 
            // typeLabel1
            // 
            this.typeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "type", true));
            this.typeLabel1.Location = new System.Drawing.Point(123, 139);
            this.typeLabel1.Name = "typeLabel1";
            this.typeLabel1.Size = new System.Drawing.Size(123, 23);
            this.typeLabel1.TabIndex = 6;
            this.typeLabel1.Text = "label1";
            // 
            // dateGivenDateTimePicker
            // 
            this.dateGivenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblgivenvaccineBindingSource, "dateGiven", true));
            this.dateGivenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGivenDateTimePicker.Location = new System.Drawing.Point(124, 220);
            this.dateGivenDateTimePicker.Name = "dateGivenDateTimePicker";
            this.dateGivenDateTimePicker.Size = new System.Drawing.Size(123, 26);
            this.dateGivenDateTimePicker.TabIndex = 8;
            // 
            // nextVacDateTimePicker
            // 
            this.nextVacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblgivenvaccineBindingSource, "nextVac", true));
            this.nextVacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nextVacDateTimePicker.Location = new System.Drawing.Point(124, 264);
            this.nextVacDateTimePicker.Name = "nextVacDateTimePicker";
            this.nextVacDateTimePicker.Size = new System.Drawing.Size(123, 26);
            this.nextVacDateTimePicker.TabIndex = 10;
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "paymentType", true));
            this.paymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "",
            "50",
            "140",
            "עיריה",
            "דואר"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(124, 350);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.paymentTypeComboBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "type", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // tblvaccineBindingSource
            // 
            this.tblvaccineBindingSource.DataMember = "tblvaccine";
            this.tblvaccineBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblvaccineTableAdapter
            // 
            this.tblvaccineTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "שינוי סוג:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // placeComboBox
            // 
            this.placeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblgivenvaccineBindingSource, "place", true));
            this.placeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.placeComboBox.FormattingEnabled = true;
            this.placeComboBox.Items.AddRange(new object[] {
            "",
            "מקומי",
            "אחר"});
            this.placeComboBox.Location = new System.Drawing.Point(124, 307);
            this.placeComboBox.Name = "placeComboBox";
            this.placeComboBox.Size = new System.Drawing.Size(121, 26);
            this.placeComboBox.TabIndex = 17;
            // 
            // ManageVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(290, 444);
            this.ControlBox = false;
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.placeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(aNameLabel);
            this.Controls.Add(this.aNameLabel1);
            this.Controls.Add(custNumLabel);
            this.Controls.Add(this.custNumLabel1);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeLabel1);
            this.Controls.Add(dateGivenLabel);
            this.Controls.Add(this.dateGivenDateTimePicker);
            this.Controls.Add(nextVacLabel);
            this.Controls.Add(this.nextVacDateTimePicker);
            this.Controls.Add(paymentTypeLabel);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.tblgivenvaccineBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageVaccines";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ניהול חיסונים";
            this.Load += new System.EventHandler(this.ManageVaccines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingNavigator)).EndInit();
            this.tblgivenvaccineBindingNavigator.ResumeLayout(false);
            this.tblgivenvaccineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblvaccineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblgivenvaccineBindingSource;
        private vetclinicDataSetTableAdapters.tblgivenvaccineTableAdapter tblgivenvaccineTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblgivenvaccineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblgivenvaccineBindingNavigatorSaveItem;
        private System.Windows.Forms.Label aNameLabel1;
        private System.Windows.Forms.Label custNumLabel1;
        private System.Windows.Forms.Label typeLabel1;
        private System.Windows.Forms.DateTimePicker dateGivenDateTimePicker;
        private System.Windows.Forms.DateTimePicker nextVacDateTimePicker;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblvaccineBindingSource;
        private vetclinicDataSetTableAdapters.tblvaccineTableAdapter tblvaccineTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox placeComboBox;

    }
}