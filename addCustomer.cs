using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project1;

namespace Vet_Clinic
{
    public partial class addCustomer : Form
    {
        private bool error = false;
        public Start start;
        public int custNum2;
        // mysql connection string

        MySqlConnection connection = new MySqlConnection(utils.MyConString);


        // end connection string

        public addCustomer(Start start)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.start = start;
        }

        private void tblcustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblcustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vetclinicDataSet);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            error = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            int n;

            if (firstNameTextBox.Text == "" || utils.isLetters(firstNameTextBox.Text))
            {
                pictureBox1.Visible = true;
                error = true;
            }

            if (lastNameTextBox.Text == "" || utils.isLetters(lastNameTextBox.Text))
            {
                pictureBox2.Visible = true;
                error = true;
            }

            int result;

            if (idTextBox.Text != "")
            {
                if (!Int32.TryParse(idTextBox.Text, out result) || idTextBox.Text.Length != 9)
                {
                    pictureBox3.Visible = true;
                    error = true;
                }
            }

            if (addressTextBox.Text == "")
            {
                pictureBox4.Visible = true;
                error = true;
            }

            if (cityComboBox.Text == "")
            {
                pictureBox5.Visible = true;
                error = true;
            }

            if (homePhoneTextBox.Text != "")
            {
                if ((!Int32.TryParse(homePhoneTextBox.Text, out result)))
                {
                    pictureBox6.Visible = true;
                    error = true;
                }
            }

            if (cellPhoneTextBox.Text != "")
            {
                if ((!Int32.TryParse(cellPhoneTextBox.Text, out result)))
                {
                    pictureBox7.Visible = true;
                    error = true;
                }
            }

            
            if (idTextBox.Text != "" && !error)
            {
                int custId = Int32.Parse(idTextBox.Text);
                MySqlCommand command5 = connection.CreateCommand();
                MySqlDataReader Reader5;
                command5.CommandText = "select firstName, lastName, custNum from tblCustomer where id = @param";
                command5.Parameters.AddWithValue("@param", custId);
                connection.Open();
                string msg = "";

                Reader5 = command5.ExecuteReader();
                while (Reader5.Read())
                {
                    for (int i = 0; i < Reader5.FieldCount; i++)
                    {
                        msg += Reader5.GetValue(i).ToString() + " ";
                    }
                }
                connection.Close();

                if (msg.Count() > 0)
                {
                    //if customer with this id already exists
                    MessageBox.Show("קיים לקוח עם ת.ז. זו. שמו ומספרו: " + msg, "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    error = true;
                }
            }


            if (!error)
            {
                    int custNum = 0;
                    MySqlCommand command3 = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command3.CommandText = "SELECT MAX(custNum) FROM tblcustomer";
                    connection.Open();
                    String temp = command3.ExecuteScalar().ToString();
                    if (temp == "")
                        custNum = 1;
                    else
                        custNum = Int32.Parse(temp) + 1;
                    connection.Close();
                    custNum2 = custNum;

                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText =
                        "INSERT INTO tblcustomer Values (@custNum, @memberSince, @firstName, @lastName, @id, @address, @city, @homePhone, @cellPhone, @email)";
                    command.Parameters.AddWithValue("@custNum", custNum);
                    command.Parameters.AddWithValue("@memberSince", DateTime.Now);
                    command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@id", idTextBox.Text);
                    command.Parameters.AddWithValue("@address", addressTextBox.Text);
                    command.Parameters.AddWithValue("@city", cityComboBox.Text);
                    command.Parameters.AddWithValue("@homePhone", homePhoneTextBox.Text);
                    command.Parameters.AddWithValue("@cellPhone", cellPhoneTextBox.Text);
                    command.Parameters.AddWithValue("@email", emailTextBox.Text);
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                    start.label35.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                    start.label63.Text = custNum.ToString();

                    button1.Visible = true;

                    start.listBox1.Items.Clear();
                    start.listBox2.Items.Clear();
                    start.label63.Text = "";
                    start.label35.Text = "";
                    start.label36.Text = "";
                    start.tabControl1.TabPages.Remove(start.tabPage2);
                    start.tabControl1.TabPages.Remove(start.tabPage4);

                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlDataReader Reader2;
                    command2.CommandText =
                        "select firstName, lastName, custNum from tblcustomer where custNum LIKE @param";
                    command2.Parameters.AddWithValue("@param", custNum);
                    connection.Open();

                    Reader2 = command2.ExecuteReader();
                    while (Reader2.Read())
                    {
                        string thisrow = "";
                        for (int i = 0; i < Reader2.FieldCount; i++)
                            thisrow += Reader2.GetValue(i).ToString() + " ";
                        start.listBox1.Items.Add(thisrow);
                    }

                    connection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAnimal aa = new AddAnimal(custNum2, start);
            this.Close();
            aa.Visible = true;
        }
    }
}
