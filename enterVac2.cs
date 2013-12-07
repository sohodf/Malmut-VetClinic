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
    public partial class enterVac2 : Form
    {
        MySqlConnection connection = new MySqlConnection(utils.MyConString);
        private int custNum;
        private String aName;
        public Start start;

        public enterVac2(int custNum, String aName, Start start)
        {
            InitializeComponent();
            this.custNum = custNum;
            this.aName = aName;
            this.start = start;
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox3.SelectedIndex = 0;
            fillVac();
        }

        public void fillVac()
        {
            comboBox1.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select type from tblvaccine";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + " ";
                comboBox1.Items.Add(thisrow);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("יש לבחור חיסון", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.Text.Trim() == "כלבת" && comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("יש לבחור אמצעי תשלום", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int lasts = 0;
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "SELECT lasts FROM tblvaccine where type = @type";
                    command.Parameters.AddWithValue("@type", comboBox1.Text);
                    connection.Open();
                    string theTime = command.ExecuteScalar().ToString();
                    if (theTime != "")
                        lasts = Int32.Parse(command.ExecuteScalar().ToString());
                    connection.Close();

                    MySqlCommand command4 = connection.CreateCommand();
                    command4.CommandText =
                        "INSERT INTO tblgivenvaccine (aName, Vnum, custNum, type, dateGiven, nextVac, noticeSent, paymentType, place) Values (@aName, @vNum, @custNum, @type, @dateGiven, @nextVac, @noticeSent, @paymentType, @place)";
                    command4.Parameters.AddWithValue("@aName", aName);
                    command4.Parameters.AddWithValue("@vNum", null);
                    command4.Parameters.AddWithValue("@custNum", custNum);
                    command4.Parameters.AddWithValue("@type", comboBox1.Text);
                    command4.Parameters.AddWithValue("@dateGiven", DateTime.Now);
                    if (comboBox2.SelectedIndex != -1)
                        command4.Parameters.AddWithValue("@paymentType", comboBox2.Text);
                    else
                        command4.Parameters.AddWithValue("@paymentType", null);
                    if (theTime != "")
                        command4.Parameters.AddWithValue("@nextVac", dateTimePicker1.Value);
                    else
                        command4.Parameters.AddWithValue("@nextVac", null);
                    command4.Parameters.AddWithValue("@noticeSent", 0);
                    command4.Parameters.AddWithValue("@place", comboBox3.Text);
                    connection.Open();
                    command4.ExecuteReader();
                    connection.Close();
                    MessageBox.Show("חיסון נשמר", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lastVacs lv = new lastVacs(Int32.Parse(start.label63.Text), start.label36.Text, start);
                    lv.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(100);

            int lasts = 0;
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "SELECT lasts FROM tblvaccine where type = @type";
            command.Parameters.AddWithValue("@type", comboBox1.Text);
            connection.Open();
            string theTime = command.ExecuteScalar().ToString();
            if (theTime != "")
                lasts = Int32.Parse(command.ExecuteScalar().ToString());
            connection.Close();

            dateTimePicker1.Value = DateTime.Today.AddDays(lasts);
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(lasts);

            if (comboBox1.Text.Trim() == "כלבת")
            {
                comboBox2.Visible = true;
                label3.Visible = true;
            }
                
            else
            {
                comboBox2.Visible = false;
                label3.Visible = false;
                comboBox2.SelectedIndex = -1;
            }

        }
    }
}
