namespace Vet_Clinic
{
    partial class ViewResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewResults));
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tbltestresultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbltestresultsTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tbltestresultsTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.tbltestresultsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileContentPictureBox = new System.Windows.Forms.PictureBox();
            this.tblbloodresultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblbloodresultsTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblbloodresultsTableAdapter();
            this.testDateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltestresultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltestresultsBindingNavigator)).BeginInit();
            this.tbltestresultsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_כתום;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(663, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbltestresultsBindingSource
            // 
            this.tbltestresultsBindingSource.DataMember = "tbltestresults";
            this.tbltestresultsBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tbltestresultsTableAdapter
            // 
            this.tbltestresultsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbltestresultsTableAdapter = this.tbltestresultsTableAdapter;
            this.tableAdapterManager.tbltreatmentpricesTableAdapter = null;
            this.tableAdapterManager.tblvaccineTableAdapter = null;
            this.tableAdapterManager.tblvisitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitForBasketTableAdapter = null;
            // 
            // tbltestresultsBindingNavigator
            // 
            this.tbltestresultsBindingNavigator.AddNewItem = null;
            this.tbltestresultsBindingNavigator.BindingSource = this.tbltestresultsBindingSource;
            this.tbltestresultsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbltestresultsBindingNavigator.CountItemFormat = "מתוך {0}";
            this.tbltestresultsBindingNavigator.DeleteItem = null;
            this.tbltestresultsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbltestresultsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tbltestresultsBindingNavigator.Location = new System.Drawing.Point(254, 617);
            this.tbltestresultsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbltestresultsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbltestresultsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbltestresultsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbltestresultsBindingNavigator.Name = "tbltestresultsBindingNavigator";
            this.tbltestresultsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbltestresultsBindingNavigator.Size = new System.Drawing.Size(229, 25);
            this.tbltestresultsBindingNavigator.TabIndex = 6;
            this.tbltestresultsBindingNavigator.Text = "bindingNavigator1";
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
            // fileContentPictureBox
            // 
            this.fileContentPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbltestresultsBindingSource, "fileContent", true));
            this.fileContentPictureBox.Location = new System.Drawing.Point(12, 44);
            this.fileContentPictureBox.Name = "fileContentPictureBox";
            this.fileContentPictureBox.Size = new System.Drawing.Size(723, 561);
            this.fileContentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileContentPictureBox.TabIndex = 9;
            this.fileContentPictureBox.TabStop = false;
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
            // testDateLabel1
            // 
            this.testDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbltestresultsBindingSource, "testDate", true));
            this.testDateLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.testDateLabel1.ForeColor = System.Drawing.Color.Black;
            this.testDateLabel1.Location = new System.Drawing.Point(262, 9);
            this.testDateLabel1.Name = "testDateLabel1";
            this.testDateLabel1.Size = new System.Drawing.Size(230, 32);
            this.testDateLabel1.TabIndex = 10;
            this.testDateLabel1.Text = "לא נמצאו בדיקות";
            // 
            // ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(755, 662);
            this.ControlBox = false;
            this.Controls.Add(this.testDateLabel1);
            this.Controls.Add(this.fileContentPictureBox);
            this.Controls.Add(this.tbltestresultsBindingNavigator);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewResults";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "צפיה בבדיקות";
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltestresultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltestresultsBindingNavigator)).EndInit();
            this.tbltestresultsBindingNavigator.ResumeLayout(false);
            this.tbltestresultsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbloodresultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tbltestresultsBindingSource;
        private vetclinicDataSetTableAdapters.tbltestresultsTableAdapter tbltestresultsTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbltestresultsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.PictureBox fileContentPictureBox;
        private System.Windows.Forms.BindingSource tblbloodresultsBindingSource;
        private vetclinicDataSetTableAdapters.tblbloodresultsTableAdapter tblbloodresultsTableAdapter;
        private System.Windows.Forms.Label testDateLabel1;


    }
}