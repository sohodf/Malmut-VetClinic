using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Vet_Clinic;
using Vet_Clinic.vetclinicDataSetTableAdapters;


namespace Project1
{
    public partial class Start : Form
    {

        // mysql connection string

        MySqlConnection connection = new MySqlConnection(utils.MyConString);
        // end connection string
        public static bool vacExp = false;
        public static bool purchaseDates = false;
        public static bool customerPurchase = false;
        public static bool ramatYohanan = false;

        // fill listbox with lase 20 visitors

        public void FillNames()
        {
            listBox1.Items.Clear();
            int[] lastCustomers = new int[20];
            int i = 0;

            MySqlCommand command2 = connection.CreateCommand();
            MySqlDataReader Reader2;
            command2.CommandText = "SELECT distinct custNum FROM tblvisit ORDER BY vDate desc LIMIT 20";
            connection.Open();
            Reader2 = command2.ExecuteReader();
            while (Reader2.Read())
            {
                lastCustomers[i] = Reader2.GetInt32(0);
                i++;
            }

            connection.Close();

            for (int n = 0; n < 20; n++)
            {
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select distinct firstName, lastName, custNum from tblcustomer WHERE custNum = @custNum";
                command.Parameters.Add("@custNum", lastCustomers[n]);
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int m = 0; m < Reader.FieldCount; m++)
                        thisrow += Reader.GetValue(m).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                connection.Close();
            }

        }

