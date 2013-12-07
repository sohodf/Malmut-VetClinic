using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class DogLicense : Form

    {


        public DogLicense(int custNum, String aName)
        {
            InitializeComponent();
            this.licenseDataTableAdapter.Fill(this.vetclinicDataSet.LicenseData, custNum, aName);
            this.Activate();
            
            
        }


        private void DogLicense_Load(object sender, EventArgs e)
        {
            if (neuteredLabel1.Text.Equals("True")) label1.Text = "כן";
            else label1.Text = "לא";
            if (seeingEyeDogLabel1.Text.Equals("True")) label2.Text = "כן";
            else label2.Text = "לא";
            if (dangerousLabel1.Text.Equals("True")) label3.Text = "כן";
            else label3.Text = "לא";
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            printForm1.Print();
        }


    }
}
