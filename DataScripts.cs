using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class DataScripts : Form
    {
        vetclinicDataSet.tblcustomerDataTable customers = new vetclinicDataSet.tblcustomerDataTable();
        public static int correctDigitsNum = 10;

        public DataScripts()
        {
            InitializeComponent();
            this.tblcustomerTableAdapter.Fill(customers);
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = customers.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        // הסרת מקפים
        private void button1_Click(object sender, EventArgs e)
        {
            int numsCorrected = 0;
            foreach(vetclinicDataSet.tblcustomerRow cust in customers)
            {
                if (cust.cellPhone.Length > correctDigitsNum)
                {
                    cust.cellPhone = Regex.Replace(cust.cellPhone, "-", "");
                    tblcustomerTableAdapter.Update(cust);
                    numsCorrected++;
                    progressBar1.Value++;
                }
            }

            string message = "מספר הטלפונים שתוקנו: ";
            message += numsCorrected.ToString();
            progressBar1.Value = 0;

            MessageBox.Show(message);
        }


        // הוספת אפסים
        private void button2_Click(object sender, EventArgs e)
        {
            int numsCorrected = 0;

            foreach (vetclinicDataSet.tblcustomerRow cust in customers)
            {
                if (cust.cellPhone.Length < correctDigitsNum && cust.cellPhone != "")
                {
                    cust.cellPhone = "0" + cust.cellPhone;
                    tblcustomerTableAdapter.Update(cust);
                    numsCorrected++;
                    progressBar1.Value++;
                }
            }

            string message = "מספר הטלפונים שתוקנו: ";
            message += numsCorrected.ToString();
            MessageBox.Show(message);
            progressBar1.Value = 0;
        }
    }
}
