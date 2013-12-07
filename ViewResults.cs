using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class ViewResults : Form
    {
        private int custNum;
        private string aName;

        public ViewResults(int custNum, string aName)
        {
            InitializeComponent();
            this.custNum = custNum;
            this.aName = aName;
            this.tbltestresultsTableAdapter.FillByCustAndAn(this.vetclinicDataSet.tbltestresults, custNum, aName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void testDateListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DateTime date = new DateTime();
        //        date = DateTime.Parse(testDateListBox.GetItemText(testDateListBox.SelectedItem));
        //        pictureBox1.Image = byteArrayToImage(tbltestresultsTableAdapter.getImage(date, aName, custNum));
        //    }

        //    catch(Exception nofile)
        //    {
        //        //
        //    }
        //}

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void tbltestresultsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbltestresultsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vetclinicDataSet);

        }
    }
}
