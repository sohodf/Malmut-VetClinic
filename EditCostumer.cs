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
    public partial class EditCostumer : Form
    {
        private Start ClassStart;
        private int ClassCustNum;
        MySqlConnection connection = new MySqlConnection(utils.MyConString);
 
        public EditCostumer(Start start, int custNum)
        {
            InitializeComponent();
            ClassStart = start;
            ClassCustNum = custNum;
            
            this.tblcustomerTableAdapter.FillByCustNum(this.vetclinicDataSet.tblcustomer, ClassCustNum);

        }



        private void button7_Click(object sender, EventArgs e)
        {
            string errors = ":שגיאה! פרטים שגויים או חסרים פרטים";
            errors += "\n";
            Boolean errorFound = false;

            int n;

            if (firstNameTextBox1.Text == "" || utils.isLetters(firstNameTextBox1.Text))
            {
                errors += "\n";
                errors += "חובה למלא שם פרטי המורכב מאותיות בלבד";
                errorFound = true;
            }
            if (lastNameTextBox1.Text == "" || utils.isLetters(lastNameTextBox1.Text))
            {
                errors += "\n";
                errors += "חובה למלא שם משפחה המורכב מאותיות בלבד";
                errorFound = true;
            }
            if (addressTextBox1.Text == "")
            {
                errors += "\n";
                errors += "חובה למלא כתובת";
                errorFound = true;
            }

            if (cityComboBox1.Text == "")
            {
                errors += "\n";
                errors += "חובה לבחור עיר";
                errorFound = true;
            }

            int result;

            if (idTextBox1.Text != "")
            {
                if (!Int32.TryParse(idTextBox1.Text, out result))
                {
                    errors += "\n";
                    errors += "ת.ז חייבת להיות מספר";
                    errorFound = true;
                }

                else if (idTextBox1.Text.Length != 9)
                {
                    errors += "\n";
                    errors += "ת.ז חייבת להיות באורך 9 ספרות";
                    errorFound = true;
                }

            }

            if (cellPhoneTextBox1.Text != "")
            {
                if ((!Int32.TryParse(cellPhoneTextBox1.Text, out result)))
                {
                    errors += "\n";
                    errors += "מספר הנייד יכול להכיל מספרים בלבד";
                    errorFound = true;
                }

            }

            if (homePhoneTextBox1.Text != "")
            {
                if ((!Int32.TryParse(homePhoneTextBox1.Text, out result)))
                {
                    errors += "\n";
                    errors += "מספר הטלפון יכול להכיל מספרים בלבד";
                    errorFound = true;
                }

            }


            if (errorFound)
                MessageBox.Show(errors);
            else
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE tblcustomer SET memberSince = @MS, firstName = @fn, lastName = @ln, id = @id, address = @add, "
                 + "city = @city, homePhone = @HF, cellPhone = @CF, email = @email WHERE custNum = @cNum";
                command.Parameters.AddWithValue("@MS", memberSinceDateTimePicker1.Value);
                command.Parameters.AddWithValue("fn", firstNameTextBox1.Text);
                command.Parameters.AddWithValue("@ln", lastNameTextBox1.Text);
                command.Parameters.AddWithValue("@id", idTextBox1.Text);
                command.Parameters.AddWithValue("@add", addressTextBox1.Text);
                command.Parameters.AddWithValue("@city", cityComboBox1.Text);
                command.Parameters.AddWithValue("@HF", homePhoneTextBox1.Text);
                command.Parameters.AddWithValue("@CF", cellPhoneTextBox1.Text);
                command.Parameters.AddWithValue("@email", emailTextBox1.Text);
                command.Parameters.AddWithValue("@cNum", custNumLabel3.Text);
                connection.Open();
                command.ExecuteReader();
                connection.Close();

                ClassStart.tblcustomerTableAdapter.FillByCustNum(ClassStart.vetclinicDataSet.tblcustomer, ClassCustNum);
                this.Close();
            }
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
