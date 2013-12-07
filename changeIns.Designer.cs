namespace Vet_Clinic
{
    partial class changeIns
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
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblinsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblinsuranceTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblinsuranceTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.toDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblinsuranceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblinsuranceBindingSource
            // 
            this.tblinsuranceBindingSource.DataMember = "tblinsurance";
            this.tblinsuranceBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblinsuranceTableAdapter
            // 
            this.tblinsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GetInfoForStockUpdateTableAdapter = null;
            this.tableAdapterManager.tblanimalTableAdapter = null;
            this.tableAdapterManager.tblauthorizationTableAdapter = null;
            this.tableAdapterManager.tblbloodresultsTableAdapter = null;
            this.tableAdapterManager.tblcustomerTableAdapter = null;
            this.tableAdapterManager.tblgivenvaccineTableAdapter = null;
            this.tableAdapterManager.tblinsuranceTableAdapter = this.tblinsuranceTableAdapter;
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
            // toDateDateTimePicker
            // 
            this.toDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblinsuranceBindingSource, "toDate", true));
            this.toDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateDateTimePicker.Location = new System.Drawing.Point(114, 23);
            this.toDateDateTimePicker.MinDate = new System.DateTime(2012, 3, 26, 0, 0, 0, 0);
            this.toDateDateTimePicker.Name = "toDateDateTimePicker";
            this.toDateDateTimePicker.Size = new System.Drawing.Size(108, 26);
            this.toDateDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "הזן תאריך:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.שמירה_ארוך;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(15, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_כתום;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(147, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "ביטול";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changeIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(244, 127);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDateDateTimePicker);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "changeIns";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שינוי חבילת בריאות";
            this.Load += new System.EventHandler(this.changeIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblinsuranceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblinsuranceBindingSource;
        private vetclinicDataSetTableAdapters.tblinsuranceTableAdapter tblinsuranceTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker toDateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}