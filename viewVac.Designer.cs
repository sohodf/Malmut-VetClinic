namespace Vet_Clinic
{
    partial class viewVac
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
            System.Windows.Forms.Label typeLabel;
            this.button9 = new System.Windows.Forms.Button();
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblgivenvaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblgivenvaccineTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblgivenvaccineTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.typeListBox = new System.Windows.Forms.ListBox();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            typeLabel.Location = new System.Drawing.Point(23, 33);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(99, 18);
            typeLabel.TabIndex = 71;
            typeLabel.Text = "חיסונים שניתנו:";
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_כתום;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(113, 298);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 36);
            this.button9.TabIndex = 71;
            this.button9.Text = "סגור";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            // typeListBox
            // 
            this.typeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblgivenvaccineBindingSource, "type", true));
            this.typeListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.ItemHeight = 18;
            this.typeListBox.Location = new System.Drawing.Point(132, 33);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(120, 220);
            this.typeListBox.TabIndex = 72;
            // 
            // viewVac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(311, 355);
            this.ControlBox = false;
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.button9);
            this.Name = "viewVac";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "צפיה בחיסונים";
            this.Load += new System.EventHandler(this.viewVac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblgivenvaccineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblgivenvaccineBindingSource;
        private vetclinicDataSetTableAdapters.tblgivenvaccineTableAdapter tblgivenvaccineTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox typeListBox;
    }
}