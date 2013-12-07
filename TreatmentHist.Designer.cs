namespace Vet_Clinic
{
    partial class TreatmentHist
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
            this.tblvisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblvisitTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblvisitTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.tblvisitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvisitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblvisitBindingSource
            // 
            this.tblvisitBindingSource.DataMember = "tblvisit";
            this.tblvisitBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblvisitTableAdapter
            // 
            this.tblvisitTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblinsuranceTableAdapter = null;
            this.tableAdapterManager.tbllabresultsTableAdapter = null;
            this.tableAdapterManager.tblnotificationsTableAdapter = null;
            this.tableAdapterManager.tblproductpurchasedTableAdapter = null;
            this.tableAdapterManager.tblproductsTableAdapter = null;
            this.tableAdapterManager.tbltestresultsTableAdapter = null;
            this.tableAdapterManager.tbltreatmentpricesTableAdapter = null;
            this.tableAdapterManager.tblvaccineTableAdapter = null;
            this.tableAdapterManager.tblvisitTableAdapter = this.tblvisitTableAdapter;
            this.tableAdapterManager.UpdateOrder = Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitForBasketTableAdapter = null;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_כתום;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(487, 685);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblvisitDataGridView
            // 
            this.tblvisitDataGridView.AllowUserToAddRows = false;
            this.tblvisitDataGridView.AllowUserToDeleteRows = false;
            this.tblvisitDataGridView.AutoGenerateColumns = false;
            this.tblvisitDataGridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.tblvisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblvisitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.tblvisitDataGridView.DataSource = this.tblvisitBindingSource;
            this.tblvisitDataGridView.Location = new System.Drawing.Point(12, 31);
            this.tblvisitDataGridView.Name = "tblvisitDataGridView";
            this.tblvisitDataGridView.ReadOnly = true;
            this.tblvisitDataGridView.Size = new System.Drawing.Size(993, 647);
            this.tblvisitDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "תאריך";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn6.HeaderText = "משקל";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vDetails";
            this.dataGridViewTextBoxColumn5.HeaderText = "פרטים";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // TreatmentHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.ControlBox = false;
            this.Controls.Add(this.tblvisitDataGridView);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TreatmentHist";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "היסטוריית טיפולים לחיה";
            this.Load += new System.EventHandler(this.TreatmentHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvisitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblvisitBindingSource;
        private vetclinicDataSetTableAdapters.tblvisitTableAdapter tblvisitTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tblvisitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}