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
using Vet_Clinic;

namespace Vet_Clinic
{
    public partial class editAnimal : Form
    {
        private int custNum;
        private String aName;
        private bool error = false;
        public Start start;

        MySqlConnection connection = new MySqlConnection(utils.MyConString);

        public editAnimal(int custNum, String aName, Start start)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.custNum = custNum;
            this.aName = aName;
            this.start = start;
            label8.Visible = false;
        }

        private void tblanimalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblanimalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vetclinicDataSet);

        }

        private void edtiAnimal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetclinicDataSet.tblanimal' table. You can move, or remove it, as needed.
            this.tblanimalTableAdapter.FillByDetails(this.vetclinicDataSet.tblanimal, custNum, aName);
            vetclinicDataSet.tblanimalRow custRow;
            custRow = vetclinicDataSet.tblanimal.FindBycustNumaName(int.Parse(start.label63.Text), start.label36.Text);
            if (custRow.dateNeu.ToShortDateString() == "01/01/1950")
                dateTimePicker1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

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

            if (neuteredCheckBox.Checked && dateTimePicker1.Value < dateOfBirthDateTimePicker.Value)
            {
                pictureBox6.Visible = true;
                error = true;
            }

            int n = 0;
            int d = 0;
            int sed = 0;
            int active = 0;

            if (neuteredCheckBox.Checked) n = 1;
            if (dangerousCheckBox.Checked) d = 1;
            if (seeingEyeDogCheckBox.Checked) sed = 1;
            if (activeCheckBox.Checked) active = 1;

            if (!error)
            {
                start.label36.Text = aNameTextBox.Text;
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE tblanimal SET custNum = @custNum, aName = @animName, aType = @aType, aBreed = @aBreed, aSex = @aSex, "
                 + "color = @color, chipNum = @chipNum, neutered = @n, dangerous = @d, seeingEyeDog = @sed, firstVisit = @fv, remarks = @rem, dateOfBirth = @dob, dateNeu = @don, active=@active WHERE custNum = @custNum AND aName = @aName";
                command.Parameters.AddWithValue("@custNum", custNum);
                command.Parameters.AddWithValue("@aName", aName);
                command.Parameters.AddWithValue("@animName", aNameTextBox.Text);
                command.Parameters.AddWithValue("@aType", aTypeComboBox.Text);
                command.Parameters.AddWithValue("@aBreed", aBreedComboBox.Text);
                command.Parameters.AddWithValue("@aSex", aSexComboBox.Text);
                command.Parameters.AddWithValue("@color", colorComboBox.Text);
                command.Parameters.AddWithValue("@chipNum", chipNumTextBox.Text);
                command.Parameters.AddWithValue("@n", n);
                command.Parameters.AddWithValue("@d", d);
                command.Parameters.AddWithValue("@sed", sed);
                command.Parameters.AddWithValue("@fv", firstVisitDateTimePicker.Value);
                command.Parameters.AddWithValue("@rem", remarksTextBox.Text);
                command.Parameters.AddWithValue("@dob", dateOfBirthDateTimePicker.Value);
                command.Parameters.AddWithValue("@active", active);
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
                start.tblanimalTableAdapter.FillByDetails(start.vetclinicDataSet.tblanimal, custNum, aNameTextBox.Text);  //update main form
                start.updateAge();
                vetclinicDataSet.tblanimalRow custRow;
                custRow = vetclinicDataSet.tblanimal.FindBycustNumaName(int.Parse(start.label63.Text), aName);
                if (custRow.dateNeu.ToShortDateString() == "01/01/1950")
                    start.dateNeuDateTimePicker.Hide();
                else start.dateNeuDateTimePicker.Hide();
                label8.Visible = true;
                this.Close();
            }
        }

        private void neuteredCheckBox_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == false) dateTimePicker1.Visible = true;
            else dateTimePicker1.Visible = false;
        }
    }
}
