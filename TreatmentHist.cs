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
    public partial class TreatmentHist : Form
    {
        private int custNum;
        private string aName;
        
        public TreatmentHist(int custNum, String aName)
        {
            InitializeComponent();
            this.custNum = custNum;
            this.aName = aName;

            this.tblvisitTableAdapter.FillByCustAnimal(this.vetclinicDataSet.tblvisit, custNum, aName);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TreatmentHist_Load(object sender, EventArgs e)
        {

        }
    }
}
