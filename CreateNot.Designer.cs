namespace Vet_Clinic
{
    partial class CreateNot
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
            System.Windows.Forms.Label notNumLabel;
            System.Windows.Forms.Label fromDateLabel;
            System.Windows.Forms.Label toDateLabel;
            System.Windows.Forms.Label custNumLabel;
            System.Windows.Forms.Label aNameLabel;
            System.Windows.Forms.Label detailsLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblnotificationsTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblnotificationsTableAdapter();
            this.notNumLabel1 = new System.Windows.Forms.Label();
            this.fromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custNumLabel1 = new System.Windows.Forms.Label();
            this.aNameLabel1 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblnotificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            notNumLabel = new System.Windows.Forms.Label();
            fromDateLabel = new System.Windows.Forms.Label();
            toDateLabel = new System.Windows.Forms.Label();
            custNumLabel = new System.Windows.Forms.Label();
            aNameLabel = new System.Windows.Forms.Label();
            detailsLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnotificationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notNumLabel
            // 
            notNumLabel.AutoSize = true;
            notNumLabel.Location = new System.Drawing.Point(10, 9);
            notNumLabel.Name = "notNumLabel";
            notNumLabel.Size = new System.Drawing.Size(99, 18);
            notNumLabel.TabIndex = 1;
            notNumLabel.Text = "מספר התראה:";
            // 
            // fromDateLabel
            // 
            fromDateLabel.AutoSize = true;
            fromDateLabel.Location = new System.Drawing.Point(10, 41);
            fromDateLabel.Name = "fromDateLabel";
            fromDateLabel.Size = new System.Drawing.Size(101, 18);
            fromDateLabel.TabIndex = 3;
            fromDateLabel.Text = "תאריך התחלה:";
            // 
            // toDateLabel
            // 
            toDateLabel.AutoSize = true;
            toDateLabel.Location = new System.Drawing.Point(10, 79);
            toDateLabel.Name = "toDateLabel";
            toDateLabel.Size = new System.Drawing.Size(79, 18);
            toDateLabel.TabIndex = 5;
            toDateLabel.Text = "תאריך סיום:";
            // 
            // custNumLabel
            // 
            custNumLabel.AutoSize = true;
            custNumLabel.Location = new System.Drawing.Point(10, 117);
            custNumLabel.Name = "custNumLabel";
            custNumLabel.Size = new System.Drawing.Size(81, 18);
            custNumLabel.TabIndex = 7;
            custNumLabel.Text = "מספר לקוח:";
            // 
            // aNameLabel
            // 
            aNameLabel.AutoSize = true;
            aNameLabel.Location = new System.Drawing.Point(10, 154);
            aNameLabel.Name = "aNameLabel";
            aNameLabel.Size = new System.Drawing.Size(60, 18);
            aNameLabel.TabIndex = 9;
            aNameLabel.Text = "שם חיה:";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new System.Drawing.Point(10, 197);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new System.Drawing.Size(51, 18);
            detailsLabel.TabIndex = 11;
            detailsLabel.Text = "פרטים:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(0, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 18);
            label2.TabIndex = 16;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(0, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 18);
            label3.TabIndex = 17;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label4.Location = new System.Drawing.Point(10, 360);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 16);
            label4.TabIndex = 18;
            label4.Text = "שדה חובה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(0, 360);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 19;
            label5.Text = "*";
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblnotificationsTableAdapter
            // 
            this.tblnotificationsTableAdapter.ClearBeforeFill = true;
            // 
            // notNumLabel1
            // 
            this.notNumLabel1.Location = new System.Drawing.Point(127, 9);
            this.notNumLabel1.Name = "notNumLabel1";
            this.notNumLabel1.Size = new System.Drawing.Size(112, 23);
            this.notNumLabel1.TabIndex = 2;
            this.notNumLabel1.Text = "label1";
            // 
            // fromDateDateTimePicker
            // 
            this.fromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateDateTimePicker.Location = new System.Drawing.Point(127, 37);
            this.fromDateDateTimePicker.Name = "fromDateDateTimePicker";
            this.fromDateDateTimePicker.Size = new System.Drawing.Size(112, 26);
            this.fromDateDateTimePicker.TabIndex = 4;
            this.fromDateDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateDateTimePicker_ValueChanged);
            // 
            // toDateDateTimePicker
            // 
            this.toDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateDateTimePicker.Location = new System.Drawing.Point(127, 75);
            this.toDateDateTimePicker.Name = "toDateDateTimePicker";
            this.toDateDateTimePicker.Size = new System.Drawing.Size(112, 26);
            this.toDateDateTimePicker.TabIndex = 6;
            // 
            // custNumLabel1
            // 
            this.custNumLabel1.Location = new System.Drawing.Point(124, 117);
            this.custNumLabel1.Name = "custNumLabel1";
            this.custNumLabel1.Size = new System.Drawing.Size(112, 23);
            this.custNumLabel1.TabIndex = 8;
            this.custNumLabel1.Text = "label1";
            // 
            // aNameLabel1
            // 
            this.aNameLabel1.Location = new System.Drawing.Point(124, 154);
            this.aNameLabel1.Name = "aNameLabel1";
            this.aNameLabel1.Size = new System.Drawing.Size(112, 23);
            this.aNameLabel1.TabIndex = 10;
            this.aNameLabel1.Text = "label1";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(17, 229);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(302, 122);
            this.detailsTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.שמירה_ארוך;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "   שמירה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Vet_Clinic.Properties.Resources.הסרה;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(227, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "   ביטול";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "חובה להזין פרטי התראה!";
            this.label1.Visible = false;
            // 
            // tblnotificationsBindingSource
            // 
            this.tblnotificationsBindingSource.DataMember = "tblnotifications";
            this.tblnotificationsBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GetInfoForStockUpdateTableAdapter = null;
            this.tableAdapterManager.tblanimalTableAdapter = null;
            this.tableAdapterManager.tblauthorizationTableAdapter = null;
            this.tableAdapterManager.tblbloodresultsTableAdapter = null;
            this.tableAdapterManager.tblcustomerTableAdapter = null;
            this.tableAdapterManager.tblgivenvaccineTableAdapter = null;
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
            // CreateNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(331, 444);
            this.ControlBox = false;
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(notNumLabel);
            this.Controls.Add(this.notNumLabel1);
            this.Controls.Add(fromDateLabel);
            this.Controls.Add(this.fromDateDateTimePicker);
            this.Controls.Add(toDateLabel);
            this.Controls.Add(this.toDateDateTimePicker);
            this.Controls.Add(custNumLabel);
            this.Controls.Add(this.custNumLabel1);
            this.Controls.Add(aNameLabel);
            this.Controls.Add(this.aNameLabel1);
            this.Controls.Add(detailsLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateNot";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "יצירת התראה";
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnotificationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblnotificationsBindingSource;
        private vetclinicDataSetTableAdapters.tblnotificationsTableAdapter tblnotificationsTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label notNumLabel1;
        private System.Windows.Forms.DateTimePicker fromDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateDateTimePicker;
        private System.Windows.Forms.Label custNumLabel1;
        private System.Windows.Forms.Label aNameLabel1;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}