namespace Vet_Clinic
{
    partial class BloodResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodResults));
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblbloodresultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblbloodresultsTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblbloodresultsTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.tblbloodresultsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testDateLabel1 = new System.Windows.Forms.Label();
            this.fileContentPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingNavigator)).BeginInit();
            this.tblbloodresultsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbloodresultsBindingSource
            // 
            this.tblbloodresultsBindingSource.DataMember = "tblbloodresults";
            this.tblbloodresultsBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblbloodresultsTableAdapter
            // 
            this.tblbloodresultsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GetInfoForStockUpdateTableAdapter = null;
            this.tableAdapterManager.tblanimalTableAdapter = null;
            this.tableAdapterManager.tblauthorizationTableAdapter = null;
            this.tableAdapterManager.tblbloodresultsTableAdapter = this.tblbloodresultsTableAdapter;
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
            // tblbloodresultsBindingNavigator
            // 
            this.tblbloodresultsBindingNavigator.AddNewItem = null;
            this.tblbloodresultsBindingNavigator.BindingSource = this.tblbloodresultsBindingSource;
            this.tblbloodresultsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblbloodresultsBindingNavigator.CountItemFormat = "מתוך {0}";
            this.tblbloodresultsBindingNavigator.DeleteItem = null;
            this.tblbloodresultsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblbloodresultsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblbloodresultsBindingNavigator.Location = new System.Drawing.Point(227, 649);
            this.tblbloodresultsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblbloodresultsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblbloodresultsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblbloodresultsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblbloodresultsBindingNavigator.Name = "tblbloodresultsBindingNavigator";
            this.tblbloodresultsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblbloodresultsBindingNavigator.Size = new System.Drawing.Size(229, 25);
            this.tblbloodresultsBindingNavigator.TabIndex = 0;
            this.tblbloodresultsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 22);
            this.bindingNavigatorCountItem.Text = "מתוך {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // testDateLabel1
            // 
            this.testDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblbloodresultsBindingSource, "testDate", true));
            this.testDateLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.testDateLabel1.ForeColor = System.Drawing.Color.Black;
            this.testDateLabel1.Location = new System.Drawing.Point(247, 0);
            this.testDateLabel1.Name = "testDateLabel1";
            this.testDateLabel1.Size = new System.Drawing.Size(240, 32);
            this.testDateLabel1.TabIndex = 2;
            this.testDateLabel1.Text = "לא נמצאו בדיקות";
            // 
            // fileContentPictureBox
            // 
            this.fileContentPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblbloodresultsBindingSource, "fileContent", true));
            this.fileContentPictureBox.Location = new System.Drawing.Point(12, 35);
            this.fileContentPictureBox.Name = "fileContentPictureBox";
            this.fileContentPictureBox.Size = new System.Drawing.Size(677, 599);
            this.fileContentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileContentPictureBox.TabIndex = 4;
            this.fileContentPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_בחירה_בינוני;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(614, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BloodResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(701, 686);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testDateLabel1);
            this.Controls.Add(this.fileContentPictureBox);
            this.Controls.Add(this.tblbloodresultsBindingNavigator);
            this.Name = "BloodResults";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "צפיה בתוצאות בדיקת דם לחיה";
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingNavigator)).EndInit();
            this.tblbloodresultsBindingNavigator.ResumeLayout(false);
            this.tblbloodresultsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblbloodresultsBindingSource;
        private vetclinicDataSetTableAdapters.tblbloodresultsTableAdapter tblbloodresultsTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblbloodresultsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label testDateLabel1;
        private System.Windows.Forms.PictureBox fileContentPictureBox;
        private System.Windows.Forms.Button button1;
    }
}