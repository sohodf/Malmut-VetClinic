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
    public partial class EnterRabiesDates : Form
    {
        public EnterRabiesDates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.Load(@"" + utils.crys + "RabiesAta.rpt");

            CrystalDecisions.Shared.ParameterField parameterField;
            parameterField = report.ParameterFields["startDate"];
            parameterField.CurrentValues.AddValue(dateTimePicker1.Value);

            CrystalDecisions.Shared.ParameterField parameterField2;
            parameterField2 = report.ParameterFields["endDate"];
            parameterField2.CurrentValues.AddValue(dateTimePicker2.Value);

            VaccineExpRpt VE = new VaccineExpRpt();

            VE.setReport(report);
            VE.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
