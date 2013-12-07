using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vet_Clinic;
using Project1;

namespace Vet_Clinic
{
    public partial class CreateNot : Form
    {
        private int notNum;
        private Start startLoc;

        public CreateNot(Start start)
        {
            InitializeComponent();
            toDateDateTimePicker.MinDate = fromDateDateTimePicker.Value.AddDays(1);
            startLoc = start;
            try
            {
               notNum = (int)tblnotificationsTableAdapter.LastNotScalarQuery();
            }
            
            catch( Exception NoNotifications)
            {
                notNum = 0;
            }
            
            notNum++;
            notNumLabel1.Text = notNum.ToString();
            if (start.label63.Text == "לא נבחר לקוח")
            {
                custNumLabel1.Text = "";
            }
            else
            {
                custNumLabel1.Text = start.label63.Text;
            }

            if (start.label36.Text == "לא נבחרה חיה")
            {
                aNameLabel1.Text = "";
            }
            else
            {
                aNameLabel1.Text = start.label36.Text;
            }

            fromDateDateTimePicker.MinDate = DateTime.Today;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (detailsTextBox.Text == "") label1.Visible = true;
            else
            {
                vetclinicDataSet.tblnotificationsRow notRow = vetclinicDataSet.tblnotifications.NewtblnotificationsRow();
                notRow.NotNum = int.Parse(notNumLabel1.Text);
                notRow.fromDate = fromDateDateTimePicker.Value;
                notRow.toDate = toDateDateTimePicker.Value;
                if (aNameLabel1.Text == "") notRow.aName = null;
                else notRow.aName = aNameLabel1.Text;
                if (custNumLabel1.Text == "") notRow.custNum = 0;
                else notRow.custNum = int.Parse(custNumLabel1.Text);
                notRow.details = detailsTextBox.Text;

                vetclinicDataSet.tblnotifications.Rows.Add(notRow);
                this.tblnotificationsTableAdapter.Update(vetclinicDataSet.tblnotifications);

                startLoc.GetNotifications();
                this.Close();

            }
        }

        private void fromDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            toDateDateTimePicker.MinDate = fromDateDateTimePicker.Value.AddDays(1);
        }




    }
}
