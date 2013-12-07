using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project1;

namespace Vet_Clinic
{
    public partial class EnterVacExpDates : Form
    {
        private int custNum;

        public EnterVacExpDates(int custNum)
        {
            InitializeComponent();
            this.custNum = custNum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Start.vacExp == true)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "VaccineExp.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["startDate"];
                parameterField.CurrentValues.AddValue(dateTimePicker1.Value.Date);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["endDate"];
                parameterField2.CurrentValues.AddValue(dateTimePicker2.Value.Date);

                VaccineExpRpt VE = new VaccineExpRpt();

                VE.setReport(report);
                VE.ShowDialog();
                this.Close();
                Start.vacExp = false;
            }

            if (Start.purchaseDates == true)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "PurchaseDates.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["startDate"];
                parameterField.CurrentValues.AddValue(dateTimePicker1.Value);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["endDate"];
                parameterField2.CurrentValues.AddValue(dateTimePicker2.Value);

                PurchaseDateRpt PD = new PurchaseDateRpt();

                PD.setReport(report);
                PD.ShowDialog();
                this.Close();
                Start.purchaseDates = false;
            }

            if (Start.customerPurchase == true)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "CustomerPurchase.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["startDate"];
                parameterField.CurrentValues.AddValue(dateTimePicker1.Value);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["endDate"];
                parameterField2.CurrentValues.AddValue(dateTimePicker2.Value);

                CrystalDecisions.Shared.ParameterField parameterField3;
                parameterField3 = report.ParameterFields["custNum"];
                parameterField3.CurrentValues.AddValue(custNum);

                CustomerPurchaseRpt CP = new CustomerPurchaseRpt();

                CP.setReport(report);
                CP.ShowDialog();
                this.Close();
                Start.customerPurchase = false;
            }

            if (Start.ramatYohanan == true)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument report =
                    new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(@"" + utils.crys + "RamatYohanan.rpt");

                CrystalDecisions.Shared.ParameterField parameterField;
                parameterField = report.ParameterFields["startDate"];
                parameterField.CurrentValues.AddValue(dateTimePicker1.Value);

                CrystalDecisions.Shared.ParameterField parameterField2;
                parameterField2 = report.ParameterFields["endDate"];
                parameterField2.CurrentValues.AddValue(dateTimePicker2.Value);

                RamatYohananRpt RY = new RamatYohananRpt();

                RY.setReport(report);
                RY.ShowDialog();
                this.Close();
                Start.ramatYohanan = false;
            }
        }
    }
}
