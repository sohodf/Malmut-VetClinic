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
    public partial class changeIns : Form
    {
        public Start start;
        MySqlConnection connection = new MySqlConnection(utils.MyConString);

        public changeIns(Start start)
        {
            InitializeComponent();
            this.start = start;
        }

        private void tblinsuranceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblinsuranceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vetclinicDataSet);

        }

        private void changeIns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetclinicDataSet.tblinsurance' table. You can move, or remove it, as needed.
            this.tblinsuranceTableAdapter.Fill(this.vetclinicDataSet.tblinsurance);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE tblinsurance SET toDate = @toDate WHERE custNum = @custNum AND aName = @aName";
            command.Parameters.AddWithValue("@custNum", start.label63.Text);
            command.Parameters.AddWithValue("@aName", start.label36.Text);
            command.Parameters.AddWithValue("@toDate", toDateDateTimePicker.Value);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            start.getInsDate();
            this.Close();
        }
    }
}