        // fill listbox with all names who has animals
        public void FillNames2()
        {
            listBox1.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select distinct firstName, lastName, C.custNum from tblcustomer C INNER JOIN tblanimal A ON C.custNum = A.custNum";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox1.Items.Add(thisrow);
            }
            connection.Close();
        }

        // fill listbox with all names who has animals
        public void FillProducts()
        {
            listBox7.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select name from tblProducts";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox7.Items.Add(thisrow);
            }
            connection.Close();
        }

        // removes all tabs but main search tab

        public void CloseAllButSearchTab()
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
        }

        public void ClearSelection()
        {
            if (comboBox1.Text != "" || textBox3.Text != "" || checkBox1.Checked == true || textBox8.Text != "" || textBox9.Text != "")
            {
                if (MessageBox.Show("?קיימים נתוני ביקור לא שמורים, האם אתה בטוח שברצונך לצאת", "",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.No)
                    return;
                else
                {
                    SwitchCust();
                }
            }
            else
            {
                SwitchCust();
            }
            
        }

        public void GetNotifications()
        {

            textBox11.Text = "";
            DateTime today = DateTime.Today;
            string formatForMySql = today.ToString("yyyy-MM-dd hh:mm:ss");
            this.tblnotificationsTableAdapter.FillByCurrent(this.vetclinicDataSet.tblnotifications, formatForMySql);
        }

        public Start()
        {
            utils.StartService("MySQL55", 30000);
            checkConn();
            InitializeComponent();
            FillNames();
            CloseAllButSearchTab();
            GetNotifications();
            label24.Text = DateTime.Today.Date.ToShortDateString();
            FillProducts();
        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
            label36.Text = "לא נבחרה חיה";
            listBox2.Items.Clear();
            string custNum = null;
            string custName = null;
            try
            {
                custNum = utils.ExtractNumbers(listBox1.SelectedItem.ToString());
                label63.Text = custNum;
                custName = utils.RemoveDigits(listBox1.SelectedItem.ToString());
                label35.Text = custName;
                this.tblcustomerTableAdapter.FillByCustNum(this.vetclinicDataSet.tblcustomer, int.Parse(label63.Text));
            }
            catch (Exception exc)
            {
                // MessageBox.Show("חובה לבחור לקוח", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseAllButSearchTab();
            if (listBox1.SelectedIndex != -1)
                tabControl1.TabPages.Add(tabPage4);

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select aName from tblanimal where custNum = '" + custNum + "'";
            connection.Open();

            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox2.Items.Add(thisrow);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        // Search by costumer number
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            listBox2.Items.Clear();

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select firstName, lastName, custNum from tblcustomer where custNum LIKE @param";
            command.Parameters.AddWithValue("@param", textBox5.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox1.Items.Add(thisrow);
            }
            connection.Close();
        }

        // search by costumer first name

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox2.Text == "")
            {
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";

                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select firstName, lastName, custNum from tblcustomer where firstName LIKE @param";
                command.Parameters.AddWithValue("@param", textBox1.Text + "%");
                connection.Open();
                Reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                connection.Close();
            }
            else
            {
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select firstName, lastName, custNum from tblcustomer where firstName LIKE @param and lastName like @param2";
                command.Parameters.AddWithValue("@param", textBox1.Text + "%");
                command.Parameters.AddWithValue("@param2", textBox2.Text + "%");
                connection.Open();
                Reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                connection.Close();
            }

        }



        // search by street name

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select firstName, lastName, custNum from tblcustomer where address LIKE @param";
            command.Parameters.AddWithValue("@param", "%" + textBox4.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox1.Items.Add(thisrow);
            }
            connection.Close();
        }

        // search by phone number (either cell or home is ok)

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox7.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select firstName, lastName, custNum from tblcustomer where homePhone LIKE @param or cellPhone like @param";
            command.Parameters.AddWithValue("@param", textBox6.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox1.Items.Add(thisrow);
            }
            connection.Close();
        }

        //search by last name

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox1.Text == "")
            {
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";

                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select firstName, lastName, custNum from tblcustomer where lastName LIKE @param";
                command.Parameters.AddWithValue("@param", textBox2.Text + "%");
                connection.Open();
                Reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                connection.Close();
            }
            else
            {
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select firstName, lastName, custNum from tblcustomer where firstName LIKE @param and lastName like @param2";
                command.Parameters.AddWithValue("@param", textBox1.Text + "%");
                command.Parameters.AddWithValue("@param2", textBox2.Text + "%");
                connection.Open();
                Reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    listBox1.Items.Add(thisrow);
                }
                connection.Close();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabPage2.Refresh();
            tabControl1.TabPages.Remove(tabPage4);
            listBox1.Items.Clear();
            label35.Text = "";
            label63.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select distinct aName from tblanimal where chipNum LIKE @param";
            command.Parameters.AddWithValue("@param", textBox7.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString();
                listBox2.Items.Add(thisrow);
            }
            connection.Close();
        }


        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (label36.Text != null)
                    label36.Text = listBox2.SelectedItem.ToString();
                tabControl1.TabPages.Remove(tabPage2);
                if (listBox1.SelectedIndex != -1)
                    tabControl1.TabPages.Add(tabPage2);
            }

            catch (Exception exc)
            {
                //  MessageBox.Show("חובה לבחור חיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (listBox1.SelectedIndex == -1)
            {
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select custNum from tblanimal where chipNum LIKE @param and aName = @param2";
                command.Parameters.AddWithValue("@param", textBox7.Text + "%");
                command.Parameters.AddWithValue("@param2", listBox2.SelectedItem);
                connection.Open();
                List<String> custNum = new List<String>();

                Reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    for (int i = 0; i < Reader.FieldCount; i++)
                        custNum.Add(Reader.GetValue(i).ToString());
                }

                connection.Close();


                MySqlCommand command2 = connection.CreateCommand();
                MySqlDataReader Reader2;
                listBox1.Items.Clear();

                for (int j = 0; j < custNum.Count; j++)
                {
                    connection.Open();
                    command2.CommandText = "select firstName, lastName, custNum from tblcustomer where custNum = '" +
                                           custNum[j] + "'";
                    Reader2 = command2.ExecuteReader();

                    while (Reader2.Read())
                    {
                        string thisrow = "";
                        for (int i = 0; i < Reader2.FieldCount; i++)
                            thisrow += Reader2.GetValue(i).ToString() + " ";
                        listBox1.Items.Add(thisrow);
                    }
                    connection.Close();

                }

            }
            else
            {
                if (label63.Text != "לא נבחר לקוח" && label63.Text != "")
                {
                    // TODO: This line of code loads data into the 'vetclinicDataSet.tblanimal' table. You can move, or remove it, as needed.
                    this.tblanimalTableAdapter.FillByDetails(this.vetclinicDataSet.tblanimal, int.Parse(label63.Text), label36.Text);
                    this.tblvisitTableAdapter.FillByCustAnimal(this.vetclinicDataSet.tblvisit, int.Parse(label63.Text), label36.Text);
                    //vDetailsTextBox.Enabled = false;
                    getInsDate();
                    checkBox1.CheckState = CheckState.Unchecked;
                    lastVacs lv = new lastVacs(Int32.Parse(label63.Text), label36.Text, this);
                    lv.Close();
                    if (label36.Text != "לא נבחרה חיה" && label36.Text != "")
                    {
                        updateAge();
                        vetclinicDataSet.tblanimalRow custRow;
                        custRow = vetclinicDataSet.tblanimal.FindBycustNumaName(int.Parse(label63.Text), label36.Text);
                        if (custRow.dateNeu.ToShortDateString() == "01/01/1950")
                            dateNeuDateTimePicker.Hide();
                        else dateNeuDateTimePicker.Visible = true;
                    }

                }
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                tabControl1.SelectedTab = tabPage4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearSelection();
            if (edit)
            {
                button9.Text = "שמירה";
                edit = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditCostumer ec = new EditCostumer(this, int.Parse(label63.Text));
            ec.Visible = true;
        }

      
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                tabControl1.SelectedTab = tabPage2;
        }


        private void checkConn()  //checks if the connection is ok
        {
            try
            {
                connection.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show("לא ניתן להתחבר לבסיס הנתונים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            ClearSelection();
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            listBox2.Items.Clear();
            CloseAllButSearchTab();
            FillNames();
        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            long maxVisit = 0;
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "SELECT MAX(vNum) as lastV FROM tblVisit";
            connection.Open();
            String temp = command.ExecuteScalar().ToString();
            if (temp == "")
                maxVisit = 1;
            else
                maxVisit = Int64.Parse(temp) + 1;
            connection.Close();
            maxVisit++;
            vNumLabel1.Text = maxVisit.ToString();

        }


        public void clearVisit()
        {
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            checkBox1.Checked = false;
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                edit = false;
                bindingNavigatorMoveNextItem1.Enabled = true;
                bindingNavigatorMovePreviousItem1.Enabled = true;
                bindingNavigatorMoveFirstItem1.Enabled = true;
                bindingNavigatorMoveLastItem1.Enabled = true;
                
            }

            clearVisit();
            EnableSearch();
            button9.Text = "שמירה";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string errors = ":שגיאה! פרטים שגויים או חסרים פרטים";
            errors += "\n";
            Boolean errorFound = false;

            double result;

            if (comboBox1.SelectedIndex == -1)
            {
                errors += "\n";
                errors += "חובה לבחור סיבה לביקור";
                errorFound = true;

            }

            //if (textBox9.Text == "")
            //{

            //    errors += "\n";
            //    errors += "חובה להזין פרטי טיפול";
            //    errorFound = true;

            //}

            if (textBox8.Text != "")
            {
                if (!double.TryParse(textBox8.Text, out result))
                {
                    errors += "\n";
                    errors += "מחיר חייב להיות מספר";
                    errorFound = true;
                }
            }

            if (textBox3.Text != "")
            {
                if (double.TryParse(textBox3.Text, out result))
                    if (double.Parse(textBox3.Text) > 99 || double.Parse(textBox3.Text) < 0)
                    {
                        errors += "\n";
                        errors += "משקל לא תקין";
                        errorFound = true;
                    }
            }

            if (textBox3.Text != "")
            {
                if (!double.TryParse(textBox3.Text, out result))
                {
                    errors += "\n";
                    errors += "משקל חייב להיות מספר";
                    errorFound = true;
                }
            }

            if (errorFound)
                MessageBox.Show(errors);
            else
            {
                if (!edit)
                {
                    long maxVisit = 0;
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command2.CommandText = "SELECT MAX(vNum) as lastV FROM tblVisit";
                    connection.Open();
                    String temp = command2.ExecuteScalar().ToString();
                    if (temp == "")
                        maxVisit = 1;
                    else
                        maxVisit = Int64.Parse(temp) + 1;
                    connection.Close();
                    double weight;
                    if (textBox3.Text == "")
                        weight = 0;
                    else
                        weight = double.Parse(textBox3.Text);

                    double price;
                    if (textBox8.Text == "")
                        price = 0;
                    else
                        price = double.Parse(textBox8.Text);

                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO tblVisit (Vnum, custNum, aName, vDate, vDetails, vaccine, weight, paymentStatus, reason, price) Values (@vNum, @custNum, @aName, @vDate, @vDetails, @vaccine, @weight, @paymentStatus, @reason, @price)";
                    command.Parameters.AddWithValue("@vNum", maxVisit);
                    command.Parameters.AddWithValue("@custNum", label63.Text);
                    command.Parameters.AddWithValue("@aName", label36.Text);
                    command.Parameters.AddWithValue("@vDate", DateTime.Now);
                    command.Parameters.AddWithValue("@vDetails", textBox9.Text);
                    command.Parameters.AddWithValue("@vaccine", checkBox1.Checked);
                    command.Parameters.AddWithValue("@weight", weight);
                    command.Parameters.AddWithValue("@paymentStatus", 0);
                    command.Parameters.AddWithValue("@reason", comboBox1.Text);
                    command.Parameters.AddWithValue("@price", price);
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                    clearVisit();
                    EnableSearch();
                    this.tblvisitTableAdapter.FillByCustAnimal(this.vetclinicDataSet.tblvisit, int.Parse(label63.Text), label36.Text);
                    OpenBasket(int.Parse(label63.Text));
                }
                
                else
                {
                    edit = false;
                    double weight2;
                    if (textBox3.Text == "")
                        weight2 = 0;
                    else
                        weight2 = double.Parse(textBox3.Text);

                    double price2;
                    if (textBox8.Text == "")
                        price2 = 0;
                    else
                        price2 = double.Parse(textBox8.Text);

                    vetclinicDataSet.tblvisitRow upVis;
                    upVis = vetclinicDataSet.tblvisit.FindByvNumcustNumaName(Int64.Parse(vNumLabel1.Text),
                                                                             int.Parse(label63.Text), label36.Text);
                    upVis.reason = comboBox1.Text;
                    upVis.weight = weight2;
                    upVis.vaccine = checkBox1.Checked;
                    upVis.price = price2;
                    upVis.vDetails = textBox9.Text;
                    
                    this.tblvisitTableAdapter.Update(this.vetclinicDataSet.tblvisit);
                    
                    button9.Text = "שמירה";
                    clearVisit();
                    EnableSearch();
                    bindingNavigatorMoveNextItem1.Enabled = true;
                    bindingNavigatorMovePreviousItem1.Enabled = true;
                    bindingNavigatorMoveFirstItem1.Enabled = true;
                    bindingNavigatorMoveLastItem1.Enabled = true;
                    label52.Text = this.tblvisitTableAdapter.ScalarQueryTreatPay(int.Parse(label63.Text)).ToString();
                    this.tblvisitTableAdapter.FillByCustAnimal(this.vetclinicDataSet.tblvisit, int.Parse(label63.Text), label36.Text);
                }
            }
        }

        //adds a vaccine to tblgivenvaccine
        private void addVac(string vacType, long maxVisit)
        {
            MySqlCommand command4 = connection.CreateCommand();
            command4.CommandText =
                "INSERT INTO tblgivenvaccine (aName, Vnum, custNum, type, dateGiven) Values (@aName, @vNum, @custNum, @type, @dateGiven)";
            command4.Parameters.AddWithValue("@aName", label36.Text);
            command4.Parameters.AddWithValue("@vNum", maxVisit);
            command4.Parameters.AddWithValue("@custNum", label63.Text);
            command4.Parameters.AddWithValue("@type", vacType);
            command4.Parameters.AddWithValue("@dateGiven", DateTime.Now);
            connection.Open();
            command4.ExecuteReader();
            connection.Close();
            this.tblgivenvaccineTableAdapter.FillByvNum(this.vetclinicDataSet.tblgivenvaccine, maxVisit);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label63.Text == "")
                MessageBox.Show("חובה לבחור לקוח", "שגיאה");
            else
            {
                AddAnimal aa = new AddAnimal(int.Parse(label63.Text), this);
                aa.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editAnimal ea = new editAnimal(int.Parse(label63.Text), label36.Text, this);
            ea.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addCustomer ac = new addCustomer(this);
            ac.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (vNumLabel1.Text != "" && vNumLabel1.Text != "label6")
            {
                viewVac vv = new viewVac(long.Parse(vNumLabel1.Text));
                vv.Visible = true;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם להזין חבילת בריאות", "",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText =
                    "INSERT INTO tblinsurance Values (@custNum, @aName, @fromDate, @toDate)";
                command.Parameters.AddWithValue("@custNum", int.Parse(label63.Text));
                command.Parameters.AddWithValue("@aName", label36.Text);
                command.Parameters.AddWithValue("@fromDate", DateTime.Now);
                command.Parameters.AddWithValue("@toDate", DateTime.Now.AddYears(1));
                connection.Open();
                command.ExecuteReader();
                connection.Close();
                MessageBox.Show("חבילה הוזנה בהצלחה");
                getInsDate();
            }
        }

        //gets the date when the insurance expires
        public void getInsDate()
        {
            label11.Text = "";
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select MAX(toDate) from tblinsurance where custNum = @custNum AND aName = @aName";
            command.Parameters.AddWithValue("@custNum", int.Parse(label63.Text));
            command.Parameters.AddWithValue("@aName", label36.Text);
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                if (thisrow != " ")
                {
                    DateTime theDate = DateTime.Parse(thisrow);
                    string theShortDate = theDate.ToShortDateString();
                    label11.Text = theShortDate;
                    if (theDate < DateTime.Now)
                        label11.Visible = false;
                    else
                    {
                        label11.Visible = true;
                        label11.ForeColor = Color.Navy;
                    }
                }
            }
            connection.Close();
        }

        private void יציאהToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            utils.StopService("MySQL55", 20000);
            this.Close();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            enterVac2 ev2 = new enterVac2(Int32.Parse(label63.Text), label36.Text, this);
            ev2.Visible = true;
            checkBox1.Checked = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lastVacs lv = new lastVacs(Int32.Parse(label63.Text), label36.Text, this);
            lv.Visible = true;
        }

        private void דוחללקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void כלבתToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void רשיוןלכלבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "rabies.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                kalevetRpt kr = new kalevetRpt();

                kr.setReport(report);
                kr.ShowDialog();
            }
        }

        public void updateAge()
        {
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "SELECT dateOfBirth FROM tblAnimal WHERE custNum = @cNum AND aName = @aName";
            command.Parameters.AddWithValue("cNum", label63.Text);
            command.Parameters.AddWithValue("aName", label36.Text);
            connection.Open();
            String temp = command.ExecuteScalar().ToString();
            DateTime DOB = DateTime.Parse(temp);
            DateTime now = DateTime.Now;
            int age = now.Year - DOB.Year;
            if (now < DOB.AddYears(age)) age--;

            label18.Text = age.ToString();
            connection.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void מחיקתתיקלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (label63.Text == "לא נבחר לקוח")
            {
                MessageBox.Show("חובה לבחור לקוח", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string text = "האם אתה בטוח שברצונך למחוק את לקוח מספר ";
                text += label63.Text;
                text += " מהמערכת?";
                text += "\n";
                text += "פעולה זאת לא ניתנת לביטול";

                if (MessageBox.Show(text, "",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.No)
                    return;
                else
                {
                    vetclinicDataSet.tblcustomerRow custRow;
                    custRow = vetclinicDataSet.tblcustomer.FindBycustNum(int.Parse(label63.Text));
                    custRow.Delete();
                    this.tblcustomerTableAdapter.Update(this.vetclinicDataSet.tblcustomer);
                    string text2 = "לקוח מספר ";
                    text2 += label63.Text;
                    text2 += " נמחק בהצלחה מהמערכת";
                    MessageBox.Show(text2);
                    ClearSelection();

                }
            }
        }

        private void מחיקתחיהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string text3 = "האם אתה בטוח שברצונך למחוק את החיה  ";
                text3 += label36.Text;
                text3 += " של לקוח מספר ";
                text3 += label63.Text;
                text3 += " מהמערכת?";
                text3 += "\n";
                text3 += "פעולה זאת לא ניתנת לביטול";
                if (MessageBox.Show(text3, "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                                    MessageBoxOptions.RightAlign) == DialogResult.No)
                    return;
                else
                {
                    vetclinicDataSet.tblanimalRow anRow;
                    anRow = vetclinicDataSet.tblanimal.FindBycustNumaName(int.Parse(label63.Text), label36.Text);
                    anRow.Delete();
                    this.tblanimalTableAdapter.Update(this.vetclinicDataSet.tblanimal);
                    string text2 = "החיה ";
                    text2 += label36.Text;
                    text2 += " נמחקה בהצלחה מהמערכת";
                    MessageBox.Show(text2);
                    ClearSelection();

                }
            }


        }

        private void רישיוןכלבתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "dogLicense.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                licenseRpt Lr = new licenseRpt();

                Lr.setReport(report);
                Lr.ShowDialog();
                
            }
        }

        private void תזכורתחיסוניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterVacExpDates EV = new EnterVacExpDates(0);
            EV.Visible = true;
            vacExp = true;
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            utils.StopService("MySQL55", 20000);
        }

        private void dateNeuLabel_Click(object sender, EventArgs e)
        {

        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {
            changeIns CI = new changeIns(this);
            CI.Visible = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabPage2.Refresh();
            tabControl1.TabPages.Remove(tabPage4);
            listBox1.Items.Clear();
            label35.Text = "";
            label63.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select distinct aName from tblanimal where aName LIKE @param";
            command.Parameters.AddWithValue("@param", textBox10.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString();
                listBox2.Items.Add(thisrow);
            }
            connection.Close();
        }

        private void אישורהרדמהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "anesthesia.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                AnesthesiaRpt AR = new AnesthesiaRpt();

                AR.setReport(report);
                AR.ShowDialog();

            }
        }

        private void אישורסירוסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "castration.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                CastrationRpt CR = new CastrationRpt();

                CR.setReport(report);
                CR.ShowDialog();

            }
        }

        private void המתתחסדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "eutenasiaempty.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                EutenasiaemptyRpt ER = new EutenasiaemptyRpt();

                ER.setReport(report);
                ER.ShowDialog();

            }
        }

        //disable all search options
        public void DisableSearch()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox10.Enabled = false;
            listBox1.Enabled = false;
        }

        //enable all search options
        public void EnableSearch()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox10.Enabled = true;
            listBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableSearch();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DisableSearch();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DisableSearch();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DisableSearch();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DisableSearch();
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            DisableSearch();
        }

        //clears and enables all search and boxes when switching customers
        public void SwitchCust()
        {
            label35.Text = "לא נבחר לקוח";
            label63.Text = "לא נבחר לקוח";
            label36.Text = "לא נבחרה חיה";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox10.Text = "";
            listBox2.Items.Clear();
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            checkBox1.Checked = false;
            textBox8.Text = "";
            textBox9.Text = "";
            FillNames();
            EnableSearch();
            tabControl1.SelectedTab = tabPage1;
            CloseAllButSearchTab();
        }
        
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (textBox5.Enabled == false)
                MessageBox.Show("שים לב! לא ניתן לחפש לקוח או חיה חדשים לפני ביטול בחירה קודמת", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void חבילתבריאותToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "healthPackage2.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                healthPackageF HP = new healthPackageF();

                HP.setReport(report);
                HP.ShowDialog();

            }
        
        }

        public bool edit = false;
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                edit = true;

                bindingNavigatorMoveNextItem1.Enabled = false;
                bindingNavigatorMovePreviousItem1.Enabled = false;
                bindingNavigatorMoveFirstItem1.Enabled = false;
                bindingNavigatorMoveLastItem1.Enabled = false;

                button9.Text = "עדכן";

                textBox3.Text = weightLabel1.Text;
                textBox8.Text = priceLabel1.Text;
                checkBox1.Checked = vaccineCheckBox.Checked;
                textBox9.Text = vDetailsTextBox.Text;
                comboBox1.Text = reasonLabel1.Text;


            }
        }

        private void תיקרפואיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "MedFile.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["custNum"];
                parameterField.CurrentValues.AddValue(label63.Text);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["aName"];
                parameterField2.CurrentValues.AddValue(label36.Text);

                MedFileRpt MF = new MedFileRpt();

                MF.setReport(report);
                MF.ShowDialog();

            }
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            textBox5.Text = listBox4.SelectedValue.ToString();
        }

        private void מחיקתטיפולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 3)
                MessageBox.Show("חובה להמצא בפרטי חיה כדי למחוק ביקור");
            else if (vNumLabel1.Text == "")
                MessageBox.Show("חובה לבחור ביקור למחיקה");
            else
            {
                string text = "האם אתה בטוח שברצונך למחוק את ביקור מספר ";
                text += vNumLabel1.Text;
                text += " מהמערכת?";
                text += "\n";
                text += "פעולה זאת לא ניתנת לביטול";

                if (MessageBox.Show(text, "",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.No)
                    return;
                else
                {
                    vetclinicDataSet.tblvisitRow visitRow;
                    visitRow = vetclinicDataSet.tblvisit.FindByvNumcustNumaName(int.Parse(vNumLabel1.Text), int.Parse(label63.Text), label36.Text);
                    visitRow.Delete();
                    this.tblvisitTableAdapter.Update(this.vetclinicDataSet.tblvisit);
                    string text2 = "ביקור מספר ";
                    text2 += vNumLabel1.Text;
                    text2 += " נמחק בהצלחה מהמערכת";
                    MessageBox.Show(text2);
                   
                }
            }

        }

        private void עריכהמחיקתחיסוניםToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void כלבתקריתאתאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterRabiesDates ER = new EnterRabiesDates();
            ER.Visible = true;
        }

        private void עריכהמחיקתחיסוניםToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (label63.Text == "לא נבחר לקוח" || label36.Text == "לא נבחרה חיה")
            {
                MessageBox.Show("חובה לבחור לקוח וחיה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ManageVaccines MV = new ManageVaccines(int.Parse(label63.Text), label36.Text);
                MV.Show();
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string notNum = listBox3.SelectedValue.ToString();
            if (notNum == null)
            {
                MessageBox.Show("לא סומנה התראה");
            }
            else
            {
                vetclinicDataSet.tblnotificationsRow notRow;
                notRow = vetclinicDataSet.tblnotifications.FindByNotNum(int.Parse(notNum));
                notRow.toDate = DateTime.Today.AddDays(-1);
                this.tblnotificationsTableAdapter.Update(this.vetclinicDataSet.tblnotifications);
                GetNotifications();
            }
            
                        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.tblnotificationsBindingSource.EndEdit();
            this.tblnotificationsTableAdapter.Update(this.vetclinicDataSet.tblnotifications);
            GetNotifications();
        }

        private void יצירתהתראהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNot CN = new CreateNot(this);
            CN.Show();
        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            {
                textBox13.Text = "";
                listBox7.Items.Clear();

                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select name from tblProducts where name LIKE @param";
                command.Parameters.AddWithValue("@param", textBox12.Text + "%");
                connection.Open();
                Reader = command.ExecuteReader();
                listBox7.Items.Clear();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    listBox7.Items.Add(thisrow);
                }
                connection.Close();
            }
        }


        private void listBox7_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            
            if (listBox7.SelectedItem != null)
            {
                try
                {

                    panel5.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button23.Visible = true;
                    textBox14.Text = "1";
                    textBox15.Text = "0";

                    this.tblproductsTableAdapter.FillByName(this.vetclinicDataSet.tblproducts,
                                                            listBox7.SelectedItem.ToString());

                }

                catch (Exception NoProductSelected)
                {

                }
            }


        }

        private void hideProductDetails()
        {
            panel5.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button23.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hideProductDetails();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int num = 0;
            int custNum = 0;

            if (!int.TryParse(textBox14.Text, out num) || int.Parse(textBox14.Text) <= 0)
                MessageBox.Show("כמות חייבת להיות מספר חיובי שלם");
            else if (!int.TryParse(textBox15.Text, out num))
                MessageBox.Show("הנחה חייבת להיות מספר שלם");
            else if (textBox14.Text == "" || textBox15.Text == "")
                MessageBox.Show("חובה להזין הנחה וכמות");
            else if (int.Parse(textBox15.Text) > 100 || int.Parse(textBox15.Text) < 0)
                MessageBox.Show("הנחה חייבת להיות מספר שלם בין 1 ל-100");
            else if (int.Parse(stockLabel2.Text)-int.Parse(textBox14.Text) < 0)
                MessageBox.Show("אין מספיק יחידות במלאי");

            else
            {
                tabControl1.TabPages.Remove(tabPage5);

                if (label63.Text == "לא נבחר לקוח" || !checkBox3.Checked)
                {
                    vetclinicDataSet.tblproductpurchasedRow PP =
                        vetclinicDataSet.tblproductpurchased.NewtblproductpurchasedRow();
                    PP.custNum = 0;
                    PP.pName = nameLabel1.Text;
                    PP.pDate = DateTime.Now;
                    PP.payStatus = false;
                    PP.quantity = int.Parse(textBox14.Text);
                    PP.discount = float.Parse(textBox15.Text)/100;

                    vetclinicDataSet.tblproductpurchased.Rows.Add(PP);
                }

                else
                {
                    custNum = int.Parse(label63.Text);
                    vetclinicDataSet.tblproductpurchasedRow PP =
                    vetclinicDataSet.tblproductpurchased.NewtblproductpurchasedRow();
                    PP.custNum = custNum ;
                    PP.pName = nameLabel1.Text;
                    PP.pDate = DateTime.Now;
                    PP.payStatus = false;
                    PP.quantity = int.Parse(textBox14.Text);
                    PP.discount = float.Parse(textBox15.Text)/100;

                    vetclinicDataSet.tblproductpurchased.Rows.Add(PP);

                }
               
                this.tblproductpurchasedTableAdapter.Update(vetclinicDataSet.tblproductpurchased);
                hideProductDetails();
                OpenBasket(custNum);
                if (custNum == 0)
                {
                    label64.Text = "כללי";
                }
                else
                {
                    label64.Text = label35.Text;
                }
            }
            
        }

        public void OpenBasket(int custNum)
        {
            if (!tabControl1.TabPages.Contains(tabPage5))
                tabControl1.TabPages.Add(tabPage5);
            vetclinicDataSet.EnforceConstraints = false;
            this.basketTableAdapter.FillByCustNum(this.vetclinicDataSet.Basket, custNum);
            if (custNum == 0)
            {
                label64.Text = "כללי";
                groupBox3.Visible = false;
            }
            else
            {
                vNumListBox.Items.Clear();
                label64.Text = label35.Text;
                groupBox3.Visible = true;
                vetclinicDataSet.tblvisitDataTable visits;
                visits = tblvisitTableAdapter.GetDataByNotPaidForCust(custNum);
                foreach (vetclinicDataSet.tblvisitRow row in visits)
                {
                    long visNum = row.vNum;
                    vNumListBox.Items.Add(visNum);
                }

                this.visitForBasketTableAdapter.FillByNotPaid(this.vetclinicDataSet.VisitForBasket,
                                                    custNum);

            }
            if (label63.Text != "לא נבחר לקוח")
                label52.Text = this.tblvisitTableAdapter.ScalarQueryTreatPay(int.Parse(label63.Text)).ToString();
            if (label52.Text == "label52")
                label52.Text = "0";
            calculateBasket();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage5);
            
            if (label63.Text == "לא נבחר לקוח")
                    OpenBasket(0);
                else
                    OpenBasket(int.Parse(label63.Text));

            tabControl1.SelectedTab = tabPage5;

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = "";
            listBox7.Items.Clear();

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select name from tblProducts where barcode LIKE @param";
            command.Parameters.AddWithValue("@param", textBox13.Text + "%");
            connection.Open();
            Reader = command.ExecuteReader();
            listBox7.Items.Clear();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                listBox7.Items.Add(thisrow);
            }
            connection.Close();
        }

        // הסרת מוצר מסל הקניות
        private void button19_Click(object sender, EventArgs e)
        {

            string name = pNameListBox.GetItemText(pNameListBox.SelectedItem);
            DateTime pDate = pDateDateTimePicker.Value;
            name.Trim();
            string custNum;
            string datestring = pDate.ToString("yyyy-MM-dd HH:mm:ss");

            
            if (label64.Text == "כללי")
            {
                custNum = "0";
            }
            else
            {
                custNum = label63.Text;
            }

            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "DELETE FROM tblproductpurchased WHERE pName = @pname AND custNum = @custNum AND pDate = @pdate";
            command.Parameters.AddWithValue("@pname", name);
            command.Parameters.AddWithValue("@custNum", custNum);
            command.Parameters.AddWithValue("@pdate",datestring);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            this.basketTableAdapter.FillByCustNum(this.vetclinicDataSet.Basket, int.Parse(custNum));
            calculateBasket();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (listBox7.SelectedIndex == -1)
                MessageBox.Show("יש לבחור מוצר");
            else
            {
                ManageProduct ep = new ManageProduct(listBox7.Text, this);
                ep.Visible = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ManageProduct ep = new ManageProduct(this);
            ep.Visible = true;
        }

        // טיפול במחיקת מוצר מהמערכת
        private void button23_Click(object sender, EventArgs e)
        {
            string text = "האם אתה בטוח שברצונך למחוק את המוצר ";
            text += nameLabel1.Text;
            text += " מהמערכת?";
            text += "\n";
            text += "פעולה זאת לא ניתנת לביטול";

            if (MessageBox.Show(text, "",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.No)
                return;
            else
            {
                vetclinicDataSet.tblproductsRow pRow;
                pRow = vetclinicDataSet.tblproducts.FindByname(nameLabel1.Text);
                pRow.Delete();
                this.tblproductsTableAdapter.Update(this.vetclinicDataSet.tblproducts);
                string text2 = "המוצר ";
                text2 += nameLabel1.Text;
                text2 += " נמחק בהצלחה מהמערכת";
                MessageBox.Show(text2);
                hideProductDetails();
                this.FillProducts();


            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage5);

            if (label63.Text == "לא נבחר לקוח")
                OpenBasket(0);
            else
                OpenBasket(int.Parse(label63.Text));

            tabControl1.SelectedTab = tabPage5;
        }

        //מחשב עלות כוללת לתשלום
        public void calculateBasket()
        {
            try
            {
                if (label63.Text != "לא נבחר לקוח")
                {
                    paymentLabel1.Text = this.paymentTableAdapter.ScalarPayment(int.Parse(label63.Text)).ToString();
                    paymentLabel1.Text = double.Parse(paymentLabel1.Text).ToString("#.##");
                }
                else
                {
                    paymentLabel1.Text = this.paymentTableAdapter.ScalarPayment(0).ToString();
                    paymentLabel1.Text = double.Parse(paymentLabel1.Text).ToString("#.##");
                    label52.Text = "0";
                }
            }
            catch (Exception exc)
            {
                if(label52.Text == "label52")
                    label52.Text = "0";
                paymentLabel1.Text = "0";
                label54.Text = "0";
            }
            if (paymentLabel1.Text == "")
                paymentLabel1.Text = "0";
            if(label52.Text == "")
                label52.Text = "0";
            if ((label52.Text != "label52" && label52.Text != "0") && (paymentLabel1.Text != "label53" && paymentLabel1.Text != "0"))
                label54.Text = (double.Parse(label52.Text) + double.Parse(paymentLabel1.Text)).ToString("#.##");
            if ((label52.Text == "label52" || label52.Text == "0") && (paymentLabel1.Text != "label53" && paymentLabel1.Text != "0"))
                label54.Text = (double.Parse(paymentLabel1.Text)).ToString("#.##");
            if ((label52.Text != "label52" && label52.Text != "0") && (paymentLabel1.Text == "label53" || paymentLabel1.Text == "0"))
                label54.Text = (double.Parse(label52.Text)).ToString("#.##");
            if ((label52.Text == "label52" || label52.Text == "0") && (paymentLabel1.Text == "label53" || paymentLabel1.Text == "0"))
                label54.Text = "0";
        }

        // מבצע את העדכונים עבור הטבלאות
        private void button25_Click(object sender, EventArgs e)
        {
            bool noStock = false;
            int custNum = 0;
            if (label64.Text != "כללי")
                custNum = int.Parse(label63.Text);
            ArrayList pNames = new ArrayList();
            
            // בדיקה שיש מספיק מלאי כדי לספק את הדרישות בסל הקניות

            vetclinicDataSet.BasketDataTable inBasket;
            inBasket = basketTableAdapter.GetDataByCustNum(custNum);

            foreach (vetclinicDataSet.BasketRow row in inBasket)
            {
                int inStock = int.Parse(tblproductsTableAdapter.getStockByName1(row.pName).ToString());
                if (row.quantitiy > inStock)
                {
                    noStock = true;
                    MessageBox.Show("אין מספיק מוצרים במלאי כדי למלא את דרישות סל הקניות. אנא הסר מוצרים ונסה שוב");
                    break;
                }
            }

            if (!noStock)
            {
                // עדכון מלאי

                // איסוף כל המוצרים בסל הקניות
                MySqlCommand command2 = connection.CreateCommand();
                MySqlDataReader Reader2;
                command2.CommandText = "SELECT pName, quantity FROM tblproductpurchased WHERE custNum = @custNum AND payStatus = 0";
                command2.Parameters.AddWithValue("@custNum", custNum);
                connection.Open();
                Reader2 = command2.ExecuteReader();
                while (Reader2.Read())
                {
                    pNames.Add(Reader2.GetValue(0).ToString());
                    pNames.Add(Reader2.GetValue(1).ToString());
                }
                connection.Close();

                //הורדת הכמות הנרכשת מהכמות במלאי
                for (int i = 0; i < pNames.Count; i += 2)
                {
                    string pName = pNames[i].ToString();
                    int quan = int.Parse(pNames[i + 1].ToString());

                    MySqlCommand command3 = connection.CreateCommand();
                    command3.CommandText = "UPDATE tblproducts SET stock = stock - @quan WHERE name = @pName";
                    command3.Parameters.AddWithValue("@quan", quan);
                    command3.Parameters.AddWithValue("@pName", pName);
                    connection.Open();
                    command3.ExecuteReader();
                    connection.Close();
                }

                // הזנת התראה במידה והמלאי מתחת לרמת המינימום
                for (int i = 0; i < pNames.Count; i += 2)
                {
                    vetclinicDataSet.tblproductsRow row;
                    string pName = (string) pNames[i];
                    int stock =(int)tblproductsTableAdapter.getStockByNAme(pName);
                    int alertstock = (int) tblproductsTableAdapter.GetAlertStockByName(pName);
                    if (stock <= alertstock)
                    {
                        int lastnot = 0;
                        lastnot = tblnotificationsTableAdapter.GetLastNotif().Value;
                        lastnot++;
                        string notString = "המוצר ";
                        notString += pNames[i];
                        notString += " עומד לאזול מהמלאי. יש להזמין ממנו עוד בהקדם.";

                        vetclinicDataSet.tblnotificationsRow newNot;
                        newNot = this.vetclinicDataSet.tblnotifications.NewtblnotificationsRow();
                        newNot.NotNum = lastnot;
                        newNot.fromDate = DateTime.Now;
                        newNot.details = notString;
                        newNot.done = false;

                        this.vetclinicDataSet.tblnotifications.AddtblnotificationsRow(newNot);
                        this.tblnotificationsTableAdapter.Update(vetclinicDataSet.tblnotifications);
                    }


                }



                // עדכון פריט כשולם
                string query =
                    "Update tblproductpurchased SET payStatus = 1  WHERE (payStatus = 0) AND (custNum = @custNum)";
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@custNum", custNum);
                connection.Open();
                command.ExecuteReader();
                connection.Close();

                // עדכון טיפול כשולם
                string query2 =
                    "Update tblvisit SET paymentStatus = 1  WHERE (paymentStatus = 0) AND (custNum = @custNum)";
                MySqlCommand command4 = connection.CreateCommand();
                command4.CommandText = query2;
                command4.Parameters.AddWithValue("@custNum", custNum);
                connection.Open();
                command4.ExecuteReader();
                connection.Close();
                if (label63.Text != "לא נבחר לקוח" && label36.Text != "לא נבחרה חיה")
                    this.tblvisitTableAdapter.FillByCustAnimal(this.vetclinicDataSet.tblvisit, int.Parse(label63.Text), label36.Text);

                // עדכון הסל
                this.basketTableAdapter.FillByCustNum(this.vetclinicDataSet.Basket, custNum);
                vNumListBox.Items.Clear();
                label52.Text = "0";
                paymentLabel1.Text = "0";
                label54.Text = "0";
            }


        }

        //הכנסת תאריכים לדוח סיכום קניות
        private void סיכוםקניותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterVacExpDates EV = new EnterVacExpDates(0);
            EV.Visible = true;
            purchaseDates = true;
        }

        //הכנסת תאריכים לדוח קניות ללקוח
        private void button26_Click(object sender, EventArgs e)
        {
            EnterVacExpDates EV = new EnterVacExpDates(int.Parse(label63.Text));
            EV.Visible = true;
            customerPurchase = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label63.Text != "לא נבחר לקוח" && label63.Text != "")
            {
                EnterVacExpDates EV = new EnterVacExpDates(int.Parse(label63.Text));
                EV.Visible = true;
            }
            else
            {
                EnterVacExpDates EV = new EnterVacExpDates(0);
                EV.Visible = true;
            }
            customerPurchase = true;
        }

        // הצגת פירוט הביקור בבחירתו
        private void vNumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                visitForBasketTableAdapter.FillByVnum(this.vetclinicDataSet.VisitForBasket,
                                                      long.Parse(vNumListBox.GetItemText(vNumListBox.SelectedItem)));
            }
            catch (Exception)
            {
                
            }

        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            OpenBasket(int.Parse(label63.Text));
            tabControl1.SelectedTab = tabPage5;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SMSSend send = new SMSSend(int.Parse(label63.Text), cellPhoneLabel3.Text);
            send.Show();
        }

        private void שליחתSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMSSend send = new SMSSend();
            send.Show();
        }

        private void שליחתSMSתזכורתחיסוניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmsDist dist = new SmsDist();
            dist.Show();
        }

        private void מסךניהולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataScripts ds = new DataScripts();
            ds.Show();
        }

        private void folderPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vetclinicDataSet.tbltestresultsRow tr = vetclinicDataSet.tbltestresults.NewtbltestresultsRow();
                tr.aName = label36.Text;
                tr.custNum = int.Parse(label63.Text);
                tr.fileName = openFileDialog1.FileName;

                //קריאת קובץ התמונה למערך ביטים
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                byte[] BlobValue = reader.ReadBytes((int)fs.Length);

                tr.fileContent = BlobValue;
                tr.testDate = DateTime.Now;

                try
                {
                    vetclinicDataSet.tbltestresults.AddtbltestresultsRow(tr);
                    tbltestresultsTableAdapter.Update(this.vetclinicDataSet.tbltestresults);
                    MessageBox.Show("התמונה נשמרה בהצלחה");
                }

                catch(Exception exec)
                {
                    if (exec.ToString().Contains("Packets larger than"))
                        MessageBox.Show("הקובץ גדול מדי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("לא ניתן לשמור את הקובץ", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
              
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ViewResults vr = new ViewResults(int.Parse(label63.Text), label36.Text);
            vr.Show();
        }

        // הוספת תוצאות בדיקת דם
        private void button30_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vetclinicDataSet.tblbloodresultsRow tr = vetclinicDataSet.tblbloodresults.NewtblbloodresultsRow();
                tr.aName = label36.Text;
                tr.custNum = int.Parse(label63.Text);
                tr.fileName = openFileDialog1.FileName;

                //קריאת קובץ התמונה למערך ביטים
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                byte[] BlobValue = reader.ReadBytes((int)fs.Length);

                tr.fileContent = BlobValue;
                tr.testDate = DateTime.Now;

                try
                {
                    vetclinicDataSet.tblbloodresults.AddtblbloodresultsRow(tr);
                    tblbloodresultsTableAdapter.Update(this.vetclinicDataSet.tblbloodresults);
                    MessageBox.Show("התמונה נשמרה בהצלחה");
                }

                catch (Exception exec)
                {
                    if (exec.ToString().Contains("Packets larger than"))
                        MessageBox.Show("הקובץ גדול מדי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("לא ניתן לשמור את הקובץ", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            BloodResults br = new BloodResults(int.Parse(label63.Text), label36.Text);
            br.Show();
        }

        //report for visits from Ramat Yohanan
        private void טיפוליםרמתיוחנןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterVacExpDates EV = new EnterVacExpDates(0);
            EV.Visible = true;
            ramatYohanan = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            TreatmentHist th = new TreatmentHist(int.Parse(label63.Text), label36.Text);
            th.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void אודותToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

    }
}
