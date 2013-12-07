namespace Vet_Clinic
{
    partial class AddAnimal
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
            System.Windows.Forms.Label custNumLabel;
            System.Windows.Forms.Label aNameLabel;
            System.Windows.Forms.Label aTypeLabel;
            System.Windows.Forms.Label aBreedLabel;
            System.Windows.Forms.Label aSexLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label chipNumLabel;
            System.Windows.Forms.Label neuteredLabel;
            System.Windows.Forms.Label dangerousLabel;
            System.Windows.Forms.Label seeingEyeDogLabel;
            System.Windows.Forms.Label firstVisitLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimal));
            this.vetclinicDataSet = new Vet_Clinic.vetclinicDataSet();
            this.tblanimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblanimalTableAdapter = new Vet_Clinic.vetclinicDataSetTableAdapters.tblanimalTableAdapter();
            this.tableAdapterManager = new Vet_Clinic.vetclinicDataSetTableAdapters.TableAdapterManager();
            this.custNumLabel1 = new System.Windows.Forms.Label();
            this.aNameTextBox = new System.Windows.Forms.TextBox();
            this.aTypeComboBox = new System.Windows.Forms.ComboBox();
            this.aBreedComboBox = new System.Windows.Forms.ComboBox();
            this.aSexComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.chipNumTextBox = new System.Windows.Forms.TextBox();
            this.neuteredCheckBox = new System.Windows.Forms.CheckBox();
            this.dangerousCheckBox = new System.Windows.Forms.CheckBox();
            this.seeingEyeDogCheckBox = new System.Windows.Forms.CheckBox();
            this.firstVisitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            custNumLabel = new System.Windows.Forms.Label();
            aNameLabel = new System.Windows.Forms.Label();
            aTypeLabel = new System.Windows.Forms.Label();
            aBreedLabel = new System.Windows.Forms.Label();
            aSexLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            chipNumLabel = new System.Windows.Forms.Label();
            neuteredLabel = new System.Windows.Forms.Label();
            dangerousLabel = new System.Windows.Forms.Label();
            seeingEyeDogLabel = new System.Windows.Forms.Label();
            firstVisitLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // custNumLabel
            // 
            custNumLabel.AutoSize = true;
            custNumLabel.Location = new System.Drawing.Point(18, 24);
            custNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            custNumLabel.Name = "custNumLabel";
            custNumLabel.Size = new System.Drawing.Size(228, 18);
            custNumLabel.TabIndex = 1;
            custNumLabel.Text = "הוספת חיה חדשה עבור לקוח מספר:";
            // 
            // aNameLabel
            // 
            aNameLabel.AutoSize = true;
            aNameLabel.Location = new System.Drawing.Point(18, 75);
            aNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aNameLabel.Name = "aNameLabel";
            aNameLabel.Size = new System.Drawing.Size(33, 18);
            aNameLabel.TabIndex = 3;
            aNameLabel.Text = "שם:";
            // 
            // aTypeLabel
            // 
            aTypeLabel.AutoSize = true;
            aTypeLabel.Location = new System.Drawing.Point(18, 135);
            aTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aTypeLabel.Name = "aTypeLabel";
            aTypeLabel.Size = new System.Drawing.Size(57, 18);
            aTypeLabel.TabIndex = 5;
            aTypeLabel.Text = "סוג חיה:";
            // 
            // aBreedLabel
            // 
            aBreedLabel.AutoSize = true;
            aBreedLabel.Location = new System.Drawing.Point(18, 196);
            aBreedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aBreedLabel.Name = "aBreedLabel";
            aBreedLabel.Size = new System.Drawing.Size(32, 18);
            aBreedLabel.TabIndex = 7;
            aBreedLabel.Text = "גזע:";
            // 
            // aSexLabel
            // 
            aSexLabel.AutoSize = true;
            aSexLabel.Location = new System.Drawing.Point(18, 255);
            aSexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aSexLabel.Name = "aSexLabel";
            aSexLabel.Size = new System.Drawing.Size(28, 18);
            aSexLabel.TabIndex = 9;
            aSexLabel.Text = "מין:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(18, 311);
            colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(37, 18);
            colorLabel.TabIndex = 11;
            colorLabel.Text = "צבע:";
            // 
            // chipNumLabel
            // 
            chipNumLabel.AutoSize = true;
            chipNumLabel.Location = new System.Drawing.Point(18, 372);
            chipNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            chipNumLabel.Name = "chipNumLabel";
            chipNumLabel.Size = new System.Drawing.Size(81, 18);
            chipNumLabel.TabIndex = 13;
            chipNumLabel.Text = "מספר שבב:";
            // 
            // neuteredLabel
            // 
            neuteredLabel.AutoSize = true;
            neuteredLabel.Location = new System.Drawing.Point(348, 75);
            neuteredLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            neuteredLabel.Name = "neuteredLabel";
            neuteredLabel.Size = new System.Drawing.Size(56, 18);
            neuteredLabel.TabIndex = 15;
            neuteredLabel.Text = "מסורס?";
            // 
            // dangerousLabel
            // 
            dangerousLabel.AutoSize = true;
            dangerousLabel.Location = new System.Drawing.Point(348, 117);
            dangerousLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dangerousLabel.Name = "dangerousLabel";
            dangerousLabel.Size = new System.Drawing.Size(49, 18);
            dangerousLabel.TabIndex = 17;
            dangerousLabel.Text = "מסוכן?";
            // 
            // seeingEyeDogLabel
            // 
            seeingEyeDogLabel.AutoSize = true;
            seeingEyeDogLabel.Location = new System.Drawing.Point(348, 159);
            seeingEyeDogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seeingEyeDogLabel.Name = "seeingEyeDogLabel";
            seeingEyeDogLabel.Size = new System.Drawing.Size(73, 18);
            seeingEyeDogLabel.TabIndex = 19;
            seeingEyeDogLabel.Text = "כלב נחיה?";
            // 
            // firstVisitLabel
            // 
            firstVisitLabel.AutoSize = true;
            firstVisitLabel.Location = new System.Drawing.Point(348, 193);
            firstVisitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstVisitLabel.Name = "firstVisitLabel";
            firstVisitLabel.Size = new System.Drawing.Size(82, 18);
            firstVisitLabel.TabIndex = 21;
            firstVisitLabel.Text = "ביקור ראשון:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(348, 308);
            remarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(51, 18);
            remarksLabel.TabIndex = 23;
            remarksLabel.Text = "הערות:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(348, 230);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(82, 18);
            dateOfBirthLabel.TabIndex = 25;
            dateOfBirthLabel.Text = "תאריך לידה:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label7.Location = new System.Drawing.Point(12, 433);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(55, 14);
            label7.TabIndex = 46;
            label7.Text = "שדה חובה";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Location = new System.Drawing.Point(2, 433);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(14, 18);
            label6.TabIndex = 45;
            label6.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(7, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 18);
            label1.TabIndex = 47;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(7, 137);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 18);
            label2.TabIndex = 48;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(7, 198);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 18);
            label3.TabIndex = 49;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(7, 257);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(14, 18);
            label4.TabIndex = 50;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(7, 314);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 51;
            label5.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(348, 268);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 18);
            label8.TabIndex = 52;
            label8.Text = "תאריך סירוס:";
            // 
            // vetclinicDataSet
            // 
            this.vetclinicDataSet.DataSetName = "vetclinicDataSet";
            this.vetclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblanimalBindingSource
            // 
            this.tblanimalBindingSource.DataMember = "tblanimal";
            this.tblanimalBindingSource.DataSource = this.vetclinicDataSet;
            // 
            // tblanimalTableAdapter
            // 
            this.tblanimalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GetInfoForStockUpdateTableAdapter = null;
            this.tableAdapterManager.tblanimalTableAdapter = this.tblanimalTableAdapter;
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
            // custNumLabel1
            // 
            this.custNumLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "custNum", true));
            this.custNumLabel1.Location = new System.Drawing.Point(277, 24);
            this.custNumLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custNumLabel1.Name = "custNumLabel1";
            this.custNumLabel1.Size = new System.Drawing.Size(120, 32);
            this.custNumLabel1.TabIndex = 2;
            this.custNumLabel1.Text = "label1";
            // 
            // aNameTextBox
            // 
            this.aNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "aName", true));
            this.aNameTextBox.Location = new System.Drawing.Point(102, 72);
            this.aNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aNameTextBox.Name = "aNameTextBox";
            this.aNameTextBox.Size = new System.Drawing.Size(199, 26);
            this.aNameTextBox.TabIndex = 4;
            // 
            // aTypeComboBox
            // 
            this.aTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "aType", true));
            this.aTypeComboBox.FormattingEnabled = true;
            this.aTypeComboBox.Items.AddRange(new object[] {
            "כלב",
            "חתול",
            "ארנב",
            "חמוס",
            "אוגר",
            "תוכי",
            "שרקן"});
            this.aTypeComboBox.Location = new System.Drawing.Point(102, 132);
            this.aTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aTypeComboBox.Name = "aTypeComboBox";
            this.aTypeComboBox.Size = new System.Drawing.Size(199, 26);
            this.aTypeComboBox.TabIndex = 6;
            // 
            // aBreedComboBox
            // 
            this.aBreedComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "aBreed", true));
            this.aBreedComboBox.FormattingEnabled = true;
            this.aBreedComboBox.Items.AddRange(new object[] {
            "מעורב",
            "דלמטי",
            "פרסי",
            "בוקסר",
            "יוקשייר",
            "לברדור",
            "ויסלו",
            "ונאימר",
            "פינצ\'ר",
            "פודל ננסי",
            "גולדן רטריוור",
            "זאב",
            "רועה גרמני",
            "הסקי סיבירי",
            "כלב בורדו",
            "דני",
            "שאר-פאי",
            "אמסטף",
            "בול טרייר",
            "צ\'או צ\'או",
            "פודל",
            "פודל ענק",
            "פרסי מעורב",
            "טרייר",
            "פיטבול",
            "טרייר מעורב",
            "פינצ\'ר מעורב",
            "הש פאפי",
            "רוטוילר",
            "דוברמן",
            "בולדוג",
            "בולדוג צרפתי",
            "מופס (פאג)",
            "פקינז",
            "קוקר ספנייל",
            "סמוייד",
            "בירמנז",
            "סיאמי",
            "ריצ\'בק"});
            this.aBreedComboBox.Location = new System.Drawing.Point(102, 193);
            this.aBreedComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aBreedComboBox.Name = "aBreedComboBox";
            this.aBreedComboBox.Size = new System.Drawing.Size(199, 26);
            this.aBreedComboBox.TabIndex = 8;
            // 
            // aSexComboBox
            // 
            this.aSexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "aSex", true));
            this.aSexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aSexComboBox.FormattingEnabled = true;
            this.aSexComboBox.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.aSexComboBox.Location = new System.Drawing.Point(102, 252);
            this.aSexComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aSexComboBox.Name = "aSexComboBox";
            this.aSexComboBox.Size = new System.Drawing.Size(104, 26);
            this.aSexComboBox.TabIndex = 10;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "color", true));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "אפור",
            "אפור לבן",
            "אפור שחור",
            "אפור חום",
            "אפרסק",
            "בז\'",
            "ג\'ינג\'י",
            "חום",
            "חום אפור",
            "חום לבן",
            "חום שחור",
            "טריקולור",
            "לבן",
            "לבן ג\'ינג\'י",
            "לבן מנומר",
            "לבן שחור",
            "מנומר",
            "קרם",
            "שחור",
            "שחור חום",
            "שחור לבן",
            "שחור מנומר"});
            this.colorComboBox.Location = new System.Drawing.Point(102, 308);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(199, 26);
            this.colorComboBox.TabIndex = 12;
            // 
            // chipNumTextBox
            // 
            this.chipNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "chipNum", true));
            this.chipNumTextBox.Location = new System.Drawing.Point(102, 369);
            this.chipNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chipNumTextBox.Name = "chipNumTextBox";
            this.chipNumTextBox.Size = new System.Drawing.Size(199, 26);
            this.chipNumTextBox.TabIndex = 14;
            // 
            // neuteredCheckBox
            // 
            this.neuteredCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblanimalBindingSource, "neutered", true));
            this.neuteredCheckBox.Location = new System.Drawing.Point(428, 69);
            this.neuteredCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.neuteredCheckBox.Name = "neuteredCheckBox";
            this.neuteredCheckBox.Size = new System.Drawing.Size(300, 33);
            this.neuteredCheckBox.TabIndex = 16;
            this.neuteredCheckBox.UseVisualStyleBackColor = true;
            this.neuteredCheckBox.Click += new System.EventHandler(this.neuteredCheckBox_Click);
            // 
            // dangerousCheckBox
            // 
            this.dangerousCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblanimalBindingSource, "dangerous", true));
            this.dangerousCheckBox.Location = new System.Drawing.Point(428, 110);
            this.dangerousCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.dangerousCheckBox.Name = "dangerousCheckBox";
            this.dangerousCheckBox.Size = new System.Drawing.Size(300, 33);
            this.dangerousCheckBox.TabIndex = 18;
            this.dangerousCheckBox.UseVisualStyleBackColor = true;
            // 
            // seeingEyeDogCheckBox
            // 
            this.seeingEyeDogCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblanimalBindingSource, "seeingEyeDog", true));
            this.seeingEyeDogCheckBox.Location = new System.Drawing.Point(449, 155);
            this.seeingEyeDogCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.seeingEyeDogCheckBox.Name = "seeingEyeDogCheckBox";
            this.seeingEyeDogCheckBox.Size = new System.Drawing.Size(300, 33);
            this.seeingEyeDogCheckBox.TabIndex = 20;
            this.seeingEyeDogCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstVisitDateTimePicker
            // 
            this.firstVisitDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblanimalBindingSource, "firstVisit", true));
            this.firstVisitDateTimePicker.Enabled = false;
            this.firstVisitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstVisitDateTimePicker.Location = new System.Drawing.Point(469, 186);
            this.firstVisitDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.firstVisitDateTimePicker.Name = "firstVisitDateTimePicker";
            this.firstVisitDateTimePicker.Size = new System.Drawing.Size(133, 26);
            this.firstVisitDateTimePicker.TabIndex = 22;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblanimalBindingSource, "remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(450, 304);
            this.remarksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(171, 69);
            this.remarksTextBox.TabIndex = 24;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblanimalBindingSource, "dateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(469, 223);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(133, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vet_Clinic.Properties.Resources.שמירה_סגול;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(351, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "     שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Vet_Clinic.Properties.Resources.בטל_כתום;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(520, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "בטל";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(308, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(308, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 23);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(308, 308);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 23);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblanimalBindingSource, "dateOfBirth", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 261);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Vet_Clinic.Properties.Resources._120px_Red_X_svg;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(607, 262);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 23);
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(634, 456);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label8);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(custNumLabel);
            this.Controls.Add(this.custNumLabel1);
            this.Controls.Add(aNameLabel);
            this.Controls.Add(this.aNameTextBox);
            this.Controls.Add(aTypeLabel);
            this.Controls.Add(this.aTypeComboBox);
            this.Controls.Add(aBreedLabel);
            this.Controls.Add(this.aBreedComboBox);
            this.Controls.Add(aSexLabel);
            this.Controls.Add(this.aSexComboBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(chipNumLabel);
            this.Controls.Add(this.chipNumTextBox);
            this.Controls.Add(neuteredLabel);
            this.Controls.Add(this.neuteredCheckBox);
            this.Controls.Add(dangerousLabel);
            this.Controls.Add(this.dangerousCheckBox);
            this.Controls.Add(seeingEyeDogLabel);
            this.Controls.Add(this.seeingEyeDogCheckBox);
            this.Controls.Add(firstVisitLabel);
            this.Controls.Add(this.firstVisitDateTimePicker);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAnimal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת חיה ללקוח";
            this.Load += new System.EventHandler(this.AddAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vetclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vetclinicDataSet vetclinicDataSet;
        private System.Windows.Forms.BindingSource tblanimalBindingSource;
        private vetclinicDataSetTableAdapters.tblanimalTableAdapter tblanimalTableAdapter;
        private vetclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label custNumLabel1;
        private System.Windows.Forms.TextBox aNameTextBox;
        private System.Windows.Forms.ComboBox aTypeComboBox;
        private System.Windows.Forms.ComboBox aBreedComboBox;
        private System.Windows.Forms.ComboBox aSexComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.TextBox chipNumTextBox;
        private System.Windows.Forms.DateTimePicker firstVisitDateTimePicker;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        public System.Windows.Forms.CheckBox neuteredCheckBox;
        public System.Windows.Forms.CheckBox dangerousCheckBox;
        public System.Windows.Forms.CheckBox seeingEyeDogCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}