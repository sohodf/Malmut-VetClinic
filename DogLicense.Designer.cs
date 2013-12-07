namespace Vet_Clinic
{
    partial class DogLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogLicense));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.licenseDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenseDataTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.LicenseDataTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.cellPhoneLabel1 = new System.Windows.Forms.Label();
            this.aNameLabel1 = new System.Windows.Forms.Label();
            this.aBreedLabel1 = new System.Windows.Forms.Label();
            this.aSexLabel1 = new System.Windows.Forms.Label();
            this.colorLabel1 = new System.Windows.Forms.Label();
            this.chipNumLabel1 = new System.Windows.Forms.Label();
            this.neuteredLabel1 = new System.Windows.Forms.Label();
            this.dangerousLabel1 = new System.Windows.Forms.Label();
            this.seeingEyeDogLabel1 = new System.Windows.Forms.Label();
            this.dateOfBirthLabel1 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licenseDataBindingSource
            // 
            this.licenseDataBindingSource.DataMember = "LicenseData";
            this.licenseDataBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // licenseDataTableAdapter
            // 
            this.licenseDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblanimalTableAdapter = null;
            this.tableAdapterManager.tblauthorizationTableAdapter = null;
            this.tableAdapterManager.tblcustomerTableAdapter = null;
            this.tableAdapterManager.tblgivenvaccineTableAdapter = null;
            this.tableAdapterManager.tblinsuranceTableAdapter = null;
            this.tableAdapterManager.tbllabresultsTableAdapter = null;
            this.tableAdapterManager.tblproductpurchasedTableAdapter = null;
            this.tableAdapterManager.tblproductsTableAdapter = null;
            this.tableAdapterManager.tbltreatmentpricesTableAdapter = null;
            this.tableAdapterManager.tblvaccineTableAdapter = null;
            this.tableAdapterManager.tblvisitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.licenseDataBindingSource, "city", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vet_Clinic.Properties.Resources.רישיון_כלבת_ריק;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.BackColor = System.Drawing.Color.White;
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "firstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameLabel1.Location = new System.Drawing.Point(22, 41);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(69, 21);
            this.firstNameLabel1.TabIndex = 34;
            this.firstNameLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.BackColor = System.Drawing.Color.White;
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "lastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLabel1.Location = new System.Drawing.Point(128, 41);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(61, 21);
            this.lastNameLabel1.TabIndex = 35;
            this.lastNameLabel1.Text = "label1";
            // 
            // addressLabel1
            // 
            this.addressLabel1.BackColor = System.Drawing.Color.White;
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "address", true));
            this.addressLabel1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressLabel1.Location = new System.Drawing.Point(445, 41);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(82, 21);
            this.addressLabel1.TabIndex = 36;
            this.addressLabel1.Text = "label1";
            // 
            // cityLabel1
            // 
            this.cityLabel1.BackColor = System.Drawing.Color.White;
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "city", true));
            this.cityLabel1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cityLabel1.Location = new System.Drawing.Point(533, 41);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(30, 21);
            this.cityLabel1.TabIndex = 37;
            this.cityLabel1.Text = "label1";
            // 
            // cellPhoneLabel1
            // 
            this.cellPhoneLabel1.BackColor = System.Drawing.Color.White;
            this.cellPhoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "cellPhone", true));
            this.cellPhoneLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cellPhoneLabel1.Location = new System.Drawing.Point(339, 41);
            this.cellPhoneLabel1.Name = "cellPhoneLabel1";
            this.cellPhoneLabel1.Size = new System.Drawing.Size(91, 21);
            this.cellPhoneLabel1.TabIndex = 38;
            this.cellPhoneLabel1.Text = "label1";
            // 
            // aNameLabel1
            // 
            this.aNameLabel1.BackColor = System.Drawing.Color.White;
            this.aNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "aName", true));
            this.aNameLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aNameLabel1.Location = new System.Drawing.Point(41, 148);
            this.aNameLabel1.Name = "aNameLabel1";
            this.aNameLabel1.Size = new System.Drawing.Size(46, 16);
            this.aNameLabel1.TabIndex = 39;
            this.aNameLabel1.Text = "label1";
            // 
            // aBreedLabel1
            // 
            this.aBreedLabel1.BackColor = System.Drawing.Color.White;
            this.aBreedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "aBreed", true));
            this.aBreedLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aBreedLabel1.Location = new System.Drawing.Point(110, 148);
            this.aBreedLabel1.Name = "aBreedLabel1";
            this.aBreedLabel1.Size = new System.Drawing.Size(69, 16);
            this.aBreedLabel1.TabIndex = 40;
            this.aBreedLabel1.Text = "label1";
            // 
            // aSexLabel1
            // 
            this.aSexLabel1.BackColor = System.Drawing.Color.White;
            this.aSexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "aSex", true));
            this.aSexLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aSexLabel1.Location = new System.Drawing.Point(283, 148);
            this.aSexLabel1.Name = "aSexLabel1";
            this.aSexLabel1.Size = new System.Drawing.Size(68, 16);
            this.aSexLabel1.TabIndex = 41;
            this.aSexLabel1.Text = "label1";
            // 
            // colorLabel1
            // 
            this.colorLabel1.BackColor = System.Drawing.Color.White;
            this.colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "color", true));
            this.colorLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.colorLabel1.Location = new System.Drawing.Point(210, 148);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(44, 16);
            this.colorLabel1.TabIndex = 42;
            this.colorLabel1.Text = "label1";
            // 
            // chipNumLabel1
            // 
            this.chipNumLabel1.BackColor = System.Drawing.Color.White;
            this.chipNumLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "chipNum", true));
            this.chipNumLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chipNumLabel1.Location = new System.Drawing.Point(44, 188);
            this.chipNumLabel1.Name = "chipNumLabel1";
            this.chipNumLabel1.Size = new System.Drawing.Size(152, 25);
            this.chipNumLabel1.TabIndex = 43;
            this.chipNumLabel1.Text = "label1";
            // 
            // neuteredLabel1
            // 
            this.neuteredLabel1.BackColor = System.Drawing.Color.White;
            this.neuteredLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "neutered", true));
            this.neuteredLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.neuteredLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neuteredLabel1.Location = new System.Drawing.Point(369, 645);
            this.neuteredLabel1.Name = "neuteredLabel1";
            this.neuteredLabel1.Size = new System.Drawing.Size(61, 16);
            this.neuteredLabel1.TabIndex = 44;
            this.neuteredLabel1.Text = "label1";
            // 
            // dangerousLabel1
            // 
            this.dangerousLabel1.BackColor = System.Drawing.Color.White;
            this.dangerousLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "dangerous", true));
            this.dangerousLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dangerousLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dangerousLabel1.Location = new System.Drawing.Point(444, 645);
            this.dangerousLabel1.Name = "dangerousLabel1";
            this.dangerousLabel1.Size = new System.Drawing.Size(69, 21);
            this.dangerousLabel1.TabIndex = 45;
            this.dangerousLabel1.Text = "label1";
            // 
            // seeingEyeDogLabel1
            // 
            this.seeingEyeDogLabel1.BackColor = System.Drawing.Color.White;
            this.seeingEyeDogLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "seeingEyeDog", true));
            this.seeingEyeDogLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seeingEyeDogLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seeingEyeDogLabel1.Location = new System.Drawing.Point(520, 645);
            this.seeingEyeDogLabel1.Name = "seeingEyeDogLabel1";
            this.seeingEyeDogLabel1.Size = new System.Drawing.Size(43, 21);
            this.seeingEyeDogLabel1.TabIndex = 46;
            this.seeingEyeDogLabel1.Text = "label1";
            // 
            // dateOfBirthLabel1
            // 
            this.dateOfBirthLabel1.BackColor = System.Drawing.Color.White;
            this.dateOfBirthLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licenseDataBindingSource, "dateOfBirth", true));
            this.dateOfBirthLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.dateOfBirthLabel1.Location = new System.Drawing.Point(476, 148);
            this.dateOfBirthLabel1.Name = "dateOfBirthLabel1";
            this.dateOfBirthLabel1.Size = new System.Drawing.Size(96, 16);
            this.dateOfBirthLabel1.TabIndex = 47;
            this.dateOfBirthLabel1.Text = "label1";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(397, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(210, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(295, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 53;
            this.button1.Text = "הדפסה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DogLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(this.cityLabel1);
            this.Controls.Add(this.cellPhoneLabel1);
            this.Controls.Add(this.aNameLabel1);
            this.Controls.Add(this.aBreedLabel1);
            this.Controls.Add(this.aSexLabel1);
            this.Controls.Add(this.colorLabel1);
            this.Controls.Add(this.chipNumLabel1);
            this.Controls.Add(this.neuteredLabel1);
            this.Controls.Add(this.dangerousLabel1);
            this.Controls.Add(this.seeingEyeDogLabel1);
            this.Controls.Add(this.dateOfBirthLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DogLicense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רישיון כלבת";
            this.Load += new System.EventHandler(this.DogLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource licenseDataBindingSource;
        private vetclinicDataSetTableAdapters.LicenseDataTableAdapter licenseDataTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label cellPhoneLabel1;
        private System.Windows.Forms.Label aNameLabel1;
        private System.Windows.Forms.Label aBreedLabel1;
        private System.Windows.Forms.Label aSexLabel1;
        private System.Windows.Forms.Label colorLabel1;
        private System.Windows.Forms.Label chipNumLabel1;
        private System.Windows.Forms.Label neuteredLabel1;
        private System.Windows.Forms.Label dangerousLabel1;
        private System.Windows.Forms.Label seeingEyeDogLabel1;
        private System.Windows.Forms.Label dateOfBirthLabel1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}