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
    public partial class AddAnimal : Form
    {
        private int custNum;
        private bool error = false;
        public Start start;
        // mysql connection string

        MySqlConnection connection = new MySqlConnection(utils.MyConString);


        // end connection string


        public AddAnimal(int custNum, Start start)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.custNum = custNum;
            custNumLabel1.Text = custNum.ToString();
            firstVisitDateTimePicker.Value = DateTime.Today;
            dateOfBirthDateTimePicker.MaxDate = DateTime.Today;
            this.start = start;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAnimal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            


            if (aNameTextBox.Text == "")
            {
                pictureBox1.Visible = true;
                error = true;
            }

            if (aTypeComboBox.Text == "")
            {
                pictureBox2.Visible = true;
                error = true;
            }

            if (aBreedComboBox.Text == "")
            {
                pictureBox3.Visible = true;
                error = true;
            }

            if (aSexComboBox.Text == "")
            {
                pictureBox4.Visible = true;
                error = true;
            }

            if (colorComboBox.Text == "")
            {
                pictureBox5.Visible = true;
                error = true;
            }

            if (neuteredCheckBox.Checked && dateTimePicker1.Value == DateTime.Today || dateTimePicker1.Value < dateOfBirthDateTimePicker.Value)
            {
                pictureBox6.Visible = true;
                error = true;
            }

            int n = 0;
            int d = 0;
            int sed = 0;

            if (neuteredCheckBox.Checked) n = 1;
            if (dangerousCheckBox.Checked) d = 1;
            if (seeingEyeDogCheckBox.Checked) sed = 1;

            if (!error)
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO tblAnimal Values (@custNum, @aName, @aType, @aBreed, @aSex, @color, @chipNum, @n, @d, @sed, @fv, @rem, @dob, @don, @active)";
                command.Parameters.AddWithValue("@custNum", int.Parse(custNumLabel1.Text));
                command.Parameters.AddWithValue("@aName", aNameTextBox.Text);
                command.Parameters.AddWithValue("@aType", aTypeComboBox.Text);
                command.Parameters.AddWithValue("@aBreed", aBreedComboBox.Text);
                command.Parameters.AddWithValue("@aSex", aSexComboBox.Text);
                command.Parameters.AddWithValue("@color", colorComboBox.Text);
                command.Parameters.AddWithValue("@chipNum", chipNumTextBox.Text);
                command.Parameters.AddWithValue("@n",  n);
                command.Parameters.AddWithValue("@d",d);
                command.Parameters.AddWithValue("@sed", sed);
                command.Parameters.AddWithValue("@fv", firstVisitDateTimePicker.Value);
                command.Parameters.AddWithValue("@rem", remarksTextBox.Text);
                command.Parameters.AddWithValue("@dob", dateOfBirthDateTimePicker.Value);
                command.Parameters.AddWithValue("active", 1);
                if (neuteredCheckBox.Checked)
                {
                    command.Parameters.AddWithValue("@don", dateTimePicker1.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@don", "1950-01-01 00:00:00");
                }
                    
                connection.Open();
                command.ExecuteReader();
                connection.Close();
                MessageBox.Show("נשמר בהצלחה");
                
                start.listBox2.Items.Clear();
                MySqlCommand command2 = connection.CreateCommand();
                MySqlDataReader Reader;
                command2.CommandText = "select aName from tblanimal where custNum = '" + custNum + "'";
                connection.Open();

                Reader = command2.ExecuteReader();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i).ToString() + " ";
                    start.listBox2.Items.Add(thisrow);
                }


                connection.Close();
                this.Close();
            }
        }

        private void neuteredCheckBox_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled) dateTimePicker1.Enabled = false;
            else dateTimePicker1.Enabled = true;
        }



    }
}
