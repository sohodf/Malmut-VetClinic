using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vet_Clinic.vetclinicDataSetTableAdapters;

namespace Vet_Clinic
{
    public partial class ManageVaccines : Form
    {
        private int custNum;
        private string aName;
        private bool changed = false;

        public ManageVaccines(int custNum, string aName)
        {
            InitializeComponent();
            this.aName = aName;
            this.custNum = custNum;
            this.tblgivenvaccineTableAdapter.FillByNumandName(this.vetclinicDataSet.tblgivenvaccine, custNum, aName);

            vetclinicDataSet.tblvaccineDataTable GV;
            GV = tblvaccineTableAdapter.getAllTypes();

            foreach (vetclinicDataSet.tblvaccineRow dr in GV.Rows)
            {
                comboBox1.Items.Add(dr.type);
            }

        }
        private void tblgivenvaccineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                
            }

            else
            {
                this.Validate();
                this.tblgivenvaccineBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.vetclinicDataSet);
            }

           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageVaccines_Load(object sender, EventArgs e)
        {

        }

        public Boolean ValidateData ()
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "כלבת" && paymentTypeComboBox.GetItemText(paymentTypeComboBox.SelectedItem) == "")
            {
                MessageBox.Show("חובה להזין אמצעי תשלום לחיסון כלבת");
                return false;

            }

            if (comboBox1.GetItemText(comboBox1.SelectedItem) != "כלבת" && paymentTypeComboBox.GetItemText(paymentTypeComboBox.SelectedItem) != "")
            {
                MessageBox.Show("ניתן להזין אמצעי תשלום רק לחיסון כלבת");
                return false;

            }
          
            return true;
        }

        private void tblgivenvaccineBindingNavigator_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateData())
                e.Cancel = true;
        }

        





    }
}
