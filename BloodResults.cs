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
    public partial class BloodResults : Form
    {
        private int custNum;
        private string aName;

        public BloodResults(int custNum, string aName)
        {
            InitializeComponent();
            custNum = custNum;
            aName = aName;
            this.tblbloodresultsTableAdapter.FillByCust(this.vetclinicDataSet.tblbloodresults, custNum, aName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
